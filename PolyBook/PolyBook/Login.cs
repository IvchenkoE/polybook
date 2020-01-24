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
using MySql.Data;


namespace PolyBook
{
    public partial class Login : Form
    {
        private int Uid;
        private String strConn;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Login()
        {
            InitializeComponent();
            server = "localhost";
            database = "database";
            uid = "root";
            password = "root";
            strConn = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            cn.ConnectionString = strConn;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        { 
            MySqlCommand cmd = new MySqlCommand("call login(@email, @password);", cn);
            
            MySqlParameter email = new MySqlParameter();
            email = cmd.Parameters.Add("@email", MySqlDbType.VarChar);
            email.Direction = ParameterDirection.Input;
            email.Value = textBoxEmail.Text;

            MySqlParameter pw = new MySqlParameter();
            pw = cmd.Parameters.Add("@password", MySqlDbType.VarChar);
            pw.Direction = ParameterDirection.Input;
            pw.Value = textBoxPassword.Text;

            
            Uid = -2;

            try
            {
                Uid = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неправильно введен email или пароль", "Ошибка входа", MessageBoxButtons.OK);
                Uid = -2;
                textBoxEmail.Clear();
                textBoxPassword.Clear();
            }

            if (Uid > 0)
            {
                string str = "SELECT isAdmin from Users where id = " + Uid;
                cmd = new MySqlCommand(str, cn);
                string isAdmin = cmd.ExecuteScalar().ToString();
                if (isAdmin == "true")
                {
                    //
                }
                else
                {
                    Form userPage = new Form1(Uid);
                    userPage.Show();
                    //this.Visible = false;
                }
            }

            textBoxEmail.Clear();
            textBoxPassword.Clear();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection failed!", "Connection", MessageBoxButtons.OK);
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            Form signUp = new SignUp();
            signUp.Show();
        }
    }
}
