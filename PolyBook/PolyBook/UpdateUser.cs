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
    public partial class UpdateUser : Form
    {
        private int Uid;
        private String strConn;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string oldPassword;

        public UpdateUser(int id)
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
        }

        

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
            updateUser();
            updateUserPassword();
            Form userPage = new Form1(Uid);
            userPage.Show();
            this.Close();
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection failed!!", "Connection", MessageBoxButtons.OK);
            }
            getUserData();
            getUserPassword();
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
                textBoxName.Text = result["firstname"].ToString();
                textBoxLastName.Text = result["lastname"].ToString();
                textBoxFatherName.Text = result["fathername"].ToString();
                textBoxEmail.Text = result["email"].ToString();
                textBoxCallNum.Text = result["phonenumber"].ToString();
            }
            
            result.Close();
        }

        private void getUserPassword()
        {
            string sql = "SELECT password FROM users WHERE id = " + Uid;
            // объект для выполнения SQL-запроса
            MySqlCommand command = new MySqlCommand(sql, cn);
            // выполняем запрос и получаем ответ
            textBoxPassword.Text = command.ExecuteScalar().ToString();
            oldPassword = textBoxPassword.Text;
        }

        private void updateUser()
        {
            MySqlCommand cmd = new MySqlCommand("call updateUser(@email, @frstn, @ln, @fthn, @pnum);", cn);

            MySqlParameter email = new MySqlParameter();
            email = cmd.Parameters.Add("@email", MySqlDbType.VarChar);
            email.Direction = ParameterDirection.Input;
            email.Value = textBoxEmail.Text;

            MySqlParameter firstN = new MySqlParameter();
            firstN = cmd.Parameters.Add("@frstn", MySqlDbType.VarChar);
            firstN.Direction = ParameterDirection.Input;
            firstN.Value = textBoxName.Text;

            MySqlParameter ln = new MySqlParameter();
            ln = cmd.Parameters.Add("@ln", MySqlDbType.VarChar);
            ln.Direction = ParameterDirection.Input;
            ln.Value = textBoxLastName.Text;

            MySqlParameter fatN = new MySqlParameter();
            fatN = cmd.Parameters.Add("@fthn", MySqlDbType.VarChar);
            fatN.Direction = ParameterDirection.Input;
            fatN.Value = textBoxFatherName.Text;

            MySqlParameter pN = new MySqlParameter();
            pN = cmd.Parameters.Add("@pnum", MySqlDbType.VarChar);
            pN.Direction = ParameterDirection.Input;
            pN.Value = textBoxCallNum.Text;

            try
            {
                var result = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Данные не были обновлены", "Редактирование данных", MessageBoxButtons.OK);
            }
        }

        private void updateUserPassword()
        {
            MySqlCommand cmd = new MySqlCommand("call changePassword(@email, @oldPas, @newPas);", cn);

            MySqlParameter email = new MySqlParameter();
            email = cmd.Parameters.Add("@email", MySqlDbType.VarChar);
            email.Direction = ParameterDirection.Input;
            email.Value = textBoxEmail.Text;

            MySqlParameter oldPas = new MySqlParameter();
            oldPas = cmd.Parameters.Add("@oldPas", MySqlDbType.VarChar);
            oldPas.Direction = ParameterDirection.Input;
            oldPas.Value = oldPassword;

            MySqlParameter newPas = new MySqlParameter();
            newPas = cmd.Parameters.Add("@newPas", MySqlDbType.VarChar);
            newPas.Direction = ParameterDirection.Input;
            newPas.Value = textBoxPassword.Text;

            try
            {
                var result = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Данные пароля не были обновлены", "Редактирование данных", MessageBoxButtons.OK);
            }
        }
    }
}
