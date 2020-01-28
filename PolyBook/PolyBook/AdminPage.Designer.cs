namespace PolyBook
{
    partial class AdminPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonDeleteBooking = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTech = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxAllRooms = new System.Windows.Forms.CheckBox();
            this.buttonUpdateBooking = new System.Windows.Forms.Button();
            this.textBoxRoomNum = new System.Windows.Forms.TextBox();
            this.textBoxTimeEnd = new System.Windows.Forms.TextBox();
            this.textBoxTimeStart = new System.Windows.Forms.TextBox();
            this.textBoxDateBooking = new System.Windows.Forms.TextBox();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.checkBoxAllDate = new System.Windows.Forms.CheckBox();
            this.dateTimePickerBooking = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewBooking = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonUpdateUser = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmailUsers = new System.Windows.Forms.TextBox();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNumRoom = new System.Windows.Forms.TextBox();
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.dataSetUsers = new System.Data.DataSet();
            this.cn = new MySql.Data.MySqlClient.MySqlConnection();
            this.dataSetBooking = new System.Data.DataSet();
            this.dataSetRooms = new System.Data.DataSet();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(851, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MintCream;
            this.tabPage1.Controls.Add(this.buttonDeleteBooking);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.comboBoxTech);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.checkBoxAllRooms);
            this.tabPage1.Controls.Add(this.buttonUpdateBooking);
            this.tabPage1.Controls.Add(this.textBoxRoomNum);
            this.tabPage1.Controls.Add(this.textBoxTimeEnd);
            this.tabPage1.Controls.Add(this.textBoxTimeStart);
            this.tabPage1.Controls.Add(this.textBoxDateBooking);
            this.tabPage1.Controls.Add(this.comboBoxRoom);
            this.tabPage1.Controls.Add(this.checkBoxAllDate);
            this.tabPage1.Controls.Add(this.dateTimePickerBooking);
            this.tabPage1.Controls.Add(this.dataGridViewBooking);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(843, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Бронирования";
            // 
            // buttonDeleteBooking
            // 
            this.buttonDeleteBooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteBooking.Location = new System.Drawing.Point(470, 359);
            this.buttonDeleteBooking.Name = "buttonDeleteBooking";
            this.buttonDeleteBooking.Size = new System.Drawing.Size(210, 42);
            this.buttonDeleteBooking.TabIndex = 21;
            this.buttonDeleteBooking.Text = "Удалить бронирование";
            this.buttonDeleteBooking.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(665, 307);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "Номер аудитории";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(467, 307);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Время окончания";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(251, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Время начала";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Дата";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(560, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Выберете наличие тех. оборудования";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Выберете номер аудитории";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Выберете дату";
            // 
            // comboBoxTech
            // 
            this.comboBoxTech.FormattingEnabled = true;
            this.comboBoxTech.Location = new System.Drawing.Point(563, 74);
            this.comboBoxTech.Name = "comboBoxTech";
            this.comboBoxTech.Size = new System.Drawing.Size(222, 23);
            this.comboBoxTech.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.label3.Location = new System.Drawing.Point(47, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(471, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Используйте один из 3 фильтров для поиска нужного бронирования";
            // 
            // checkBoxAllRooms
            // 
            this.checkBoxAllRooms.AutoSize = true;
            this.checkBoxAllRooms.Location = new System.Drawing.Point(310, 104);
            this.checkBoxAllRooms.Name = "checkBoxAllRooms";
            this.checkBoxAllRooms.Size = new System.Drawing.Size(111, 21);
            this.checkBoxAllRooms.TabIndex = 11;
            this.checkBoxAllRooms.Text = "Все аудитории";
            this.checkBoxAllRooms.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateBooking
            // 
            this.buttonUpdateBooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdateBooking.Location = new System.Drawing.Point(161, 357);
            this.buttonUpdateBooking.Name = "buttonUpdateBooking";
            this.buttonUpdateBooking.Size = new System.Drawing.Size(210, 42);
            this.buttonUpdateBooking.TabIndex = 9;
            this.buttonUpdateBooking.Text = "Редактировать бронирование";
            this.buttonUpdateBooking.UseVisualStyleBackColor = true;
            this.buttonUpdateBooking.Click += new System.EventHandler(this.buttonUpdateBooking_Click);
            // 
            // textBoxRoomNum
            // 
            this.textBoxRoomNum.Location = new System.Drawing.Point(668, 327);
            this.textBoxRoomNum.Name = "textBoxRoomNum";
            this.textBoxRoomNum.Size = new System.Drawing.Size(117, 24);
            this.textBoxRoomNum.TabIndex = 8;
            // 
            // textBoxTimeEnd
            // 
            this.textBoxTimeEnd.Location = new System.Drawing.Point(470, 327);
            this.textBoxTimeEnd.Name = "textBoxTimeEnd";
            this.textBoxTimeEnd.Size = new System.Drawing.Size(117, 24);
            this.textBoxTimeEnd.TabIndex = 7;
            // 
            // textBoxTimeStart
            // 
            this.textBoxTimeStart.Location = new System.Drawing.Point(254, 327);
            this.textBoxTimeStart.Name = "textBoxTimeStart";
            this.textBoxTimeStart.Size = new System.Drawing.Size(117, 24);
            this.textBoxTimeStart.TabIndex = 6;
            // 
            // textBoxDateBooking
            // 
            this.textBoxDateBooking.Location = new System.Drawing.Point(51, 327);
            this.textBoxDateBooking.Name = "textBoxDateBooking";
            this.textBoxDateBooking.Size = new System.Drawing.Size(117, 24);
            this.textBoxDateBooking.TabIndex = 5;
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Location = new System.Drawing.Point(310, 74);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(172, 23);
            this.comboBoxRoom.TabIndex = 3;
            this.comboBoxRoom.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoom_SelectedIndexChanged);
            // 
            // checkBoxAllDate
            // 
            this.checkBoxAllDate.AutoSize = true;
            this.checkBoxAllDate.Location = new System.Drawing.Point(51, 104);
            this.checkBoxAllDate.Name = "checkBoxAllDate";
            this.checkBoxAllDate.Size = new System.Drawing.Size(81, 21);
            this.checkBoxAllDate.TabIndex = 2;
            this.checkBoxAllDate.Text = "Все Даты";
            this.checkBoxAllDate.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerBooking
            // 
            this.dateTimePickerBooking.Location = new System.Drawing.Point(51, 74);
            this.dateTimePickerBooking.Name = "dateTimePickerBooking";
            this.dateTimePickerBooking.Size = new System.Drawing.Size(171, 24);
            this.dateTimePickerBooking.TabIndex = 1;
            this.dateTimePickerBooking.ValueChanged += new System.EventHandler(this.dateTimePickerBooking_ValueChanged);
            // 
            // dataGridViewBooking
            // 
            this.dataGridViewBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBooking.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridViewBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooking.Location = new System.Drawing.Point(20, 131);
            this.dataGridViewBooking.Name = "dataGridViewBooking";
            this.dataGridViewBooking.ReadOnly = true;
            this.dataGridViewBooking.Size = new System.Drawing.Size(801, 173);
            this.dataGridViewBooking.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MintCream;
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.buttonDeleteUser);
            this.tabPage2.Controls.Add(this.buttonUpdateUser);
            this.tabPage2.Controls.Add(this.buttonAddUser);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBoxEmailUsers);
            this.tabPage2.Controls.Add(this.dataGridViewUsers);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(843, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Пользователи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.label2.Location = new System.Drawing.Point(15, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Все Пользователи:";
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteUser.Location = new System.Drawing.Point(316, 355);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(200, 45);
            this.buttonDeleteUser.TabIndex = 5;
            this.buttonDeleteUser.Text = "Удалить пользователя";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonUpdateUser
            // 
            this.buttonUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdateUser.Location = new System.Drawing.Point(80, 355);
            this.buttonUpdateUser.Name = "buttonUpdateUser";
            this.buttonUpdateUser.Size = new System.Drawing.Size(200, 45);
            this.buttonUpdateUser.TabIndex = 4;
            this.buttonUpdateUser.Text = "Редактировать пользователя";
            this.buttonUpdateUser.UseVisualStyleBackColor = true;
            this.buttonUpdateUser.Click += new System.EventHandler(this.buttonUpdateUser_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddUser.Location = new System.Drawing.Point(552, 355);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(200, 45);
            this.buttonAddUser.TabIndex = 3;
            this.buttonAddUser.Text = "Добавить пользователя";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Укажите почту для дальнейшей работы с пользователем";
            // 
            // textBoxEmailUsers
            // 
            this.textBoxEmailUsers.Location = new System.Drawing.Point(19, 315);
            this.textBoxEmailUsers.Name = "textBoxEmailUsers";
            this.textBoxEmailUsers.Size = new System.Drawing.Size(332, 24);
            this.textBoxEmailUsers.TabIndex = 1;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(19, 53);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.Size = new System.Drawing.Size(799, 230);
            this.dataGridViewUsers.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.MintCream;
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.textBoxNumRoom);
            this.tabPage3.Controls.Add(this.dataGridViewRooms);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(843, 423);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Аудитории";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.label5.Location = new System.Drawing.Point(17, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Все аудитории:";
            // 
            // button4
            // 
            this.button4.AccessibleDescription = "button4_Click";
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(313, 357);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 45);
            this.button4.TabIndex = 12;
            this.button4.Text = "Удалить аудиторию";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.AccessibleDescription = "button5_Click";
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(77, 357);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 45);
            this.button5.TabIndex = 11;
            this.button5.Text = "Редактировать аудиторию";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(549, 357);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 45);
            this.button6.TabIndex = 10;
            this.button6.Text = "Добавить аудиторию";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Введите номер аудитории:";
            // 
            // textBoxNumRoom
            // 
            this.textBoxNumRoom.Location = new System.Drawing.Point(21, 312);
            this.textBoxNumRoom.Name = "textBoxNumRoom";
            this.textBoxNumRoom.Size = new System.Drawing.Size(332, 24);
            this.textBoxNumRoom.TabIndex = 8;
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRooms.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRooms.Location = new System.Drawing.Point(21, 50);
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.ReadOnly = true;
            this.dataGridViewRooms.Size = new System.Drawing.Size(799, 229);
            this.dataGridViewRooms.TabIndex = 7;
            // 
            // dataSetUsers
            // 
            this.dataSetUsers.DataSetName = "NewDataSet";
            // 
            // dataSetBooking
            // 
            this.dataSetBooking.DataSetName = "NewDataSet";
            // 
            // dataSetRooms
            // 
            this.dataSetRooms.DataSetName = "NewDataSet";
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 451);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRooms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Data.DataSet dataSetUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonUpdateUser;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmailUsers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNumRoom;
        private System.Windows.Forms.DataGridView dataGridViewRooms;
        private MySql.Data.MySqlClient.MySqlConnection cn;
        private System.Windows.Forms.Button buttonDeleteBooking;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTech;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxAllRooms;
        private System.Windows.Forms.Button buttonUpdateBooking;
        private System.Windows.Forms.TextBox textBoxRoomNum;
        private System.Windows.Forms.TextBox textBoxTimeEnd;
        private System.Windows.Forms.TextBox textBoxTimeStart;
        private System.Windows.Forms.TextBox textBoxDateBooking;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.CheckBox checkBoxAllDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerBooking;
        private System.Windows.Forms.DataGridView dataGridViewBooking;
        private System.Data.DataSet dataSetBooking;
        protected internal System.Windows.Forms.TabControl tabControl1;
        internal System.Windows.Forms.TabPage tabPage2;
        private System.Data.DataSet dataSetRooms;
    }
}