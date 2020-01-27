namespace PolyBook
{
    partial class UpdateBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateBooking));
            this.labelDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTimeStart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTimeEnd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRoom = new System.Windows.Forms.TextBox();
            this.richTextBoxPurpose = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cn = new MySql.Data.MySqlClient.MySqlConnection();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(53, 47);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(36, 17);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Время начала";
            // 
            // textBoxTimeStart
            // 
            this.textBoxTimeStart.Location = new System.Drawing.Point(193, 74);
            this.textBoxTimeStart.Name = "textBoxTimeStart";
            this.textBoxTimeStart.Size = new System.Drawing.Size(203, 24);
            this.textBoxTimeStart.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Время окончания";
            // 
            // textBoxTimeEnd
            // 
            this.textBoxTimeEnd.Location = new System.Drawing.Point(193, 104);
            this.textBoxTimeEnd.Name = "textBoxTimeEnd";
            this.textBoxTimeEnd.Size = new System.Drawing.Size(203, 24);
            this.textBoxTimeEnd.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Номер аудитории";
            // 
            // textBoxRoom
            // 
            this.textBoxRoom.Location = new System.Drawing.Point(193, 134);
            this.textBoxRoom.Name = "textBoxRoom";
            this.textBoxRoom.Size = new System.Drawing.Size(203, 24);
            this.textBoxRoom.TabIndex = 6;
            // 
            // richTextBoxPurpose
            // 
            this.richTextBoxPurpose.Location = new System.Drawing.Point(193, 164);
            this.richTextBoxPurpose.Name = "richTextBoxPurpose";
            this.richTextBoxPurpose.Size = new System.Drawing.Size(203, 61);
            this.richTextBoxPurpose.TabIndex = 8;
            this.richTextBoxPurpose.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Цель бронирования";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 10;
            // 
            // buttonSave
            // 
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Location = new System.Drawing.Point(193, 239);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(203, 40);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(193, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // UpdateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(452, 307);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxPurpose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTimeEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTimeStart);
            this.Controls.Add(this.labelDate);
            this.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateBooking";
            this.Text = "UpdateBooking";
            this.Load += new System.EventHandler(this.UpdateBooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTimeStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTimeEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRoom;
        private System.Windows.Forms.RichTextBox richTextBoxPurpose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MySql.Data.MySqlClient.MySqlConnection cn;
    }
}