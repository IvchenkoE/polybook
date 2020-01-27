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
    public partial class AddAnyUser : Form
    {
        private int Uid;
        private String strConn;
        private string server;
        private string database;
        private string uid;
        private string password;
        public AddAnyUser(int id)
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

        private void AddAnyUser_Load(object sender, EventArgs e)
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

        private void buttonSave_Click(object sender, EventArgs e)
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

            MySqlCommand cmd = new MySqlCommand("call addUser(@email, @password, @fn, @ln, @fthn, @pnum, @isAdmin);", cn);

            MySqlParameter email = new MySqlParameter();
            email = cmd.Parameters.Add("@email", MySqlDbType.VarChar);
            email.Direction = ParameterDirection.Input;
            email.Value = textBoxEmail.Text;

            MySqlParameter passw = new MySqlParameter();
            passw = cmd.Parameters.Add("@password", MySqlDbType.VarChar);
            passw.Direction = ParameterDirection.Input;
            passw.Value = textBoxPassword.Text;

            MySqlParameter firstN = new MySqlParameter();
            firstN = cmd.Parameters.Add("@fn", MySqlDbType.VarChar);
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

            int isAdmin = 0;

            if (checkBox2.Checked)
            {
                isAdmin = 1;
            }

            MySqlParameter isAdm = new MySqlParameter();
            isAdm = cmd.Parameters.Add("@isAdmin", MySqlDbType.VarChar);
            isAdm.Direction = ParameterDirection.Input;
            isAdm.Value = isAdmin;

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
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте правильность введенных данных" + ex, "Ошибка в данных", MessageBoxButtons.OK);
            }

            AdminPage admPage = new AdminPage(Uid);
            admPage.tabControl1.SelectedIndex = 1;
            admPage.Show();
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
