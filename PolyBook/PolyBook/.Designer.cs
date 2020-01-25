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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonBook = new System.Windows.Forms.Button();
            this.textBoxRoomIdBooking = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.monthCalendarBooking = new System.Windows.Forms.MonthCalendar();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxTimeStartBooking = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxTimeEndBooking = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.checkedListBoxBooking = new System.Windows.Forms.CheckedListBox();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGridViewBooking = new System.Windows.Forms.DataGridView();
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
            this.dataSetBooking = new System.Data.DataSet();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.richTextBoxBooking = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalog)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCatalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBooking)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(941, 532);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MintCream;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.richTextBoxBooking);
            this.tabPage2.Controls.Add(this.buttonBook);
            this.tabPage2.Controls.Add(this.textBoxRoomIdBooking);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.monthCalendarBooking);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.textBoxTimeStartBooking);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.textBoxTimeEndBooking);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.checkedListBoxBooking);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(933, 504);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Бронирование";
            // 
            // buttonBook
            // 
            this.buttonBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBook.Location = new System.Drawing.Point(508, 410);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(240, 43);
            this.buttonBook.TabIndex = 27;
            this.buttonBook.Text = "Забронировать";
            this.buttonBook.UseVisualStyleBackColor = true;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // textBoxRoomIdBooking
            // 
            this.textBoxRoomIdBooking.Location = new System.Drawing.Point(508, 253);
            this.textBoxRoomIdBooking.Name = "textBoxRoomIdBooking";
            this.textBoxRoomIdBooking.Size = new System.Drawing.Size(240, 24);
            this.textBoxRoomIdBooking.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(505, 233);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 17);
            this.label15.TabIndex = 25;
            this.label15.Text = "Введите номер аудитории";
            // 
            // monthCalendarBooking
            // 
            this.monthCalendarBooking.Location = new System.Drawing.Point(170, 115);
            this.monthCalendarBooking.Name = "monthCalendarBooking";
            this.monthCalendarBooking.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.label16.Location = new System.Drawing.Point(42, 40);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(462, 22);
            this.label16.TabIndex = 23;
            this.label16.Text = "Для бронирования аудитории введите следующие данные:";
            // 
            // textBoxTimeStartBooking
            // 
            this.textBoxTimeStartBooking.Location = new System.Drawing.Point(508, 115);
            this.textBoxTimeStartBooking.Name = "textBoxTimeStartBooking";
            this.textBoxTimeStartBooking.Size = new System.Drawing.Size(240, 24);
            this.textBoxTimeStartBooking.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(505, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(245, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Введите время окончания бронирования";
            // 
            // textBoxTimeEndBooking
            // 
            this.textBoxTimeEndBooking.Location = new System.Drawing.Point(508, 184);
            this.textBoxTimeEndBooking.Name = "textBoxTimeEndBooking";
            this.textBoxTimeEndBooking.Size = new System.Drawing.Size(240, 24);
            this.textBoxTimeEndBooking.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(505, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(226, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "Введите время начала бронирования";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label13.Location = new System.Drawing.Point(167, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(180, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "Выберете дату бронирования";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label14.Location = new System.Drawing.Point(505, 296);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(298, 17);
            this.label14.TabIndex = 16;
            this.label14.Text = "Выберете техническое оборудование в аудитории";
            // 
            // checkedListBoxBooking
            // 
            this.checkedListBoxBooking.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.checkedListBoxBooking.FormattingEnabled = true;
            this.checkedListBoxBooking.Items.AddRange(new object[] {
            "Микрофон",
            "Проектор",
            "Персональный компьютер",
            "Интерактивная доска"});
            this.checkedListBoxBooking.Location = new System.Drawing.Point(508, 316);
            this.checkedListBoxBooking.Name = "checkedListBoxBooking";
            this.checkedListBoxBooking.Size = new System.Drawing.Size(240, 80);
            this.checkedListBoxBooking.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MintCream;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.richTextBox1);
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
            this.tabPage1.Size = new System.Drawing.Size(933, 504);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Каталог";
            // 
            // textBoxRoomNumberCatalog
            // 
            this.textBoxRoomNumberCatalog.Location = new System.Drawing.Point(331, 458);
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
            this.buttonBookingCatalog.Location = new System.Drawing.Point(725, 436);
            this.buttonBookingCatalog.Name = "buttonBookingCatalog";
            this.buttonBookingCatalog.Size = new System.Drawing.Size(178, 43);
            this.buttonBookingCatalog.TabIndex = 18;
            this.buttonBookingCatalog.Text = "Забронировать";
            this.buttonBookingCatalog.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 436);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(364, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Введите номер аудитории из списка выше для бронирования";
            // 
            // buttonFindCatalog
            // 
            this.buttonFindCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFindCatalog.Location = new System.Drawing.Point(34, 436);
            this.buttonFindCatalog.Name = "buttonFindCatalog";
            this.buttonFindCatalog.Size = new System.Drawing.Size(240, 43);
            this.buttonFindCatalog.TabIndex = 15;
            this.buttonFindCatalog.Text = "Поиск";
            this.buttonFindCatalog.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(316, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "то  необходимо изменить настройки фильтров поиска";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 382);
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
            this.dataGridViewCatalog.Size = new System.Drawing.Size(572, 311);
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
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.MintCream;
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.buttonDelete);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.dataGridViewBooking);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(933, 504);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Мои Бронирования";
            // 
            // buttonDelete
            // 
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Location = new System.Drawing.Point(706, 417);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(147, 43);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(66, 437);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(562, 23);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(63, 417);
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
            // dataGridViewBooking
            // 
            this.dataGridViewBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBooking.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridViewBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooking.Location = new System.Drawing.Point(7, 74);
            this.dataGridViewBooking.Name = "dataGridViewBooking";
            this.dataGridViewBooking.ReadOnly = true;
            this.dataGridViewBooking.Size = new System.Drawing.Size(917, 311);
            this.dataGridViewBooking.TabIndex = 0;
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
            this.tabPage4.Size = new System.Drawing.Size(933, 504);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Моя Страница";
            // 
            // buttonUpdateUser
            // 
            this.buttonUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdateUser.Location = new System.Drawing.Point(369, 351);
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
            this.label_call_number.Location = new System.Drawing.Point(487, 279);
            this.label_call_number.Name = "label_call_number";
            this.label_call_number.Size = new System.Drawing.Size(142, 22);
            this.label_call_number.TabIndex = 12;
            this.label_call_number.Text = "label_call_number";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.label_email.Location = new System.Drawing.Point(487, 244);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(92, 22);
            this.label_email.TabIndex = 10;
            this.label_email.Text = "label_email";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.label29.Location = new System.Drawing.Point(322, 279);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(136, 22);
            this.label29.TabIndex = 9;
            this.label29.Text = "Номер телефона";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.label31.Location = new System.Drawing.Point(322, 244);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(49, 22);
            this.label31.TabIndex = 7;
            this.label31.Text = "email";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.label25.Location = new System.Drawing.Point(322, 92);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(120, 22);
            this.label25.TabIndex = 6;
            this.label25.Text = "Ваши Данные:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.label_name.Location = new System.Drawing.Point(487, 176);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(93, 22);
            this.label_name.TabIndex = 5;
            this.label_name.Text = "label_name";
            // 
            // label_fname
            // 
            this.label_fname.AutoSize = true;
            this.label_fname.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.label_fname.Location = new System.Drawing.Point(487, 211);
            this.label_fname.Name = "label_fname";
            this.label_fname.Size = new System.Drawing.Size(98, 22);
            this.label_fname.TabIndex = 4;
            this.label_fname.Text = "label_fname";
            // 
            // label_fam
            // 
            this.label_fam.AutoSize = true;
            this.label_fam.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.label_fam.Location = new System.Drawing.Point(487, 141);
            this.label_fam.Name = "label_fam";
            this.label_fam.Size = new System.Drawing.Size(80, 22);
            this.label_fam.TabIndex = 3;
            this.label_fam.Text = "label_fam";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.label21.Location = new System.Drawing.Point(322, 176);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 22);
            this.label21.TabIndex = 2;
            this.label21.Text = "Имя";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.label20.Location = new System.Drawing.Point(322, 211);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 22);
            this.label20.TabIndex = 1;
            this.label20.Text = "Отчество";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri Light", 13F);
            this.label19.Location = new System.Drawing.Point(322, 141);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 22);
            this.label19.TabIndex = 0;
            this.label19.Text = "Фамилия";
            // 
            // dataSetCatalog
            // 
            this.dataSetCatalog.DataSetName = "NewDataSet";
            // 
            // dataSetBooking
            // 
            this.dataSetBooking.DataSetName = "NewDataSet";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(34, 361);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(240, 69);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label22.Location = new System.Drawing.Point(31, 341);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(175, 17);
            this.label22.TabIndex = 22;
            this.label22.Text = "Укажите цель бронирования:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label23.Location = new System.Drawing.Point(167, 296);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(175, 17);
            this.label23.TabIndex = 29;
            this.label23.Text = "Укажите цель бронирования:";
            // 
            // richTextBoxBooking
            // 
            this.richTextBoxBooking.Location = new System.Drawing.Point(170, 316);
            this.richTextBoxBooking.Name = "richTextBoxBooking";
            this.richTextBoxBooking.Size = new System.Drawing.Size(240, 137);
            this.richTextBoxBooking.TabIndex = 28;
            this.richTextBoxBooking.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(941, 532);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Окно Пользователя";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalog)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCatalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBooking)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxTimeStartBooking;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxTimeEndBooking;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckedListBox checkedListBoxBooking;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.TextBox textBoxRoomIdBooking;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dataGridViewBooking;
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
        private System.Data.DataSet dataSetBooking;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.RichTextBox richTextBoxBooking;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

