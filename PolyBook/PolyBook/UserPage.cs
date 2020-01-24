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
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form upd = new UpdateUser(Uid);
            upd.Show();
            this.Close();
        }
    }
}
