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
            password = "йцукен";
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
            fillRooms();

        }

        private void fillRooms()
        {
            dataSetRooms.Clear();
            MySqlCommand cmd = new MySqlCommand("select catalog.id as 'Номер аудитории', catalog.capacity as 'Вместимость'," +
                " roomtype.type as 'Тип', catalog.isTechEquip as 'Тех.оборудование' FROM database.catalog" +
                " inner join roomtype on roomtype.id = catalog.roomTypeId;", cn);
            cmd.ExecuteNonQuery();

            MySqlDataAdapter dAdapter = new MySqlDataAdapter();

            dAdapter.SelectCommand = cmd;
            dAdapter.Fill(dataSetRooms);
            dataGridViewRooms.DataSource = dataSetRooms.Tables[0];
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

            checkBoxAllRooms.CheckState = CheckState.Checked;
            comboBoxTech.SelectedItem = comboBoxTech.Items[2];
        }

        private void comboBoxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
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

            checkBoxAllDate.CheckState = CheckState.Checked;
            comboBoxTech.SelectedItem = comboBoxTech.Items[2];
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
                    MessageBox.Show("Введите email пользователя, которого вы хотите удалить", "Ошибка", MessageBoxButtons.OK);
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
                        Form upd = new UpdateUserAdm(Uid, id);
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

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            Form addUser = new AddAnyUser(Uid);
            addUser.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form addRoom = new AddRoom(Uid);
            addRoom.Show();
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNumRoom.Text != "")
                {

                    MySqlCommand cmd = new MySqlCommand("call deleteRoom(@id);", cn);

                    MySqlParameter id = new MySqlParameter();
                    id = cmd.Parameters.Add("@id", MySqlDbType.Int32);
                    id.Direction = ParameterDirection.Input;
                    id.Value = Convert.ToInt32(textBoxNumRoom.Text);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows == 0)
                    {
                        MessageBox.Show("Не существует аудитории с введенным номером.", "Ошибка", MessageBoxButtons.OK);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Введите номер аудитории, которую вы хотите удалить", "Ошибка", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Данные введены неверно", "Ошибка в данных", MessageBoxButtons.OK);
            }
            
            fillRooms();
            textBoxNumRoom.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                int rid = Convert.ToInt32(textBoxNumRoom.Text);
                Form updateRoom = new UpdateRoom(Uid, rid);
                updateRoom.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Данные введены неверно", "Ошибка в данных", MessageBoxButtons.OK);
            }
        }
    }
    
}
