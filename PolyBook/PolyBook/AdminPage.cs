using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace PolyBook
{
    public partial class AdminPage : Form
    {
        private String strConn;
        private string server;
        private string database;
        private string uid;
        private string password;
        private int Uid;

        public AdminPage(int id)
        {
            InitializeComponent();
            server = "localhost";
            database = "database";
            uid = "root";
            password = "root";
            strConn = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            cn.ConnectionString = strConn;
            Uid = id;
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection failed!!", "Connection", MessageBoxButtons.OK);
            }
            fillBooking();
            fillComboBoxes();
            showUsers();

        }

        private void fillBooking()
        {
            dataSetBooking.Clear();
            MySqlCommand cmd = new MySqlCommand("call showAllBooks();", cn);

            MySqlDataAdapter dAdapter = new MySqlDataAdapter();
            dAdapter.SelectCommand = cmd;
            dAdapter.Fill(dataSetBooking);
            dataGridViewBooking.DataSource = dataSetBooking.Tables[0];
        }

        private void dateTimePickerBooking_ValueChanged(object sender, EventArgs e)
        {
            comboBoxTech.SelectedItem = comboBoxTech.Items[2];
            checkBoxAllDate.CheckState = CheckState.Unchecked;
            checkBoxAllRooms.CheckState = CheckState.Checked;
            dataSetBooking.Clear();
            MySqlCommand cmd = new MySqlCommand("call showAllBooksWithDate(@date);", cn);

            MySqlParameter date = new MySqlParameter();
            date = cmd.Parameters.Add("@date", MySqlDbType.Date);
            date.Direction = ParameterDirection.Input;
            date.Value = dateTimePickerBooking.Value;

            MySqlDataAdapter dAdapter = new MySqlDataAdapter();
            dAdapter.SelectCommand = cmd;
            dAdapter.Fill(dataSetBooking);
            dataGridViewBooking.DataSource = dataSetBooking.Tables[0];

        }

        private void comboBoxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            comboBoxTech.SelectedItem = comboBoxTech.Items[2];
            checkBoxAllRooms.CheckState = CheckState.Unchecked;
            checkBoxAllDate.CheckState = CheckState.Checked;

            dataSetBooking.Clear();
            MySqlCommand cmd = new MySqlCommand("call showAllBooksWithRoom(@room);", cn);

            MySqlParameter room = new MySqlParameter();
            room = cmd.Parameters.Add("@room", MySqlDbType.Int32);
            room.Direction = ParameterDirection.Input;
            room.Value = Convert.ToInt32(comboBoxRoom.SelectedItem.ToString());

            MySqlDataAdapter dAdapter = new MySqlDataAdapter();
            dAdapter.SelectCommand = cmd;
            dAdapter.Fill(dataSetBooking);
            dataGridViewBooking.DataSource = dataSetBooking.Tables[0];

        }

        private void comboBoxTech_SelectedIndexChanged(object sender, EventArgs e)
        {

            checkBoxAllRooms.CheckState = CheckState.Checked;
            checkBoxAllDate.CheckState = CheckState.Checked;
            dataSetBooking.Clear();
           
            if (comboBoxTech.SelectedItem.ToString() == "С тех. оборудованием")
            {
                MySqlCommand cmd = new MySqlCommand("call showAllBooksWithTech(@isTech);", cn);
                MySqlParameter isTech = new MySqlParameter();
                isTech = cmd.Parameters.Add("@isTech", MySqlDbType.Int32);
                isTech.Direction = ParameterDirection.Input;

                isTech.Value = 1;

                MySqlDataAdapter dAdapter = new MySqlDataAdapter();
                dAdapter.SelectCommand = cmd;
                dAdapter.Fill(dataSetBooking);
                dataGridViewBooking.DataSource = dataSetBooking.Tables[0];
            }
            else if (comboBoxTech.SelectedItem.ToString() == "Без тех. оборудования")
            {
                MySqlCommand cmd = new MySqlCommand("call showAllBooksWithTech(@isTech);", cn);
                MySqlParameter isTech = new MySqlParameter();
                isTech = cmd.Parameters.Add("@isTech", MySqlDbType.Int32);
                isTech.Direction = ParameterDirection.Input;
                isTech.Value = 0;

                MySqlDataAdapter dAdapter = new MySqlDataAdapter();
                dAdapter.SelectCommand = cmd;
                dAdapter.Fill(dataSetBooking);
                dataGridViewBooking.DataSource = dataSetBooking.Tables[0];
            }
            else
            {
                fillBooking();
            }

        }

        private void fillComboBoxes()
        {
            MySqlCommand cmd = new MySqlCommand("select id from catalog", cn);

            var result = cmd.ExecuteReader();
            while (result.Read())
            {
                comboBoxRoom.Items.Add(result["id"]);
            }
            result.Close();

            comboBoxTech.Items.Add("С тех. оборудованием");
            comboBoxTech.Items.Add("Без тех. оборудования");
            comboBoxTech.Items.Add("Любое");
        }

        private void buttonUpdateBooking_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("call getbookingId(@date, @sttime, @endtime, @roomnum);", cn);

                MySqlParameter date = new MySqlParameter();
                date = cmd.Parameters.Add("@date", MySqlDbType.Date);
                date.Direction = ParameterDirection.Input;
                date.Value = dateTimePickerUpdateBooking.Value;

                MySqlParameter sttime = new MySqlParameter();
                sttime = cmd.Parameters.Add("@sttime", MySqlDbType.Time);
                sttime.Direction = ParameterDirection.Input;
                if (textBoxTimeStart.Text.IndexOf(":") != textBoxTimeStart.Text.LastIndexOf(":"))
                {
                    sttime.Value = TimeSpan.Parse(textBoxTimeStart.Text);
                }
                else
                {
                    sttime.Value = TimeSpan.Parse(textBoxTimeStart.Text + ":00");
                }

                MySqlParameter endtime = new MySqlParameter();
                endtime = cmd.Parameters.Add("@endtime", MySqlDbType.Time);
                endtime.Direction = ParameterDirection.Input;
                if (textBoxTimeEnd.Text.IndexOf(":") != textBoxTimeEnd.Text.LastIndexOf(":"))
                {
                    endtime.Value = TimeSpan.Parse(textBoxTimeEnd.Text);
                }
                else
                {
                    endtime.Value = TimeSpan.Parse(textBoxTimeEnd.Text + ":00");
                }
                MySqlParameter roomnum = new MySqlParameter();
                roomnum = cmd.Parameters.Add("@roomnum", MySqlDbType.Int32);
                roomnum.Direction = ParameterDirection.Input;
                roomnum.Value = Convert.ToInt32(textBoxRoomNum.Text);
                int idBooking = -1;
                try
                {
                    idBooking = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception)
                {
                    MessageBox.Show("Такого бронирования не существует.", "Ошибка в данных.", MessageBoxButtons.OK);
                    return;
                }
                if (idBooking > 0)
                {
                    Form updateBooking = new UpdateBooking(idBooking, Uid);
                    updateBooking.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Такого бронирования не существует.", "Ошибка в данных.", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Формат данных нарушен", "Ошибка в данных", MessageBoxButtons.OK);
            }
        }

        private void showUsers()
        {
            dataSetUsers.Clear();
            textBoxEmailUsers.Clear();

            MySqlCommand cmd = new MySqlCommand("select email as 'Почта', firstName as 'Имя', lastName as 'Фамилия', " +
                "fatherName as 'Отчество', phoneNumber as 'Номер телефона', isAdmin as 'Статус админа' from users;", cn);
            MySqlDataAdapter dAdapter = new MySqlDataAdapter();
            dAdapter.SelectCommand = cmd;
            dAdapter.Fill(dataSetUsers);
            dataGridViewUsers.DataSource = dataSetUsers.Tables[0];

        }


        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxEmailUsers.Text != "")
                {

                    MySqlCommand cmd = new MySqlCommand("call deleteUserByEmail(@email);", cn);

                    MySqlParameter email = new MySqlParameter();
                    email = cmd.Parameters.Add("@email", MySqlDbType.VarChar);
                    email.Direction = ParameterDirection.Input;
                    email.Value = textBoxEmailUsers.Text;

                    int rows = cmd.ExecuteNonQuery();
                    if (rows == 0)
                    {
                        MessageBox.Show("Не существует пользователя с таким email", "Ошибка", MessageBoxButtons.OK);
                    }
                    else
                    {
                        cmd.ExecuteNonQuery();
                        showUsers();
                        textBoxEmailUsers.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Введите email, который хотите удалить", "Ошибка", MessageBoxButtons.OK);
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Данные введены неверно", "Ошибка в данных", MessageBoxButtons.OK);
            }
        }

        private void buttonUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxEmailUsers.Text != "")
                {
                    string str = textBoxEmailUsers.Text;
                    str = "select id from users where email = '" + textBoxEmailUsers.Text + "'";

                    MySqlCommand cmd = new MySqlCommand(str, cn);

                    textBoxEmailUsers.Clear();
                    int id = 0;

                    var result = cmd.ExecuteReader();
                    while (result.Read())
                    {
                        id = Convert.ToInt32(result["id"].ToString());
                    }

                    result.Close();
                    showUsers();
                    if (id > 0)
                    {
                        Form upd = new UpdateUserAdm(id);
                        upd.Show();
                    }
                    else
                    {
                        MessageBox.Show("Не существует пользователя с таким email", "Ошибка", MessageBoxButtons.OK);
                    }

                    textBoxEmailUsers.Clear();
                }

                else
                {
                    MessageBox.Show("Введите email, который хотите изменить", "Ошибка", MessageBoxButtons.OK);
                    textBoxEmailUsers.Clear();
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("Данные введены неверно", "Ошибка в данных", MessageBoxButtons.OK);
                textBoxEmailUsers.Clear();
            }
        }

        private void checkBoxAllDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAllDate.CheckState == CheckState.Checked)
            {
                fillBooking();
            }
        }

        private void checkBoxAllRooms_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAllRooms.CheckState == CheckState.Checked)
            {
                fillBooking();
            }
        }

        private void buttonDeleteBooking_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("call getbookingId(@date, @sttime, @endtime, @roomnum);", cn);

                MySqlParameter date = new MySqlParameter();
                date = cmd.Parameters.Add("@date", MySqlDbType.Date);
                date.Direction = ParameterDirection.Input;
                date.Value = dateTimePickerUpdateBooking.Value;

                MySqlParameter sttime = new MySqlParameter();
                sttime = cmd.Parameters.Add("@sttime", MySqlDbType.Time);
                sttime.Direction = ParameterDirection.Input;
                if (textBoxTimeStart.Text.IndexOf(":") != textBoxTimeStart.Text.LastIndexOf(":"))
                {
                    sttime.Value = TimeSpan.Parse(textBoxTimeStart.Text);
                }
                else
                {
                    sttime.Value = TimeSpan.Parse(textBoxTimeStart.Text + ":00");
                }

                MySqlParameter endtime = new MySqlParameter();
                endtime = cmd.Parameters.Add("@endtime", MySqlDbType.Time);
                endtime.Direction = ParameterDirection.Input;
                if (textBoxTimeEnd.Text.IndexOf(":") != textBoxTimeEnd.Text.LastIndexOf(":"))
                {
                    endtime.Value = TimeSpan.Parse(textBoxTimeEnd.Text);
                }
                else
                {
                    endtime.Value = TimeSpan.Parse(textBoxTimeEnd.Text + ":00");
                }
                MySqlParameter roomnum = new MySqlParameter();
                roomnum = cmd.Parameters.Add("@roomnum", MySqlDbType.Int32);
                roomnum.Direction = ParameterDirection.Input;
                roomnum.Value = Convert.ToInt32(textBoxRoomNum.Text);
                int idBooking = -1;
                try
                {
                    idBooking = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception)
                {
                    MessageBox.Show("Такого бронирования не существует.", "Ошибка в данных.", MessageBoxButtons.OK);
                    return;
                }
                if (idBooking > 0)
                {
                    try
                    {
                        MySqlCommand cmd1 = new MySqlCommand("call deleteBook(@id);", cn);

                        MySqlParameter id = new MySqlParameter();
                        id = cmd1.Parameters.Add("@id", MySqlDbType.Int32);
                        id.Direction = ParameterDirection.Input;
                        id.Value = idBooking;

                        cmd1.ExecuteNonQuery();
                        fillBooking();
                        textBoxRoomNum.Clear();
                        textBoxTimeEnd.Clear();
                        textBoxTimeStart.Clear();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка удаления.", "Ошибка в данных.", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Такого бронирования не существует.", "Ошибка в данных.", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Формат данных нарушен", "Ошибка в данных", MessageBoxButtons.OK);
            }
        }
    }
}
