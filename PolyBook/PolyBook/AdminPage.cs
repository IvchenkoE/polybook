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
            showUsers();
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
                    else {
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
                    str = "select id from users where email = '" + textBoxEmailUsers.Text +"'";

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
    }
}