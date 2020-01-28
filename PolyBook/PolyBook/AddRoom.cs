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
    public partial class AddRoom : Form
    {
        private int Uid;
        private String strConn;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string oldPassword;
        private String[] equipment;

        public AddRoom(int id)
        {
            InitializeComponent();
            Uid = id;

            server = "localhost";
            database = "database";
            uid = "root";
            password = "йцукен";
            strConn = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            cn.ConnectionString = strConn;
            equipment = new String[4];
        }

        private void fillEquipment()
        {
            equipment[0] = "Микрофон";
            equipment[1] = "Проектор";
            equipment[2] = "Персональный компьютер";
            equipment[3] = "Интерактивная доска";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("call addRoom(@id, @roomTypeId, @capacity, @isTechEquip, @techEquip);", cn);

                MySqlParameter id = new MySqlParameter();
                id = cmd.Parameters.Add("@id", MySqlDbType.VarChar);
                id.Direction = ParameterDirection.Input;
                id.Value = textBoxId.Text;

                int id_ = Convert.ToInt32(textBoxId.Text);

                int roomTypeId_ = 0;

                if (comboBoxType.SelectedItem.ToString() == "Лекционная")
                {
                    roomTypeId_ = 1;
                }
                else if (comboBoxType.SelectedItem.ToString() == "Учебная")
                {
                    roomTypeId_ = 2;
                }
                else
                {
                    roomTypeId_ = 3;
                }

                MySqlParameter roomTypeId = new MySqlParameter();
                roomTypeId = cmd.Parameters.Add("@roomTypeId", MySqlDbType.VarChar);
                roomTypeId.Direction = ParameterDirection.Input;
                roomTypeId.Value = roomTypeId_;

                MySqlParameter capacity = new MySqlParameter();
                capacity = cmd.Parameters.Add("@capacity", MySqlDbType.VarChar);
                capacity.Direction = ParameterDirection.Input;
                capacity.Value = Convert.ToInt32(textBoxCapacity.Text);

                int isTechEquip_ = 0;

                if (checkedListBoxBooking.CheckedItems.Count > 0)
                {
                    isTechEquip_ = 1;
                }

                MySqlParameter isTechEquip = new MySqlParameter();
                isTechEquip = cmd.Parameters.Add("@isTechEquip", MySqlDbType.VarChar);
                isTechEquip.Direction = ParameterDirection.Input;
                isTechEquip.Value = isTechEquip_;

                MySqlParameter techEquip = new MySqlParameter();
                techEquip = cmd.Parameters.Add("@techEquip", MySqlDbType.VarChar);
                techEquip.Direction = ParameterDirection.Input;
                techEquip.Value = "";

                try
                {
                    var result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка в данных" + ex, "Ошибка в данных", MessageBoxButtons.OK);
                }


                if (checkedListBoxBooking.CheckedItems.Count > 0)
                {
                    for (int i = 0; i < checkedListBoxBooking.CheckedItems.Count; i++)
                    {
                        if (checkedListBoxBooking.CheckedItems[i].ToString() == equipment[0])
                        {
                            MySqlCommand cmd1 = new MySqlCommand("call addEquipRoom(@idEqup, @idRoom);", cn);

                            MySqlParameter id1 = new MySqlParameter();
                            id1 = cmd1.Parameters.Add("@idRoom", MySqlDbType.Int32);
                            id1.Direction = ParameterDirection.Input;
                            id1.Value = id_;

                            MySqlParameter idEq = new MySqlParameter();
                            idEq = cmd1.Parameters.Add("@idEqup", MySqlDbType.Int32);
                            idEq.Direction = ParameterDirection.Input;
                            idEq.Value = 1;

                            cmd1.ExecuteNonQuery();

                        }
                        else if (checkedListBoxBooking.CheckedItems[i].ToString() == equipment[1])
                        {
                            MySqlCommand cmd2 = new MySqlCommand("call addEquipRoom(@idEqup, @idRoom);", cn);

                            MySqlParameter id1 = new MySqlParameter();
                            id1 = cmd2.Parameters.Add("@idRoom", MySqlDbType.Int32);
                            id1.Direction = ParameterDirection.Input;
                            id1.Value = id_;

                            MySqlParameter idEq = new MySqlParameter();
                            idEq = cmd2.Parameters.Add("@idEqup", MySqlDbType.Int32);
                            idEq.Direction = ParameterDirection.Input;
                            idEq.Value = 2;

                            cmd2.ExecuteNonQuery();
                        }
                        else if (checkedListBoxBooking.CheckedItems[i].ToString() == equipment[2])
                        {
                            MySqlCommand cmd3 = new MySqlCommand("call addEquipRoom(@idEqup, @idRoom);", cn);

                            MySqlParameter id1 = new MySqlParameter();
                            id1 = cmd3.Parameters.Add("@idRoom", MySqlDbType.Int32);
                            id1.Direction = ParameterDirection.Input;
                            id1.Value = id_;

                            MySqlParameter idEq = new MySqlParameter();
                            idEq = cmd3.Parameters.Add("@idEqup", MySqlDbType.Int32);
                            idEq.Direction = ParameterDirection.Input;
                            idEq.Value = 3;

                            cmd3.ExecuteNonQuery();
                        }
                        else if (checkedListBoxBooking.CheckedItems[i].ToString() == equipment[3])
                        {
                            MySqlCommand cmd4 = new MySqlCommand("call addEquipRoom(@idEqup, @idRoom);", cn);

                            MySqlParameter id1 = new MySqlParameter();
                            id1 = cmd4.Parameters.Add("@idRoom", MySqlDbType.Int32);
                            id1.Direction = ParameterDirection.Input;
                            id1.Value = id_;

                            MySqlParameter idEq = new MySqlParameter();
                            idEq = cmd4.Parameters.Add("@idEqup", MySqlDbType.Int32);
                            idEq.Direction = ParameterDirection.Input;
                            idEq.Value = 4;

                            cmd4.ExecuteNonQuery();
                        }
                    }

                }
                this.Close();
                AdminPage admPage = new AdminPage(Uid);
                admPage.tabControl1.SelectedIndex = 2;
                admPage.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Данные введены неверно или данная аудитория уже существует.", "Ошибка в данных", MessageBoxButtons.OK);
            }
        }

        private void fillRoomTypes()
        {
            comboBoxType.Items.Add("Лекционная");
            comboBoxType.Items.Add("Учебная");
            comboBoxType.Items.Add("Лаборатория");
            comboBoxType.SelectedIndex = 0;

        }

        private void AddRoom_Load(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection failed!", "Connection", MessageBoxButtons.OK);
            }
            fillRoomTypes();
            fillEquipment();
        }
    }
}
