namespace ANSystem
{
    partial class SpotsmanForm
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
            this.dataListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataListBox
            // 
            this.dataListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataListBox.FormattingEnabled = true;
            this.dataListBox.ItemHeight = 20;
            this.dataListBox.Location = new System.Drawing.Point(12, 27);
            this.dataListBox.Name = "dataListBox";
            this.dataListBox.Size = new System.Drawing.Size(370, 244);
            this.dataListBox.TabIndex = 1;
            this.dataListBox.Click += new System.EventHandler(this.listBox1_Click);
            this.dataListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataListBox_MouseClick);
            this.dataListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.dataListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataListBox_MouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(389, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 251);
            this.textBox1.TabIndex = 4;
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.SystemColors.Info;
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailBox.Enabled = false;
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailBox.Location = new System.Drawing.Point(389, 59);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(202, 15);
            this.emailBox.TabIndex = 5;
            // 
            // dateOfBirthBox
            // 
            this.dateOfBirthBox.BackColor = System.Drawing.SystemColors.Info;
            this.dateOfBirthBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateOfBirthBox.Enabled = false;
            this.dateOfBirthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOfBirthBox.Location = new System.Drawing.Point(389, 80);
            this.dateOfBirthBox.Name = "dateOfBirthBox";
            this.dateOfBirthBox.Size = new System.Drawing.Size(202, 15);
            this.dateOfBirthBox.TabIndex = 5;
            this.dateOfBirthBox.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox.Location = new System.Drawing.Point(414, 120);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(179, 140);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // firstNameBox
            // 
            this.firstNameBox.BackColor = System.Drawing.SystemColors.Info;
            this.firstNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameBox.Enabled = false;
            this.firstNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameBox.Location = new System.Drawing.Point(391, 38);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(202, 15);
            this.firstNameBox.TabIndex = 5;
            // 
            // SpotsmanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 314);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.dateOfBirthBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataListBox);
            this.Name = "SpotsmanForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SpotsmanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox dataListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox dateOfBirthBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox firstNameBox;
    }
}

