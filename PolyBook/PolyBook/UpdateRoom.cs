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
    public partial class UpdateRoom : Form
    {
        private String strConn;
        private string server;
        private string database;
        private string uid;
        private string password;
        private int rid;
        private int Uid;
        public UpdateRoom(int Uid_, int rid_)
        {
            InitializeComponent();

            server = "localhost";
            database = "database";
            uid = "root";
            password = "йцукен";
            strConn = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            cn.ConnectionString = strConn;
            rid = rid_;
            Uid = Uid_;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("call updateRoom(@id, @roomTypeId, @capacity);", cn);

                MySqlParameter id = new MySqlParameter();
                id = cmd.Parameters.Add("@id", MySqlDbType.Int32);
                id.Direction = ParameterDirection.Input;
                id.Value = rid;

                MySqlParameter roomTypeId = new MySqlParameter();
                roomTypeId = cmd.Parameters.Add("@roomTypeId", MySqlDbType.Int32);
                roomTypeId.Direction = ParameterDirection.Input;
                roomTypeId.Value = comboBoxType.SelectedIndex + 1;

                MySqlParameter capacity = new MySqlParameter();
                capacity = cmd.Parameters.Add("@capacity", MySqlDbType.Int32);
                capacity.Direction = ParameterDirection.Input;
                capacity.Value = Convert.ToInt32(textBoxCapacity.Text);

                try
                {
                    var result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Данные не были обновлены" + ex, "Редактирование данных", MessageBoxButtons.OK);
                }
                Form admPage = new AdminPage(Uid);
                admPage.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Данные введены неверно", "Редактирование данных", MessageBoxButtons.OK);
            }
        }

        private void UpdateRoom_Load(object sender, EventArgs e)
        {

            try
            {
                cn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection failed!!", "Connection", MessageBoxButtons.OK);
            }
            fillRoomData();
        }

        private void fillRoomData()
        {
            MySqlCommand cmd = new MySqlCommand("call showRoomData(@str);", cn);

            MySqlParameter p = new MySqlParameter();
            p = cmd.Parameters.Add("@str", MySqlDbType.Int32);
            p.Direction = ParameterDirection.Input;
            p.Value = rid;
            int type = 0;
            var result = cmd.ExecuteReader();
            while (result.Read())
            {
                type = Convert.ToInt32(result["roomTypeId"].ToString());
                textBoxCapacity.Text = result["capacity"].ToString();
            }
            TextBoxNum.Text = rid.ToString();

            result.Close();

            comboBoxType.Items.Add("Лекционная");
            comboBoxType.Items.Add("Учебная");
            comboBoxType.Items.Add("Лаборатория");
            comboBoxType.SelectedIndex = type - 1;

        }
    }
}
