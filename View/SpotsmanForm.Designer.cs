namespace ANSystem.View
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
            this.editBtn = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DownloadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FirstNameTxt = new System.Windows.Forms.Label();
            this.LastNameTxt = new System.Windows.Forms.Label();
            this.EmailTxt = new System.Windows.Forms.Label();
            this.DateOfBirthTxt = new System.Windows.Forms.Label();
            this.SportCategoryTxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataListBox
            // 
            this.dataListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataListBox.FormattingEnabled = true;
            this.dataListBox.ItemHeight = 20;
            this.dataListBox.Location = new System.Drawing.Point(12, 67);
            this.dataListBox.Name = "dataListBox";
            this.dataListBox.Size = new System.Drawing.Size(237, 164);
            this.dataListBox.TabIndex = 1;
            this.dataListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataListBox_MouseClick);
            this.dataListBox.SelectedIndexChanged += new System.EventHandler(this.DataListBox_SelectedIndexChanged);
            this.dataListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DataListBox_MouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Enabled = false;
            this.editBtn.Location = new System.Drawing.Point(93, 237);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 3;
            this.editBtn.Text = "Изменить";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Location = new System.Drawing.Point(458, 67);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(154, 152);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Спортсмены";
            // 
            // delBtn
            // 
            this.delBtn.Enabled = false;
            this.delBtn.Location = new System.Drawing.Point(12, 237);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 23);
            this.delBtn.TabIndex = 8;
            this.delBtn.Text = "Удалить";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.HelpToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DownloadMenuItem,
            this.SaveMenuItem,
            this.выйтиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // DownloadMenuItem
            // 
            this.DownloadMenuItem.Name = "DownloadMenuItem";
            this.DownloadMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DownloadMenuItem.Text = "Загрузить";
            this.DownloadMenuItem.Click += new System.EventHandler(this.DownloadMenuItem_Click);
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveMenuItem.Text = "Сохранить";
            this.SaveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.HelpToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // FirstNameTxt
            // 
            this.FirstNameTxt.AutoSize = true;
            this.FirstNameTxt.Location = new System.Drawing.Point(255, 84);
            this.FirstNameTxt.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.FirstNameTxt.Name = "FirstNameTxt";
            this.FirstNameTxt.Size = new System.Drawing.Size(35, 13);
            this.FirstNameTxt.TabIndex = 10;
            this.FirstNameTxt.Text = "Имя: ";
            // 
            // LastNameTxt
            // 
            this.LastNameTxt.AutoSize = true;
            this.LastNameTxt.Location = new System.Drawing.Point(255, 67);
            this.LastNameTxt.Name = "LastNameTxt";
            this.LastNameTxt.Size = new System.Drawing.Size(62, 13);
            this.LastNameTxt.TabIndex = 11;
            this.LastNameTxt.Text = "Фамилия: ";
            // 
            // EmailTxt
            // 
            this.EmailTxt.AutoSize = true;
            this.EmailTxt.Location = new System.Drawing.Point(255, 101);
            this.EmailTxt.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(38, 13);
            this.EmailTxt.TabIndex = 10;
            this.EmailTxt.Text = "Email: ";
            // 
            // DateOfBirthTxt
            // 
            this.DateOfBirthTxt.AutoSize = true;
            this.DateOfBirthTxt.Location = new System.Drawing.Point(255, 118);
            this.DateOfBirthTxt.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.DateOfBirthTxt.Name = "DateOfBirthTxt";
            this.DateOfBirthTxt.Size = new System.Drawing.Size(92, 13);
            this.DateOfBirthTxt.TabIndex = 10;
            this.DateOfBirthTxt.Text = "Дата рождения: ";
            // 
            // SportCategoryTxt
            // 
            this.SportCategoryTxt.AutoSize = true;
            this.SportCategoryTxt.Location = new System.Drawing.Point(255, 135);
            this.SportCategoryTxt.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.SportCategoryTxt.Name = "SportCategoryTxt";
            this.SportCategoryTxt.Size = new System.Drawing.Size(114, 13);
            this.SportCategoryTxt.TabIndex = 10;
            this.SportCategoryTxt.Text = "Спортивный разряд: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(253, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Информация о спортсмене";
            // 
            // SpotsmanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 268);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastNameTxt);
            this.Controls.Add(this.SportCategoryTxt);
            this.Controls.Add(this.DateOfBirthTxt);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.FirstNameTxt);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SpotsmanForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SpotsmanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox dataListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DownloadMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Label FirstNameTxt;
        private System.Windows.Forms.Label LastNameTxt;
        private System.Windows.Forms.Label EmailTxt;
        private System.Windows.Forms.Label DateOfBirthTxt;
        private System.Windows.Forms.Label SportCategoryTxt;
        private System.Windows.Forms.Label label2;
    }
}

