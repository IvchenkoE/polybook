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
    public partial class SignUp : Form
    {
        private String strConn;
        private string server;
        private string database;
        private string uid;
        private string password;

        public SignUp()
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

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("call signUp(@email, @password);", cn);

            MySqlParameter email = new MySqlParameter();
            email = cmd.Parameters.Add("@email", MySqlDbType.VarChar);
            email.Direction = ParameterDirection.Input;
            email.Value = textBoxEmail.Text;

            MySqlParameter pw = new MySqlParameter();
            pw = cmd.Parameters.Add("@password", MySqlDbType.VarChar);
            pw.Direction = ParameterDirection.Input;
            pw.Value = textBoxPassword.Text;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода данных!", "Ошибка регистрации", MessageBoxButtons.OK);
            }
            this.Close();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection failed!!", "Connection", MessageBoxButtons.OK);
            }
        }
    }
}
