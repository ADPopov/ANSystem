namespace ANSystem.View
{
    partial class TrainingAddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.distanceBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UnitSystemBox = new System.Windows.Forms.ComboBox();
            this.hourBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.minBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.secBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.KindOfSportsBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimeTrBox = new System.Windows.Forms.DateTimePicker();
            this.TimeBox = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NameTr = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.AddTrBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Новая тренировка";
            // 
            // distanceBox
            // 
            this.distanceBox.Location = new System.Drawing.Point(18, 63);
            this.distanceBox.Name = "distanceBox";
            this.distanceBox.Size = new System.Drawing.Size(110, 20);
            this.distanceBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дистанция";
            // 
            // UnitSystemBox
            // 
            this.UnitSystemBox.FormattingEnabled = true;
            this.UnitSystemBox.Items.AddRange(new object[] {
            "км",
            "м"});
            this.UnitSystemBox.Location = new System.Drawing.Point(134, 62);
            this.UnitSystemBox.Name = "UnitSystemBox";
            this.UnitSystemBox.Size = new System.Drawing.Size(56, 21);
            this.UnitSystemBox.TabIndex = 3;
            this.UnitSystemBox.Text = "км";
            // 
            // hourBox
            // 
            this.hourBox.BackColor = System.Drawing.Color.White;
            this.hourBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hourBox.Location = new System.Drawing.Point(222, 66);
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(25, 13);
            this.hourBox.TabIndex = 4;
            this.hourBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(249, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ч.";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(220, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(46, 22);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(275, 62);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(60, 22);
            this.textBox4.TabIndex = 4;
            // 
            // minBox
            // 
            this.minBox.BackColor = System.Drawing.Color.White;
            this.minBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minBox.Location = new System.Drawing.Point(276, 66);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(24, 13);
            this.minBox.TabIndex = 4;
            this.minBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(304, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "мин.";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(344, 62);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(60, 22);
            this.textBox6.TabIndex = 4;
            // 
            // secBox
            // 
            this.secBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secBox.Location = new System.Drawing.Point(345, 66);
            this.secBox.Name = "secBox";
            this.secBox.Size = new System.Drawing.Size(26, 13);
            this.secBox.TabIndex = 4;
            this.secBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(375, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "сек.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Продолжительность тренировки";
            // 
            // KindOfSportsBox
            // 
            this.KindOfSportsBox.FormattingEnabled = true;
            this.KindOfSportsBox.Location = new System.Drawing.Point(18, 119);
            this.KindOfSportsBox.Name = "KindOfSportsBox";
            this.KindOfSportsBox.Size = new System.Drawing.Size(172, 21);
            this.KindOfSportsBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Вид тренировки";
            // 
            // dateTimeTrBox
            // 
            this.dateTimeTrBox.Location = new System.Drawing.Point(220, 119);
            this.dateTimeTrBox.Name = "dateTimeTrBox";
            this.dateTimeTrBox.Size = new System.Drawing.Size(119, 20);
            this.dateTimeTrBox.TabIndex = 9;
            // 
            // TimeBox
            // 
            this.TimeBox.Location = new System.Drawing.Point(345, 119);
            this.TimeBox.Mask = "00:00";
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(59, 20);
            this.TimeBox.TabIndex = 10;
            this.TimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeBox.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Дата";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(345, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Время";
            // 
            // NameTr
            // 
            this.NameTr.Location = new System.Drawing.Point(18, 177);
            this.NameTr.Name = "NameTr";
            this.NameTr.Size = new System.Drawing.Size(202, 20);
            this.NameTr.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Название";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(18, 235);
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(385, 86);
            this.DescriptionBox.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Описание";
            // 
            // AddTrBtn
            // 
            this.AddTrBtn.Location = new System.Drawing.Point(328, 336);
            this.AddTrBtn.Name = "AddTrBtn";
            this.AddTrBtn.Size = new System.Drawing.Size(75, 23);
            this.AddTrBtn.TabIndex = 17;
            this.AddTrBtn.Text = "Добавить";
            this.AddTrBtn.UseVisualStyleBackColor = true;
            this.AddTrBtn.Click += new System.EventHandler(this.AddTrBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TrainingAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 370);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddTrBtn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.NameTr);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.dateTimeTrBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.KindOfSportsBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.secBox);
            this.Controls.Add(this.minBox);
            this.Controls.Add(this.hourBox);
            this.Controls.Add(this.UnitSystemBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.distanceBox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Name = "TrainingAddForm";
            this.Text = "TrainingAddForm";
            this.Load += new System.EventHandler(this.TrainingAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox distanceBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox UnitSystemBox;
        private System.Windows.Forms.TextBox hourBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox minBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox secBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox KindOfSportsBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimeTrBox;
        private System.Windows.Forms.MaskedTextBox TimeBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NameTr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button AddTrBtn;
        private System.Windows.Forms.Button button2;
    }
}