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
    public partial class UpdateBooking : Form
    {
        private String strConn;
        private string server;
        private string database;
        private string uid;
        private string password;
        private int Bid;
        private int Uid;

        public UpdateBooking(int Bid_, int Uid_)
        {
            InitializeComponent();
            server = "localhost";
            database = "database";
            uid = "root";
            password = "root";
            strConn = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            cn.ConnectionString = strConn;
            Bid = Bid_;
            Uid = Uid_;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (TimeSpan.Parse(textBoxTimeStart.Text) >= TimeSpan.Parse(textBoxTimeEnd.Text))
                {
                    MessageBox.Show("Время начала не может быть позже времени окончания.", 
                        "Ошибка в данных.", MessageBoxButtons.OK);
                    return;
                }
                MySqlCommand cmd = new MySqlCommand("call updateBook(@id, @roomId, @date, @stTime, @endTime, @purpose);", cn);

                MySqlParameter id = new MySqlParameter();
                id = cmd.Parameters.Add("@id", MySqlDbType.Int32);
                id.Direction = ParameterDirection.Input;
                id.Value = Bid;

                MySqlParameter roomId = new MySqlParameter();
                roomId = cmd.Parameters.Add("@roomId", MySqlDbType.Int32);
                roomId.Direction = ParameterDirection.Input;
                roomId.Value = Convert.ToInt32(textBoxRoom.Text);

                MySqlParameter date = new MySqlParameter();
                date = cmd.Parameters.Add("@date", MySqlDbType.Date);
                date.Direction = ParameterDirection.Input;
                date.Value = dateTimePicker1.Value;

                MySqlParameter stTime = new MySqlParameter();
                stTime = cmd.Parameters.Add("@stTime", MySqlDbType.Time);
                stTime.Direction = ParameterDirection.Input;
                if (textBoxTimeEnd.Text.IndexOf(":") != textBoxTimeEnd.Text.LastIndexOf(":"))
                {
                    stTime.Value = TimeSpan.Parse(textBoxTimeStart.Text);
                }
                else
                {
                    stTime.Value = TimeSpan.Parse(textBoxTimeStart.Text + ":00");
                }

                MySqlParameter endTime = new MySqlParameter();
                endTime = cmd.Parameters.Add("@endTime", MySqlDbType.Time);
                endTime.Direction = ParameterDirection.Input;
                if (textBoxTimeEnd.Text.IndexOf(":") != textBoxTimeEnd.Text.LastIndexOf(":"))
                {
                    endTime.Value = TimeSpan.Parse(textBoxTimeEnd.Text);
                }
                else
                {
                    endTime.Value = TimeSpan.Parse(textBoxTimeEnd.Text + ":00");
                }

                MySqlParameter purpose = new MySqlParameter();
                purpose = cmd.Parameters.Add("@purpose", MySqlDbType.VarChar);
                purpose.Direction = ParameterDirection.Input;
                purpose.Value = richTextBoxPurpose.Text;

                try
                {
                    var result = cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка в формате введенных данных", "Ошибка в данных.", MessageBoxButtons.OK);
                    return;
                }

                Form adminPage = new AdminPage(Uid);
                adminPage.Show();
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Формат данных нарушен", "Ошибка в данных", MessageBoxButtons.OK);
            }


        }

        private void getBookingData()
        {
            MySqlCommand cmd = new MySqlCommand("call showBookingById(@str);", cn);

            MySqlParameter p = new MySqlParameter();
            p = cmd.Parameters.Add("@str", MySqlDbType.Int32);
            p.Direction = ParameterDirection.Input;
            p.Value = Bid;
            var result = cmd.ExecuteReader();
            while (result.Read())
            {
                textBoxTimeStart.Text = result["startTime"].ToString();
                textBoxTimeEnd.Text = result["endTime"].ToString();
                richTextBoxPurpose.Text = result["purpose"].ToString();
                textBoxRoom.Text = result["roomId"].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(result["date"].ToString());
            }

            result.Close();
        }

        private void UpdateBooking_Load(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection failed!!", "Connection", MessageBoxButtons.OK);
            }

            getBookingData();
        }
    }
}
