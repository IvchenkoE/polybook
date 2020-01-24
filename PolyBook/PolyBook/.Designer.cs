namespace PolyBook
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cn = new MySql.Data.MySqlClient.MySqlConnection();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxRoomNumberCatalog = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonBookingCatalog = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonFindCatalog = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTimeStartCatalog = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTimeEndCatalog = new System.Windows.Forms.TextBox();
            this.dateTimePickerBookingCatalog = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBoxTechCatalog = new System.Windows.Forms.CheckedListBox();
            this.dataGridViewCatalog = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.monthCalendarBooking = new System.Windows.Forms.MonthCalendar();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonUpdateUser = new System.Windows.Forms.Button();
            this.label_call_number = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_fname = new System.Windows.Forms.Label();
            this.label_fam = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dataSetCatalog = new System.Data.DataSet();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalog)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCatalog)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(941, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MintCream;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.textBoxRoomNumberCatalog);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.buttonBookingCatalog);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.buttonFindCatalog);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.textBoxTimeStartCatalog);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBoxTimeEndCatalog);
            this.tabPage1.Controls.Add(this.dateTimePickerBookingCatalog);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.checkedListBoxTechCatalog);
            this.tabPage1.Controls.Add(this.dataGridViewCatalog);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBoxType);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(933, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Каталог";
            // 
            // textBoxRoomNumberCatalog
            // 
            this.textBoxRoomNumberCatalog.Location = new System.Drawing.Point(331, 371);
            this.textBoxRoomNumberCatalog.Name = "textBoxRoomNumberCatalog";
            this.textBoxRoomNumberCatalog.Size = new System.Drawing.Size(100, 24);
            this.textBoxRoomNumberCatalog.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.label10.Location = new System.Drawing.Point(30, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 22);
            this.label10.TabIndex = 19;
            this.label10.Text = "Фильтры поиска";
            // 
            // buttonBookingCatalog
            // 
            this.buttonBookingCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBookingCatalog.Location = new System.Drawing.Point(725, 349);
            this.buttonBookingCatalog.Name = "buttonBookingCatalog";
            this.buttonBookingCatalog.Size = new System.Drawing.Size(178, 43);
            this.buttonBookingCatalog.TabIndex = 18;
            this.buttonBookingCatalog.Text = "Забронировать";
            this.buttonBookingCatalog.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(364, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Введите номер аудитории из списка выше для бронирования";
            // 
            // buttonFindCatalog
            // 
            this.buttonFindCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFindCatalog.Location = new System.Drawing.Point(34, 349);
            this.buttonFindCatalog.Name = "buttonFindCatalog";
            this.buttonFindCatalog.Size = new System.Drawing.Size(240, 43);
            this.buttonFindCatalog.TabIndex = 15;
            this.buttonFindCatalog.Text = "Поиск";
            this.buttonFindCatalog.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(316, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "то  необходимо изменить настройки фильтров поиска";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(338, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Если необходимой аудитории нет в выведенном списке, ";
            // 
            // textBoxTimeStartCatalog
            // 
            this.textBoxTimeStartCatalog.Location = new System.Drawing.Point(34, 118);
            this.textBoxTimeStartCatalog.Name = "textBoxTimeStartCatalog";
            this.textBoxTimeStartCatalog.Size = new System.Drawing.Size(240, 24);
            this.textBoxTimeStartCatalog.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Время окончания бронирования";
            // 
            // textBoxTimeEndCatalog
            // 
            this.textBoxTimeEndCatalog.Location = new System.Drawing.Point(34, 165);
            this.textBoxTimeEndCatalog.Name = "textBoxTimeEndCatalog";
            this.textBoxTimeEndCatalog.Size = new System.Drawing.Size(240, 24);
            this.textBoxTimeEndCatalog.TabIndex = 10;
            // 
            // dateTimePickerBookingCatalog
            // 
            this.dateTimePickerBookingCatalog.Location = new System.Drawing.Point(34, 71);
            this.dateTimePickerBookingCatalog.Name = "dateTimePickerBookingCatalog";
            this.dateTimePickerBookingCatalog.Size = new System.Drawing.Size(240, 24);
            this.dateTimePickerBookingCatalog.TabIndex = 9;
            this.dateTimePickerBookingCatalog.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Время начала бронирования";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label4.Location = new System.Drawing.Point(31, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Выберете дату бронирования";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.label3.Location = new System.Drawing.Point(327, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Найденные результаты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label2.Location = new System.Drawing.Point(31, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Техническое оборудование в аудитории:";
            // 
            // checkedListBoxTechCatalog
            // 
            this.checkedListBoxTechCatalog.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.checkedListBoxTechCatalog.FormattingEnabled = true;
            this.checkedListBoxTechCatalog.Items.AddRange(new object[] {
            "Микрофон",
            "Проектор",
            "Персональный компьютер",
            "Интерактивная доска"});
            this.checkedListBoxTechCatalog.Location = new System.Drawing.Point(34, 258);
            this.checkedListBoxTechCatalog.Name = "checkedListBoxTechCatalog";
            this.checkedListBoxTechCatalog.Size = new System.Drawing.Size(240, 80);
            this.checkedListBoxTechCatalog.TabIndex = 3;
            // 
            // dataGridViewCatalog
            // 
            this.dataGridViewCatalog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCatalog.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridViewCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCatalog.Location = new System.Drawing.Point(331, 47);
            this.dataGridViewCatalog.Name = "dataGridViewCatalog";
            this.dataGridViewCatalog.Size = new System.Drawing.Size(572, 226);
            this.dataGridViewCatalog.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label1.Location = new System.Drawing.Point(31, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип Аудитории";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(34, 212);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(240, 23);
            this.comboBoxType.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MintCream;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.monthCalendarBooking);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.checkedListBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(933, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Бронирование";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(589, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 43);
            this.button1.TabIndex = 27;
            this.button1.Text = "Забронировать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(290, 269);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 24);
            this.textBox1.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(287, 249);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 17);
            this.label15.TabIndex = 25;
            this.label15.Text = "Введите номер аудитории";
            // 
            // monthCalendarBooking
            // 
            this.monthCalendarBooking.Location = new System.Drawing.Point(52, 131);
            this.monthCalendarBooking.Name = "monthCalendarBooking";
            this.monthCalendarBooking.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.label16.Location = new System.Drawing.Point(48, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(462, 22);
            this.label16.TabIndex = 23;
            this.label16.Text = "Для бронирования аудитории введите следующие данные:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(290, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(240, 24);
            this.textBox2.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(287, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(245, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Введите время окончания бронирования";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(290, 200);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(240, 24);
            this.textBox3.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(287, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(226, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "Введите время начала бронирования";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label13.Location = new System.Drawing.Point(49, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(180, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "Выберете дату бронирования";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label14.Location = new System.Drawing.Point(586, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(298, 17);
            this.label14.TabIndex = 16;
            this.label14.Text = "Выберете техническое оборудование в аудитории";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Микрофон",
            "Проектор",
            "Персональный компьютер",
            "Интерактивная доска"});
            this.checkedListBox1.Location = new System.Drawing.Point(589, 131);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(240, 80);
            this.checkedListBox1.TabIndex = 15;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.MintCream;
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(933, 422);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Мои Бронирования";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(706, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(66, 371);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(562, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(63, 351);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(347, 17);
            this.label18.TabIndex = 2;
            this.label18.Text = "Выберете порядковый номер бронирование для удаления";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.label17.Location = new System.Drawing.Point(62, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(170, 22);
            this.label17.TabIndex = 1;
            this.label17.Text = "Ваши бронирования:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(917, 257);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.MintCream;
            this.tabPage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage4.Controls.Add(this.buttonUpdateUser);
            this.tabPage4.Controls.Add(this.label_call_number);
            this.tabPage4.Controls.Add(this.label_email);
            this.tabPage4.Controls.Add(this.label29);
            this.tabPage4.Controls.Add(this.label31);
            this.tabPage4.Controls.Add(this.label25);
            this.tabPage4.Controls.Add(this.label_name);
            this.tabPage4.Controls.Add(this.label_fname);
            this.tabPage4.Controls.Add(this.label_fam);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(933, 422);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Моя Страница";
            // 
            // buttonUpdateUser
            // 
            this.buttonUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdateUser.Location = new System.Drawing.Point(369, 328);
            this.buttonUpdateUser.Name = "buttonUpdateUser";
            this.buttonUpdateUser.Size = new System.Drawing.Size(173, 42);
            this.buttonUpdateUser.TabIndex = 13;
            this.buttonUpdateUser.Text = "Редактировать";
            this.buttonUpdateUser.UseVisualStyleBackColor = true;
            this.buttonUpdateUser.Click += new System.EventHandler(this.button3_Click);
            // 
            // label_call_number
            // 
            this.label_call_number.AutoSize = true;
            this.label_call_number.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.label_call_number.Location = new System.Drawing.Point(487, 256);
            this.label_call_number.Name = "label_call_number";
            this.label_call_number.Size = new System.Drawing.Size(142, 22);
            this.label_call_number.TabIndex = 12;
            this.label_call_number.Text = "label_call_number";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.label_email.Location = new System.Drawing.Point(487, 221);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(92, 22);
            this.label_email.TabIndex = 10;
            this.label_email.Text = "label_email";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.label29.Location = new System.Drawing.Point(322, 256);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(136, 22);
            this.label29.TabIndex = 9;
            this.label29.Text = "Номер телефона";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.label31.Location = new System.Drawing.Point(322, 221);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(49, 22);
            this.label31.TabIndex = 7;
            this.label31.Text = "email";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.label25.Location = new System.Drawing.Point(322, 69);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(120, 22);
            this.label25.TabIndex = 6;
            this.label25.Text = "Ваши Данные:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.label_name.Location = new System.Drawing.Point(487, 153);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(93, 22);
            this.label_name.TabIndex = 5;
            this.label_name.Text = "label_name";
            // 
            // label_fname
            // 
            this.label_fname.AutoSize = true;
            this.label_fname.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.label_fname.Location = new System.Drawing.Point(487, 188);
            this.label_fname.Name = "label_fname";
            this.label_fname.Size = new System.Drawing.Size(98, 22);
            this.label_fname.TabIndex = 4;
            this.label_fname.Text = "label_fname";
            // 
            // label_fam
            // 
            this.label_fam.AutoSize = true;
            this.label_fam.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.label_fam.Location = new System.Drawing.Point(487, 118);
            this.label_fam.Name = "label_fam";
            this.label_fam.Size = new System.Drawing.Size(80, 22);
            this.label_fam.TabIndex = 3;
            this.label_fam.Text = "label_fam";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.label21.Location = new System.Drawing.Point(322, 153);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 22);
            this.label21.TabIndex = 2;
            this.label21.Text = "Имя";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.label20.Location = new System.Drawing.Point(322, 188);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 22);
            this.label20.TabIndex = 1;
            this.label20.Text = "Отчество";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.label19.Location = new System.Drawing.Point(322, 118);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 22);
            this.label19.TabIndex = 0;
            this.label19.Text = "Фамилия";
            // 
            // dataSetCatalog
            // 
            this.dataSetCatalog.DataSetName = "NewDataSet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(941, 450);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Окно Пользователя";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalog)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCatalog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MySql.Data.MySqlClient.MySqlConnection cn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DateTimePicker dateTimePickerBookingCatalog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBoxTechCatalog;
        private System.Windows.Forms.DataGridView dataGridViewCatalog;
        private System.Data.DataSet dataSetCatalog;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonFindCatalog;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTimeStartCatalog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTimeEndCatalog;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonBookingCatalog;
        private System.Windows.Forms.TextBox textBoxRoomNumberCatalog;
        private System.Windows.Forms.MonthCalendar monthCalendarBooking;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button buttonUpdateUser;
        private System.Windows.Forms.Label label_call_number;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_fname;
        private System.Windows.Forms.Label label_fam;
    }
}

