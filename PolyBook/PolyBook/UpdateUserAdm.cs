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
    public partial class UpdateUserAdm : Form
    {
        private String strConn;
        private string server;
        private string database;
        private string uid;
        private string password;
        private int adminId;
        private int userId;

        public UpdateUserAdm(int Uid, int id)
        {
            InitializeComponent();
            adminId = Uid;
            userId = id;

            server = "localhost";
            database = "database";
            uid = "root";
            password = "йцукен";
            strConn = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            cn.ConnectionString = strConn;
        }

        private void UpdateUserAdm_Load(object sender, EventArgs e)
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
            
        }

        private void getUserData()
        {
            MySqlCommand cmd = new MySqlCommand("call showUserDataAdm(@str);", cn);

            MySqlParameter p = new MySqlParameter();
            p = cmd.Parameters.Add("@str", MySqlDbType.Int32);
            p.Direction = ParameterDirection.Input;
            p.Value = userId;
            

            var result = cmd.ExecuteReader();
            while (result.Read())
            {
                textBoxName.Text = result["firstname"].ToString();
                textBoxLastName.Text = result["lastname"].ToString();
                textBoxFatherName.Text = result["fathername"].ToString();
                textBoxEmail.Text = result["email"].ToString();
                textBoxCallNum.Text = result["phonenumber"].ToString();

                string s = result["isAdmin"].ToString();
                int isAdmin = Convert.ToInt32(s);
                
               
                if ( isAdmin != 0)
                {
                    textBoxPassword.Text = result["password"].ToString();
                }
                else 
                {
                    textBoxPassword.Text = "";
                }
                
                if (adminId != userId)
                {
                    textBoxPassword.Visible = false;
                    label5.Visible = false;
                }

            }
            result.Close();

            if (textBoxName.Text == "")
            {
                textBoxName.Text = "Не указано";
            }
            if (textBoxLastName.Text == "")
            {
                textBoxLastName.Text = "Не указано";
            }
            if (textBoxFatherName.Text == "")
            {
                textBoxFatherName.Text = "Не указано";
            }
            if (textBoxCallNum.Text == "")
            {
                textBoxCallNum.Text = "Не указано";
            }

            
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
                // MessageBox.Show("Данные обновлены", "Редактирование данных", MessageBoxButtons.OK);
            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.ToString(), "Редактирование данных", MessageBoxButtons.OK);
            }
            

        }

        private void updateUserPassword()
        {
           

            try
            {
                MySqlCommand cmd = new MySqlCommand("call changePasswordAdm(@email, @newPas);", cn);

                MySqlParameter email = new MySqlParameter();
                email = cmd.Parameters.Add("@email", MySqlDbType.VarChar);
                email.Direction = ParameterDirection.Input;
                email.Value = textBoxEmail.Text;

                MySqlParameter newPas = new MySqlParameter();
                newPas = cmd.Parameters.Add("@newPas", MySqlDbType.VarChar);
                newPas.Direction = ParameterDirection.Input;
                newPas.Value = textBoxPassword.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Данные пароля не были обновлены", "Редактирование данных", MessageBoxButtons.OK);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            updateUser();
            updateUserPassword();
            Form admPage = new AdminPage(adminId);
            admPage.Show();
            this.Close();
        }
    }
}

