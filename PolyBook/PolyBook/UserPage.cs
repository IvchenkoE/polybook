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
    }
}
