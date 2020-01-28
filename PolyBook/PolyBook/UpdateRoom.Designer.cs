namespace PolyBook
{
    partial class UpdateRoom
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCapacity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cn = new MySql.Data.MySqlClient.MySqlConnection();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Location = new System.Drawing.Point(133, 194);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(160, 39);
            this.buttonSave.TabIndex = 21;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.label7.Location = new System.Drawing.Point(67, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Данные аудитории:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label4.Location = new System.Drawing.Point(68, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Тип";
            // 
            // textBoxCapacity
            // 
            this.textBoxCapacity.Location = new System.Drawing.Point(192, 114);
            this.textBoxCapacity.Name = "textBoxCapacity";
            this.textBoxCapacity.Size = new System.Drawing.Size(198, 24);
            this.textBoxCapacity.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label2.Location = new System.Drawing.Point(68, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Вместимость";
            // 
            // TextBoxNum
            // 
            this.TextBoxNum.Location = new System.Drawing.Point(192, 84);
            this.TextBoxNum.Name = "TextBoxNum";
            this.TextBoxNum.ReadOnly = true;
            this.TextBoxNum.Size = new System.Drawing.Size(198, 24);
            this.TextBoxNum.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label1.Location = new System.Drawing.Point(68, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Номер";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(192, 144);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(198, 23);
            this.comboBoxType.TabIndex = 22;
            // 
            // UpdateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(450, 280);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCapacity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxNum);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.Name = "UpdateRoom";
            this.Text = "UpdateRoom";
            this.Load += new System.EventHandler(this.UpdateRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCapacity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxNum;
        private System.Windows.Forms.Label label1;
        private MySql.Data.MySqlClient.MySqlConnection cn;
        private System.Windows.Forms.ComboBox comboBoxType;
    }
}