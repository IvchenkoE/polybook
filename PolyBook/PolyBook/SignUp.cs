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
            password = "йцукен";
            strConn = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            cn.ConnectionString = strConn;
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string checkEmail = textBoxEmail.Text;
            string checkPassword = textBoxPassword.Text;
            if ((checkEmail.IndexOf("@") != checkEmail.LastIndexOf("@")) 
                || (checkEmail.IndexOf("@") == 0))
            {
                MessageBox.Show("Ваш почтовый адрес имеет неверный формат.", "Ошибка регистрации", MessageBoxButtons.OK);
                return;
            }
            if ((checkPassword.IndexOf(" ") >= 0) || (checkPassword == ""))
            {
                MessageBox.Show("Ваш пароль имеет неверный формат.", "Ошибка регистрации", MessageBoxButtons.OK);
                return;
            }
            if (!(checkEmail.EndsWith("@edu.spbstu.ru") || checkEmail.EndsWith("@ics2.ecd.spbstu.ru") || checkEmail.EndsWith("@dcn.icc.spbstu.ru")))
            {
                MessageBox.Show("Домен вашего почтового адреса не является доменом Университета. Для регистрации укашите почтовый адрес Университета.", 
                    "Ошибка регистрации", MessageBoxButtons.OK);
                return;
            }

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
                var result = cmd.ExecuteReader();
                while (result.Read())
                {
                    if (Convert.ToInt32(result["id_"].ToString()) == 0)
                    {
                        MessageBox.Show("Пользователь с данным почтовым адресом уже существует", "Ошибка в данных", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
            catch (Exception)
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
