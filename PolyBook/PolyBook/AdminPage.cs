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
            fillBooking();
            fillComboBoxes();


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
    }
}
