using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolyBook
{
    public partial class Form1 : Form
    {
        private String strConn;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Form1()
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

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                MessageBox.Show("Connected");
            }
            catch (Exception)
            {
                MessageBox.Show("Connection failed!!", "Connection", MessageBoxButtons.OK);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
