namespace ANSystem.View
{
    partial class SpotsmanAddForm
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
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateOfBirthBox = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sportCantegoryBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.EditPhotoBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(13, 60);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(175, 20);
            this.lastNameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(13, 103);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(175, 20);
            this.firstNameBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя";
            // 
            // genderBox
            // 
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Items.AddRange(new object[] {
            "м",
            "ж"});
            this.genderBox.Location = new System.Drawing.Point(120, 193);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(40, 21);
            this.genderBox.TabIndex = 4;
            this.genderBox.Text = "м";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пол";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(8, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Новый спортсмен";
            // 
            // dateOfBirthBox
            // 
            this.dateOfBirthBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirthBox.Location = new System.Drawing.Point(13, 194);
            this.dateOfBirthBox.Name = "dateOfBirthBox";
            this.dateOfBirthBox.Size = new System.Drawing.Size(101, 20);
            this.dateOfBirthBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Дата рождения";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(13, 149);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(175, 20);
            this.emailBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Электронная почта";
            // 
            // sportCantegoryBox
            // 
            this.sportCantegoryBox.FormattingEnabled = true;
            this.sportCantegoryBox.Items.AddRange(new object[] {
            "нет",
            "МСМК",
            "МС",
            "КМС",
            "I",
            "II",
            "III",
            "I(ю)",
            "II(ю)",
            "III(ю)"});
            this.sportCantegoryBox.Location = new System.Drawing.Point(14, 241);
            this.sportCantegoryBox.Name = "sportCantegoryBox";
            this.sportCantegoryBox.Size = new System.Drawing.Size(174, 21);
            this.sportCantegoryBox.TabIndex = 11;
            this.sportCantegoryBox.Text = "нет";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Спортивный разряд";
            // 
            // imageBox
            // 
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox.Location = new System.Drawing.Point(209, 60);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(155, 146);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 13;
            this.imageBox.TabStop = false;
            this.imageBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ImageBox_MouseDoubleClick);
            // 
            // EditPhotoBtn
            // 
            this.EditPhotoBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EditPhotoBtn.Location = new System.Drawing.Point(208, 212);
            this.EditPhotoBtn.Name = "EditPhotoBtn";
            this.EditPhotoBtn.Size = new System.Drawing.Size(155, 23);
            this.EditPhotoBtn.TabIndex = 14;
            this.EditPhotoBtn.Text = "Изменить фото";
            this.EditPhotoBtn.UseVisualStyleBackColor = true;
            this.EditPhotoBtn.Click += new System.EventHandler(this.EditPhotoBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(289, 241);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 15;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(208, 241);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 16;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Фото спортсмена";
            // 
            // SpotsmanAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 275);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.EditPhotoBtn);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sportCantegoryBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateOfBirthBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastNameBox);
            this.Name = "SpotsmanAddForm";
            this.Text = "SpotramanAddForm";
            this.Load += new System.EventHandler(this.SpotsmanAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox genderBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateOfBirthBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sportCantegoryBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Button EditPhotoBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label8;
    }
}