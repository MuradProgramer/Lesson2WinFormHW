namespace Task2
{
    partial class Form1
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
            this.grpbox_Anket = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_birthday = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_city = new System.Windows.Forms.Label();
            this.txtb_city = new System.Windows.Forms.TextBox();
            this.lbl_country = new System.Windows.Forms.Label();
            this.txtb_country = new System.Windows.Forms.TextBox();
            this.lbl_patronymic = new System.Windows.Forms.Label();
            this.txtb_patronymic = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txtb_name = new System.Windows.Forms.TextBox();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.txtb_surname = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btn_save = new System.Windows.Forms.Button();
            this.mtxtb_phone = new System.Windows.Forms.MaskedTextBox();
            this.txtb_load = new System.Windows.Forms.TextBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.grpbox_Anket.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbox_Anket
            // 
            this.grpbox_Anket.Controls.Add(this.mtxtb_phone);
            this.grpbox_Anket.Controls.Add(this.radioButton2);
            this.grpbox_Anket.Controls.Add(this.radioButton1);
            this.grpbox_Anket.Controls.Add(this.label1);
            this.grpbox_Anket.Controls.Add(this.dateTimePicker1);
            this.grpbox_Anket.Controls.Add(this.lbl_birthday);
            this.grpbox_Anket.Controls.Add(this.lbl_phone);
            this.grpbox_Anket.Controls.Add(this.lbl_city);
            this.grpbox_Anket.Controls.Add(this.txtb_city);
            this.grpbox_Anket.Controls.Add(this.lbl_country);
            this.grpbox_Anket.Controls.Add(this.txtb_country);
            this.grpbox_Anket.Controls.Add(this.lbl_patronymic);
            this.grpbox_Anket.Controls.Add(this.txtb_patronymic);
            this.grpbox_Anket.Controls.Add(this.lbl_name);
            this.grpbox_Anket.Controls.Add(this.txtb_name);
            this.grpbox_Anket.Controls.Add(this.lbl_surname);
            this.grpbox_Anket.Controls.Add(this.txtb_surname);
            this.grpbox_Anket.Enabled = false;
            this.grpbox_Anket.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpbox_Anket.Location = new System.Drawing.Point(12, 31);
            this.grpbox_Anket.Name = "grpbox_Anket";
            this.grpbox_Anket.Size = new System.Drawing.Size(234, 291);
            this.grpbox_Anket.TabIndex = 0;
            this.grpbox_Anket.TabStop = false;
            this.grpbox_Anket.Text = "Questionnaire";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Gender:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(78, 225);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // lbl_birthday
            // 
            this.lbl_birthday.AutoSize = true;
            this.lbl_birthday.Location = new System.Drawing.Point(9, 228);
            this.lbl_birthday.Name = "lbl_birthday";
            this.lbl_birthday.Size = new System.Drawing.Size(54, 16);
            this.lbl_birthday.TabIndex = 12;
            this.lbl_birthday.Text = "Birthday ";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(9, 181);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(41, 16);
            this.lbl_phone.TabIndex = 11;
            this.lbl_phone.Text = "Phone";
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Location = new System.Drawing.Point(9, 157);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(27, 16);
            this.lbl_city.TabIndex = 9;
            this.lbl_city.Text = "City";
            // 
            // txtb_city
            // 
            this.txtb_city.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtb_city.Location = new System.Drawing.Point(78, 154);
            this.txtb_city.MaxLength = 16;
            this.txtb_city.Name = "txtb_city";
            this.txtb_city.Size = new System.Drawing.Size(147, 22);
            this.txtb_city.TabIndex = 8;
            // 
            // lbl_country
            // 
            this.lbl_country.AutoSize = true;
            this.lbl_country.Location = new System.Drawing.Point(9, 133);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(49, 16);
            this.lbl_country.TabIndex = 7;
            this.lbl_country.Text = "Country";
            // 
            // txtb_country
            // 
            this.txtb_country.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtb_country.Location = new System.Drawing.Point(78, 130);
            this.txtb_country.MaxLength = 16;
            this.txtb_country.Name = "txtb_country";
            this.txtb_country.Size = new System.Drawing.Size(147, 22);
            this.txtb_country.TabIndex = 6;
            // 
            // lbl_patronymic
            // 
            this.lbl_patronymic.AutoSize = true;
            this.lbl_patronymic.Location = new System.Drawing.Point(9, 85);
            this.lbl_patronymic.Name = "lbl_patronymic";
            this.lbl_patronymic.Size = new System.Drawing.Size(67, 16);
            this.lbl_patronymic.TabIndex = 5;
            this.lbl_patronymic.Text = "Patronymic";
            // 
            // txtb_patronymic
            // 
            this.txtb_patronymic.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtb_patronymic.Location = new System.Drawing.Point(78, 82);
            this.txtb_patronymic.MaxLength = 16;
            this.txtb_patronymic.Name = "txtb_patronymic";
            this.txtb_patronymic.Size = new System.Drawing.Size(147, 22);
            this.txtb_patronymic.TabIndex = 4;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(9, 61);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(38, 16);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Name";
            // 
            // txtb_name
            // 
            this.txtb_name.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtb_name.Location = new System.Drawing.Point(78, 58);
            this.txtb_name.MaxLength = 16;
            this.txtb_name.Name = "txtb_name";
            this.txtb_name.Size = new System.Drawing.Size(147, 22);
            this.txtb_name.TabIndex = 2;
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Location = new System.Drawing.Point(9, 37);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(53, 16);
            this.lbl_surname.TabIndex = 1;
            this.lbl_surname.Text = "Surname";
            // 
            // txtb_surname
            // 
            this.txtb_surname.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtb_surname.Location = new System.Drawing.Point(78, 34);
            this.txtb_surname.MaxLength = 16;
            this.txtb_surname.Name = "txtb_surname";
            this.txtb_surname.Size = new System.Drawing.Size(147, 22);
            this.txtb_surname.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(80, 259);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 20);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(148, 259);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 20);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_save.Location = new System.Drawing.Point(12, 323);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(234, 23);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // mtxtb_phone
            // 
            this.mtxtb_phone.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.mtxtb_phone.Location = new System.Drawing.Point(78, 178);
            this.mtxtb_phone.Mask = "(999) 000-0000";
            this.mtxtb_phone.Name = "mtxtb_phone";
            this.mtxtb_phone.Size = new System.Drawing.Size(147, 22);
            this.mtxtb_phone.TabIndex = 17;
            // 
            // txtb_load
            // 
            this.txtb_load.Location = new System.Drawing.Point(70, 5);
            this.txtb_load.Name = "txtb_load";
            this.txtb_load.Size = new System.Drawing.Size(100, 20);
            this.txtb_load.TabIndex = 2;
            // 
            // btn_load
            // 
            this.btn_load.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_load.Location = new System.Drawing.Point(193, 8);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(53, 24);
            this.btn_load.TabIndex = 3;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 354);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.txtb_load);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.grpbox_Anket);
            this.MaximumSize = new System.Drawing.Size(271, 393);
            this.MinimumSize = new System.Drawing.Size(271, 393);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpbox_Anket.ResumeLayout(false);
            this.grpbox_Anket.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbox_Anket;
        private System.Windows.Forms.Label lbl_patronymic;
        private System.Windows.Forms.TextBox txtb_patronymic;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txtb_name;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.TextBox txtb_surname;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_birthday;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.TextBox txtb_city;
        private System.Windows.Forms.Label lbl_country;
        private System.Windows.Forms.TextBox txtb_country;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtb_phone;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txtb_load;
        private System.Windows.Forms.Button btn_load;
    }
}

