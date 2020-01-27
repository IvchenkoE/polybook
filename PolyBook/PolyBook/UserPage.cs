using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PolyBook
{
    public partial class Form1 : Form
    {
        private String strConn;
        private string server;
        private string database;
        private string uid;
        private string password;
        private int Uid;
        private bool isComboboxSelected;
        private String[] equipment;

        private bool isTechMicro;
        private bool isTechPK;
        private bool isTechProect;
        private bool isTechInter;
        private bool isAllTechInRoom;

        public Form1(int id)
        {
            InitializeComponent();
            Uid = id;

            server = "localhost";
            database = "database";
            uid = "root";
            password = "root";
            strConn = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            cn.ConnectionString = strConn;
            isComboboxSelected = false;
            equipment = new String[4];
            isTechMicro = false;
            isTechPK = false;
            isTechProect = false;
            isTechInter = false;
            isAllTechInRoom = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection failed!", "Connection", MessageBoxButtons.OK);
            }
            getUserData();
            showUserBooks();
            fillEquipment();
            fillRoomTypes();
            fillCatalog();
        }

        private void fillCatalog()
        {
            MySqlCommand cmd = new MySqlCommand("call showRooms();", cn);
            cmd.ExecuteNonQuery();

            MySqlDataAdapter dAdapter = new MySqlDataAdapter();
            dAdapter.SelectCommand = cmd;
            dAdapter.Fill(dataSetCatalog);
            dataGridViewCatalog.DataSource = dataSetCatalog.Tables[0];
        }

        private void getUserData()
        {
            MySqlCommand cmd = new MySqlCommand("call showUserData(@str);", cn);

            MySqlParameter p = new MySqlParameter();
            p = cmd.Parameters.Add("@str", MySqlDbType.Int32);
            p.Direction = ParameterDirection.Input;
            p.Value = Uid;
            var result = cmd.ExecuteReader();
            while (result.Read())
            {
                label_name.Text = result["firstname"].ToString();
                label_fam.Text = result["lastname"].ToString();
                label_fname.Text = result["fathername"].ToString();
                label_email.Text = result["email"].ToString();
                label_call_number.Text = result["phonenumber"].ToString();
            }
            if (label_name.Text == "")
            {
                label_name.Text = "Не указано";
            }
            if (label_fam.Text == "")
            {
                label_fam.Text = "Не указано";
            }
            if (label_fname.Text == "")
            {
                label_fname.Text = "Не указано";
            }
            if (label_call_number.Text == "")
            {
                label_call_number.Text = "Не указано";
            }
            
            result.Close();
        }

        private void fillEquipment()
        {
            equipment[0] = "Микрофон";
            equipment[1] = "Проектор";
            equipment[2] = "Персональный компьютер";
            equipment[3] = "Интерактивная доска";
        }

        private void fillRoomTypes()
        {
            comboBoxType.Items.Add("Все");
            comboBoxType.Items.Add("Лекционная");
            comboBoxType.Items.Add("Учебная");
            comboBoxType.Items.Add("Лаборатория");
            comboBoxType.SelectedIndex = 0;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            isComboboxSelected = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form upd = new UpdateUser(Uid);
            upd.Show();
            this.Close();
        }

        private void showUserBooks()
        {
            dataSetBooking.Clear();
            comboBox1.Items.Clear();
            MySqlCommand cmd = new MySqlCommand("call showUserBooks(@str);", cn);

            MySqlParameter id = new MySqlParameter();
            id = cmd.Parameters.Add("@str", MySqlDbType.Int32);
            id.Direction = ParameterDirection.Input;
            id.Value = Uid;

            MySqlDataAdapter dAdapter = new MySqlDataAdapter();
            dAdapter.SelectCommand = cmd;
            dAdapter.Fill(dataSetBooking);
            dataGridViewBooking.DataSource = dataSetBooking.Tables[0];

            cmd = new MySqlCommand("call showUserBooksSh(@str);", cn);

            MySqlParameter id1 = new MySqlParameter();
            id1 = cmd.Parameters.Add("@str", MySqlDbType.Int32);
            id1.Direction = ParameterDirection.Input;
            id1.Value = Uid;

            var result = cmd.ExecuteReader();
            while (result.Read())
            {
                comboBox1.Items.Add(result["id"] + " - Номер ауд. " + result["roomnum"] + 
                    ", Дата - " + result["Date"] + ", Время " + result["sttime"] + " - " + result["endtime"]);
            }
            result.Close();
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.Enabled = true;
            }
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (isComboboxSelected)
            {
                String s = comboBox1.SelectedItem.ToString();
                s = s.Remove(s.IndexOf("-") - 1, s.Length - s.IndexOf("-") + 1);
                int bookId = Convert.ToInt32(s);

                MySqlCommand cmd = new MySqlCommand("call deleteBook(@str);", cn);

                MySqlParameter id = new MySqlParameter();
                id = cmd.Parameters.Add("@str", MySqlDbType.Int32);
                id.Direction = ParameterDirection.Input;
                id.Value = bookId;

                cmd.ExecuteNonQuery();

                showUserBooks();

                if (comboBox1.Items.Count > 0)
                {
                    comboBox1.SelectedItem = comboBox1.Items[0];
                    comboBox1.Enabled = true;
                }
                else
                {
                    comboBox1.Enabled = false;
                    comboBox1.Items.Clear();
                    isComboboxSelected = false;
                }

            }
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            if (checkedListBoxBooking.CheckedItems.Count > 0)
            {
                for (int i = 0; i < checkedListBoxBooking.CheckedItems.Count; i++)
                {
                    if (checkedListBoxBooking.CheckedItems[i].ToString() == equipment[0])
                    {
                        MySqlCommand cmd1 = new MySqlCommand("call getequipRoomId(@idEqup, @idRoom);", cn);

                        MySqlParameter idEqup = new MySqlParameter();
                        idEqup = cmd1.Parameters.Add("@idEqup", MySqlDbType.Int32);
                        idEqup.Direction = ParameterDirection.Input;
                        idEqup.Value = 1;

                        MySqlParameter idRoom = new MySqlParameter();
                        idRoom = cmd1.Parameters.Add("@idRoom", MySqlDbType.Int32);
                        idRoom.Direction = ParameterDirection.Input;
                        idRoom.Value = textBoxRoomIdBooking.Text;
                        int id = -1;
                        try
                        {
                            id = Convert.ToInt32(cmd1.ExecuteScalar());
                        }
                        catch (Exception)
                        {

                        }
                        if (id > 0)
                        {
                            isTechMicro = true;
                        }
                    }
                    else if (checkedListBoxBooking.CheckedItems[i].ToString() == equipment[1])
                    {
                        MySqlCommand cmd1 = new MySqlCommand("call getequipRoomId(@idEqup, @idRoom);", cn);

                        MySqlParameter idEqup = new MySqlParameter();
                        idEqup = cmd1.Parameters.Add("@idEqup", MySqlDbType.Int32);
                        idEqup.Direction = ParameterDirection.Input;
                        idEqup.Value = 2;

                        MySqlParameter idRoom = new MySqlParameter();
                        idRoom = cmd1.Parameters.Add("@idRoom", MySqlDbType.Int32);
                        idRoom.Direction = ParameterDirection.Input;
                        idRoom.Value = textBoxRoomIdBooking.Text;
                        int id = -1;
                        try
                        {
                            id = Convert.ToInt32(cmd1.ExecuteScalar());
                        }
                        catch (Exception)
                        {

                        }
                        if (id > 0)
                        {
                            isTechPK = true;
                        }
                    }
                    else if (checkedListBoxBooking.CheckedItems[i].ToString() == equipment[2])
                    {
                        MySqlCommand cmd1 = new MySqlCommand("call getequipRoomId(@idEqup, @idRoom);", cn);

                        MySqlParameter idEqup = new MySqlParameter();
                        idEqup = cmd1.Parameters.Add("@idEqup", MySqlDbType.Int32);
                        idEqup.Direction = ParameterDirection.Input;
                        idEqup.Value = 3;

                        MySqlParameter idRoom = new MySqlParameter();
                        idRoom = cmd1.Parameters.Add("@idRoom", MySqlDbType.Int32);
                        idRoom.Direction = ParameterDirection.Input;
                        idRoom.Value = textBoxRoomIdBooking.Text;
                        int id = -1;
                        try
                        {
                            id = Convert.ToInt32(cmd1.ExecuteScalar());
                        }
                        catch (Exception)
                        {

                        }
                        if (id > 0)
                        {
                            isTechProect = true;
                        }
                    }
                    else if (checkedListBoxBooking.CheckedItems[i].ToString() == equipment[3])
                    {
                        MySqlCommand cmd1 = new MySqlCommand("call getequipRoomId(@idEqup, @idRoom);", cn);

                        MySqlParameter idEqup = new MySqlParameter();
                        idEqup = cmd1.Parameters.Add("@idEqup", MySqlDbType.Int32);
                        idEqup.Direction = ParameterDirection.Input;
                        idEqup.Value = 4;

                        MySqlParameter idRoom = new MySqlParameter();
                        idRoom = cmd1.Parameters.Add("@idRoom", MySqlDbType.Int32);
                        idRoom.Direction = ParameterDirection.Input;
                        idRoom.Value = textBoxRoomIdBooking.Text;
                        int id = -1;
                        try
                        {
                            id = Convert.ToInt32(cmd1.ExecuteScalar());
                        }
                        catch (Exception)
                        {

                        }
                        if (id > 0)
                        {
                            isTechInter = true;
                        }
                    }
                }
            }

            if (checkedListBoxBooking.CheckedItems.Count > 0)
            {
                for (int i = 0; i < checkedListBoxBooking.CheckedItems.Count; i++)
                {
                    if (checkedListBoxBooking.CheckedItems[i].ToString() == equipment[0])
                    {
                        if (!(isTechMicro))
                        {
                            MessageBox.Show("В данной аудитории нет Микрофона", "Ошибка в выборе технического оборудования", MessageBoxButtons.OK);
                            return;
                        }
                            
                    }
                    else if (checkedListBoxBooking.CheckedItems[i].ToString() == equipment[1])
                    {
                        if (!(isTechPK))
                        {
                            MessageBox.Show("В данной аудитории нет Персонального компьютера", "Ошибка в выборе технического оборудования", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    else if (checkedListBoxBooking.CheckedItems[i].ToString() == equipment[2])
                    {
                        if (!(isTechProect))
                        {
                            MessageBox.Show("В данной аудитории нет Проектора", "Ошибка в выборе технического оборудования", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    else if (checkedListBoxBooking.CheckedItems[i].ToString() == equipment[3])
                    {
                        if (!(isTechInter))
                        {
                            MessageBox.Show("В данной аудитории нет Интерактивной доски", "Ошибка в выборе технического оборудования", MessageBoxButtons.OK);
                            return;
                        }
                    }
                }
            }

            try
            {
                if (TimeSpan.Parse(textBoxTimeStartBooking.Text + ":00") < TimeSpan.Parse(textBoxTimeEndBooking.Text + ":00"))
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand("call addBook(@Uid, @RoomId, @date, @sttime, @endtime, @purpose, @isEquip);", cn);

                        MySqlParameter usid = new MySqlParameter();
                        usid = cmd.Parameters.Add("@Uid", MySqlDbType.Int32);
                        usid.Direction = ParameterDirection.Input;
                        usid.Value = Uid;

                        MySqlParameter rid = new MySqlParameter();
                        rid = cmd.Parameters.Add("@RoomId", MySqlDbType.Int32);
                        rid.Direction = ParameterDirection.Input;
                        rid.Value = textBoxRoomIdBooking.Text;

                        MySqlParameter date = new MySqlParameter();
                        date = cmd.Parameters.Add("@Date", MySqlDbType.Date);
                        date.Direction = ParameterDirection.Input;
                        date.Value = monthCalendarBooking.SelectionRange.Start;

                        MySqlParameter sttime = new MySqlParameter();
                        sttime = cmd.Parameters.Add("@sttime", MySqlDbType.Time);
                        sttime.Direction = ParameterDirection.Input;
                        string time = textBoxTimeStartBooking.Text + ":00";


                        sttime.Value = TimeSpan.Parse(time);

                        MySqlParameter endtime = new MySqlParameter();
                        endtime = cmd.Parameters.Add("@endtime", MySqlDbType.Time);
                        endtime.Direction = ParameterDirection.Input;
                        time = textBoxTimeEndBooking.Text + ":00";
                        endtime.Value = TimeSpan.Parse(time);

                        MySqlParameter purpose = new MySqlParameter();
                        purpose = cmd.Parameters.Add("@purpose", MySqlDbType.VarChar);
                        purpose.Direction = ParameterDirection.Input;
                        purpose.Value = richTextBoxBooking.Text;

                        MySqlParameter isEquip = new MySqlParameter();
                        isEquip = cmd.Parameters.Add("@isEquip", MySqlDbType.Int16);
                        isEquip.Direction = ParameterDirection.Input;

                        if (checkedListBoxBooking.CheckedItems.Count > 0)
                        {
                            isEquip.Value = 1;
                        }
                        else
                        {
                            isEquip.Value = 0;
                        }

                        int rows = cmd.ExecuteNonQuery();
                        if (rows == 0)
                        {
                            MessageBox.Show("Данные введены неверно", "Ошибка в данных", MessageBoxButtons.OK);
                        }
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Данные введены неверно", "Ошибка в данных", MessageBoxButtons.OK);
                    }

                    string sql = "select max(id) from booking";

                    MySqlCommand command = new MySqlCommand(sql, cn);
                    int bookId = Convert.ToInt32(command.ExecuteScalar().ToString());

                    if (checkedListBoxBooking.CheckedItems.Count > 0)
                    {
                        for (int i = 0; i < checkedListBoxBooking.CheckedItems.Count; i++)
                        {
                            if (checkedListBoxBooking.CheckedItems[i].ToString() == equipment[0])
                            {
                                MySqlCommand cmd1 = new MySqlCommand("call addEquipBook(@idEqup, @idBook);", cn);

                                MySqlParameter id = new MySqlParameter();
                                id = cmd1.Parameters.Add("@idBook", MySqlDbType.Int32);
                                id.Direction = ParameterDirection.Input;
                                id.Value = bookId;

                                MySqlParameter idEq = new MySqlParameter();
                                idEq = cmd1.Parameters.Add("@idEqup", MySqlDbType.Int32);
                                idEq.Direction = ParameterDirection.Input;
                                idEq.Value = 1;

                                cmd1.ExecuteNonQuery();
                            }
                            else if (checkedListBoxBooking.CheckedItems[i].ToString() == equipment[1])
                            {
                                MySqlCommand cmd2 = new MySqlCommand("call addEquipBook(@idEqup, @idBook);", cn);

                                MySqlParameter id = new MySqlParameter();
                                id = cmd2.Parameters.Add("@idBook", MySqlDbType.Int32);
                                id.Direction = ParameterDirection.Input;
                                id.Value = bookId;

                                MySqlParameter idEq = new MySqlParameter();
                                idEq = cmd2.Parameters.Add("@idEqup", MySqlDbType.Int32);
                                idEq.Direction = ParameterDirection.Input;
                                idEq.Value = 2;

                                cmd2.ExecuteNonQuery();
                            }
                            else if (checkedListBoxBooking.CheckedItems[i].ToString() == equipment[2])
                            {
                                MySqlCommand cmd3 = new MySqlCommand("call addEquipBook(@idEqup, @idBook);", cn);

                                MySqlParameter id = new MySqlParameter();
                                id = cmd3.Parameters.Add("@idBook", MySqlDbType.Int32);
                                id.Direction = ParameterDirection.Input;
                                id.Value = bookId;

                                MySqlParameter idEq = new MySqlParameter();
                                idEq = cmd3.Parameters.Add("@idEqup", MySqlDbType.Int32);
                                idEq.Direction = ParameterDirection.Input;
                                idEq.Value = 3;

                                cmd3.ExecuteNonQuery();
                            }
                            else if (checkedListBoxBooking.CheckedItems[i].ToString() == equipment[3])
                            {
                                MySqlCommand cmd4 = new MySqlCommand("call addEquipBook(@idEqup, @idBook);", cn);

                                MySqlParameter id = new MySqlParameter();
                                id = cmd4.Parameters.Add("@idBook", MySqlDbType.Int32);
                                id.Direction = ParameterDirection.Input;
                                id.Value = bookId;

                                MySqlParameter idEq = new MySqlParameter();
                                idEq = cmd4.Parameters.Add("@idEqup", MySqlDbType.Int32);
                                idEq.Direction = ParameterDirection.Input;
                                idEq.Value = 4;

                                cmd4.ExecuteNonQuery();
                            }
                        }
                    }
                    showUserBooks();
                    if (comboBox1.Items.Count > 0)
                    {
                        comboBox1.SelectedItem = comboBox1.Items[0];
                        comboBox1.Enabled = true;
                    }
                    textBoxRoomIdBooking.Clear();
                    textBoxTimeEndBooking.Clear();
                    textBoxTimeStartBooking.Clear();
                    for (int i = 0; i < checkedListBoxBooking.Items.Count; i++)
                    {
                        checkedListBoxBooking.SetItemCheckState(i, CheckState.Unchecked);
                    }
                }
                else
                {
                    MessageBox.Show("Время окончания стоит раньше времени начала бронирования", "Ошибка в данных", MessageBoxButtons.OK);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Время введено неверно", "Ошибка в данных", MessageBoxButtons.OK);
            }
        }

        private void buttonFindCatalog_Click(object sender, EventArgs e)
        {
            dataSetCatalog.Clear();
            try
            {
                if (TimeSpan.Parse(textBoxTimeStartCatalog.Text + ":00") < TimeSpan.Parse(textBoxTimeEndCatalog.Text + ":00"))
                {
                    if (checkedListBoxTechCatalog.CheckedItems.Count == 0)
                    {
                        try
                        {
                            MySqlCommand cmd = new MySqlCommand("call searchRoomWithoutEquip(@date, @startTime, @endTime, @roomType);", cn);

                            MySqlParameter date = new MySqlParameter();
                            date = cmd.Parameters.Add("@date", MySqlDbType.Date);
                            date.Direction = ParameterDirection.Input;
                            date.Value = monthCalendarBooking.SelectionRange.Start;

                            MySqlParameter startTime = new MySqlParameter();
                            startTime = cmd.Parameters.Add("@startTime", MySqlDbType.Time);
                            startTime.Direction = ParameterDirection.Input;

                            string time = textBoxTimeStartCatalog.Text + ":00";

                            startTime.Value = TimeSpan.Parse(time);

                            MySqlParameter endtime = new MySqlParameter();
                            endtime = cmd.Parameters.Add("@endtime", MySqlDbType.Time);
                            endtime.Direction = ParameterDirection.Input;
                            time = textBoxTimeEndCatalog.Text + ":00";
                            endtime.Value = TimeSpan.Parse(time);

                            MySqlParameter roomType = new MySqlParameter();
                            roomType = cmd.Parameters.Add("@roomType", MySqlDbType.VarChar);
                            roomType.Direction = ParameterDirection.Input;
                            roomType.Value = comboBoxType.SelectedItem;

                            cmd.ExecuteNonQuery();

                            MySqlDataAdapter dAdapter = new MySqlDataAdapter();
                            dAdapter.SelectCommand = cmd;
                            dAdapter.Fill(dataSetCatalog);
                            dataGridViewCatalog.DataSource = dataSetCatalog.Tables[0];

                        }
                        catch (MySqlException)
                        {
                            MessageBox.Show("Данные введены неверно", "Ошибка в данных", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        int i;
                        int[] equip = new int[4] { 0, 0, 0, 0 };
                        for (i = 0; i <= (checkedListBoxTechCatalog.Items.Count - 1); i++)
                        {
                            if (checkedListBoxTechCatalog.GetItemChecked(i))
                            {
                                equip[i] = 1;
                            }
                        }

                        MySqlCommand cmd = new MySqlCommand("call searchAvaliableRoom(@date, @startTime, @endTime, @roomType, @micro, @proj, @pc, @ib);", cn);

                        MySqlParameter date = new MySqlParameter();
                        date = cmd.Parameters.Add("@date", MySqlDbType.Date);
                        date.Direction = ParameterDirection.Input;
                        date.Value = monthCalendarBooking.SelectionRange.Start;

                        MySqlParameter startTime = new MySqlParameter();
                        startTime = cmd.Parameters.Add("@startTime", MySqlDbType.Time);
                        startTime.Direction = ParameterDirection.Input;

                        string time = textBoxTimeStartCatalog.Text + ":00";

                        startTime.Value = TimeSpan.Parse(time);

                        MySqlParameter endtime = new MySqlParameter();
                        endtime = cmd.Parameters.Add("@endtime", MySqlDbType.Time);
                        endtime.Direction = ParameterDirection.Input;
                        time = textBoxTimeEndCatalog.Text + ":00";
                        endtime.Value = TimeSpan.Parse(time);

                        MySqlParameter roomType = new MySqlParameter();
                        roomType = cmd.Parameters.Add("@roomType", MySqlDbType.VarChar);
                        roomType.Direction = ParameterDirection.Input;
                        roomType.Value = comboBoxType.SelectedItem;

                        MySqlParameter micro = new MySqlParameter();
                        micro = cmd.Parameters.Add("@micro", MySqlDbType.Bit);
                        micro.Direction = ParameterDirection.Input;
                        micro.Value = equip[0];

                        MySqlParameter proj = new MySqlParameter();
                        proj = cmd.Parameters.Add("@proj", MySqlDbType.Bit);
                        proj.Direction = ParameterDirection.Input;
                        proj.Value = equip[1];

                        MySqlParameter pc = new MySqlParameter();
                        pc = cmd.Parameters.Add("@pc", MySqlDbType.Bit);
                        pc.Direction = ParameterDirection.Input;
                        pc.Value = equip[2];

                        MySqlParameter ib = new MySqlParameter();
                        ib = cmd.Parameters.Add("@ib", MySqlDbType.Bit);
                        ib.Direction = ParameterDirection.Input;
                        ib.Value = equip[3];

                        int rows = cmd.ExecuteNonQuery();

                        MySqlDataAdapter dAdapter = new MySqlDataAdapter();
                        dAdapter.SelectCommand = cmd;
                        dAdapter.Fill(dataSetCatalog);
                        dataGridViewCatalog.DataSource = dataSetCatalog.Tables[0];
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString(), "Ошибка в данных", MessageBoxButtons.OK);

            }
        }

        private void checkedListBoxBooking_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            isComboboxSelected = true;
        }

        private void dataGridViewBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkedListBoxTechCatalog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonBookingCatalog_Click(object sender, EventArgs e)
        {
            if ((dataSetCatalog.Tables[0].Rows != null) || (textBoxRoomNumberCatalog.Text != ""))
            {
                foreach (DataRow row in dataSetCatalog.Tables[0].Rows)
                {
                    if (textBoxRoomNumberCatalog.Text == row[0].ToString())
                    {
                        try
                        {
                            if (TimeSpan.Parse(textBoxTimeStartCatalog.Text + ":00") < TimeSpan.Parse(textBoxTimeEndCatalog.Text + ":00"))
                            {
                                try
                                {
                                    MySqlCommand cmd = new MySqlCommand("call addBook(@Uid, @RoomId, @date, @sttime, @endtime, @purpose, @isEquip);", cn);

                                    MySqlParameter usid = new MySqlParameter();
                                    usid = cmd.Parameters.Add("@Uid", MySqlDbType.Int32);
                                    usid.Direction = ParameterDirection.Input;
                                    usid.Value = Uid;

                                    MySqlParameter rid = new MySqlParameter();
                                    rid = cmd.Parameters.Add("@RoomId", MySqlDbType.Int32);
                                    rid.Direction = ParameterDirection.Input;
                                    rid.Value = textBoxRoomNumberCatalog.Text;

                                    MySqlParameter date = new MySqlParameter();
                                    date = cmd.Parameters.Add("@Date", MySqlDbType.Date);
                                    date.Direction = ParameterDirection.Input;
                                    date.Value = dateTimePickerBookingCatalog.Value;

                                    MySqlParameter sttime = new MySqlParameter();
                                    sttime = cmd.Parameters.Add("@sttime", MySqlDbType.Time);
                                    sttime.Direction = ParameterDirection.Input;
                                    string time = textBoxTimeStartCatalog.Text + ":00";

                                    sttime.Value = TimeSpan.Parse(time);

                                    MySqlParameter endtime = new MySqlParameter();
                                    endtime = cmd.Parameters.Add("@endtime", MySqlDbType.Time);
                                    endtime.Direction = ParameterDirection.Input;
                                    time = textBoxTimeEndCatalog.Text + ":00";
                                    endtime.Value = TimeSpan.Parse(time);

                                    MySqlParameter purpose = new MySqlParameter();
                                    purpose = cmd.Parameters.Add("@purpose", MySqlDbType.VarChar);
                                    purpose.Direction = ParameterDirection.Input;
                                    purpose.Value = richTextBox1.Text;

                                    MySqlParameter isEquip = new MySqlParameter();
                                    isEquip = cmd.Parameters.Add("@isEquip", MySqlDbType.Int16);
                                    isEquip.Direction = ParameterDirection.Input;

                                    if (checkedListBoxTechCatalog.CheckedItems.Count > 0)
                                    {
                                        isEquip.Value = 1;
                                    }
                                    else
                                    {
                                        isEquip.Value = 0;
                                    }

                                    int rows = cmd.ExecuteNonQuery();
                                    if (rows == 0)
                                    {
                                        MessageBox.Show("Данные введены неверно", "Ошибка в данных", MessageBoxButtons.OK);
                                    }
                                }
                                catch (MySqlException)
                                {
                                    MessageBox.Show("Данные введены неверно", "Ошибка в данных", MessageBoxButtons.OK);
                                }

                                string sql = "select max(id) from booking";

                                MySqlCommand command = new MySqlCommand(sql, cn);
                                int bookId = Convert.ToInt32(command.ExecuteScalar().ToString());

                                if (checkedListBoxTechCatalog.CheckedItems.Count > 0)
                                {
                                    for (int i = 0; i < checkedListBoxTechCatalog.CheckedItems.Count; i++)
                                    {
                                        if (checkedListBoxTechCatalog.CheckedItems[i].ToString() == equipment[0])
                                        {
                                            MySqlCommand cmd1 = new MySqlCommand("call addEquipBook(@idEqup, @idBook);", cn);

                                            MySqlParameter id = new MySqlParameter();
                                            id = cmd1.Parameters.Add("@idBook", MySqlDbType.Int32);
                                            id.Direction = ParameterDirection.Input;
                                            id.Value = bookId;

                                            MySqlParameter idEq = new MySqlParameter();
                                            idEq = cmd1.Parameters.Add("@idEqup", MySqlDbType.Int32);
                                            idEq.Direction = ParameterDirection.Input;
                                            idEq.Value = 1;

                                            cmd1.ExecuteNonQuery();
                                        }
                                        else if (checkedListBoxTechCatalog.CheckedItems[i].ToString() == equipment[1])
                                        {
                                            MySqlCommand cmd2 = new MySqlCommand("call addEquipBook(@idEqup, @idBook);", cn);

                                            MySqlParameter id = new MySqlParameter();
                                            id = cmd2.Parameters.Add("@idBook", MySqlDbType.Int32);
                                            id.Direction = ParameterDirection.Input;
                                            id.Value = bookId;

                                            MySqlParameter idEq = new MySqlParameter();
                                            idEq = cmd2.Parameters.Add("@idEqup", MySqlDbType.Int32);
                                            idEq.Direction = ParameterDirection.Input;
                                            idEq.Value = 2;

                                            cmd2.ExecuteNonQuery();
                                        }
                                        else if (checkedListBoxTechCatalog.CheckedItems[i].ToString() == equipment[2])
                                        {
                                            MySqlCommand cmd3 = new MySqlCommand("call addEquipBook(@idEqup, @idBook);", cn);

                                            MySqlParameter id = new MySqlParameter();
                                            id = cmd3.Parameters.Add("@idBook", MySqlDbType.Int32);
                                            id.Direction = ParameterDirection.Input;
                                            id.Value = bookId;

                                            MySqlParameter idEq = new MySqlParameter();
                                            idEq = cmd3.Parameters.Add("@idEqup", MySqlDbType.Int32);
                                            idEq.Direction = ParameterDirection.Input;
                                            idEq.Value = 3;

                                            cmd3.ExecuteNonQuery();
                                        }
                                        else if (checkedListBoxTechCatalog.CheckedItems[i].ToString() == equipment[3])
                                        {
                                            MySqlCommand cmd4 = new MySqlCommand("call addEquipBook(@idEqup, @idBook);", cn);

                                            MySqlParameter id = new MySqlParameter();
                                            id = cmd4.Parameters.Add("@idBook", MySqlDbType.Int32);
                                            id.Direction = ParameterDirection.Input;
                                            id.Value = bookId;

                                            MySqlParameter idEq = new MySqlParameter();
                                            idEq = cmd4.Parameters.Add("@idEqup", MySqlDbType.Int32);
                                            idEq.Direction = ParameterDirection.Input;
                                            idEq.Value = 4;

                                            cmd4.ExecuteNonQuery();
                                        }
                                    }
                                }
                                showUserBooks();
                                if (comboBox1.Items.Count > 0)
                                {
                                    comboBox1.SelectedItem = comboBox1.Items[0];
                                    comboBox1.Enabled = true;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Время окончания стоит раньше времени начала бронирования", "Ошибка в данных", MessageBoxButtons.OK);
                            }
                        }
                        catch (FormatException err)
                        {
                            MessageBox.Show("Время введено неверно" + err, "Ошибка в данных", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }
    }
}
