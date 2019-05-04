namespace ANSystem.View
{
    partial class TrainingsForm
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
            this.TrListBox = new System.Windows.Forms.ListBox();
            this.AddTrBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.Label();
            this.distanceTxt = new System.Windows.Forms.Label();
            this.durationTxt = new System.Windows.Forms.Label();
            this.dateAndTimeTxt = new System.Windows.Forms.Label();
            this.placeTxt = new System.Windows.Forms.Label();
            this.lableDescr = new System.Windows.Forms.Label();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.kindOfSportsTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тренировки";
            // 
            // TrListBox
            // 
            this.TrListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrListBox.FormattingEnabled = true;
            this.TrListBox.ItemHeight = 20;
            this.TrListBox.Location = new System.Drawing.Point(12, 54);
            this.TrListBox.Name = "TrListBox";
            this.TrListBox.Size = new System.Drawing.Size(361, 244);
            this.TrListBox.TabIndex = 1;
            this.TrListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrListBox_MouseClick);
            this.TrListBox.SelectedIndexChanged += new System.EventHandler(this.TrListBox_SelectedIndexChanged);
            // 
            // AddTrBtn
            // 
            this.AddTrBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddTrBtn.Location = new System.Drawing.Point(298, 312);
            this.AddTrBtn.Name = "AddTrBtn";
            this.AddTrBtn.Size = new System.Drawing.Size(75, 23);
            this.AddTrBtn.TabIndex = 2;
            this.AddTrBtn.Text = "Добавить";
            this.AddTrBtn.UseVisualStyleBackColor = true;
            this.AddTrBtn.Click += new System.EventHandler(this.AddTrBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Enabled = false;
            this.editBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editBtn.Location = new System.Drawing.Point(217, 312);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 3;
            this.editBtn.Text = "Изменить";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Enabled = false;
            this.delBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.delBtn.Location = new System.Drawing.Point(136, 312);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 23);
            this.delBtn.TabIndex = 3;
            this.delBtn.Text = "Удалить";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(386, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Подробнее";
            // 
            // nameTxt
            // 
            this.nameTxt.AutoSize = true;
            this.nameTxt.ForeColor = System.Drawing.Color.Black;
            this.nameTxt.Location = new System.Drawing.Point(388, 54);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(60, 13);
            this.nameTxt.TabIndex = 5;
            this.nameTxt.Text = "Название:";
            // 
            // distanceTxt
            // 
            this.distanceTxt.AutoSize = true;
            this.distanceTxt.ForeColor = System.Drawing.Color.Black;
            this.distanceTxt.Location = new System.Drawing.Point(388, 88);
            this.distanceTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.distanceTxt.Name = "distanceTxt";
            this.distanceTxt.Size = new System.Drawing.Size(66, 13);
            this.distanceTxt.TabIndex = 5;
            this.distanceTxt.Text = "Дистанция:";
            // 
            // durationTxt
            // 
            this.durationTxt.AutoSize = true;
            this.durationTxt.ForeColor = System.Drawing.Color.Black;
            this.durationTxt.Location = new System.Drawing.Point(388, 105);
            this.durationTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.durationTxt.Name = "durationTxt";
            this.durationTxt.Size = new System.Drawing.Size(114, 13);
            this.durationTxt.TabIndex = 5;
            this.durationTxt.Text = "Продолжительность:";
            // 
            // dateAndTimeTxt
            // 
            this.dateAndTimeTxt.AutoSize = true;
            this.dateAndTimeTxt.ForeColor = System.Drawing.Color.Black;
            this.dateAndTimeTxt.Location = new System.Drawing.Point(388, 122);
            this.dateAndTimeTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.dateAndTimeTxt.Name = "dateAndTimeTxt";
            this.dateAndTimeTxt.Size = new System.Drawing.Size(118, 13);
            this.dateAndTimeTxt.TabIndex = 5;
            this.dateAndTimeTxt.Text = "Дата и время начала:";
            // 
            // placeTxt
            // 
            this.placeTxt.AutoSize = true;
            this.placeTxt.ForeColor = System.Drawing.Color.Black;
            this.placeTxt.Location = new System.Drawing.Point(388, 139);
            this.placeTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.placeTxt.Name = "placeTxt";
            this.placeTxt.Size = new System.Drawing.Size(42, 13);
            this.placeTxt.TabIndex = 5;
            this.placeTxt.Text = "Место:";
            // 
            // lableDescr
            // 
            this.lableDescr.AutoSize = true;
            this.lableDescr.ForeColor = System.Drawing.Color.Black;
            this.lableDescr.Location = new System.Drawing.Point(388, 156);
            this.lableDescr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.lableDescr.Name = "lableDescr";
            this.lableDescr.Size = new System.Drawing.Size(60, 13);
            this.lableDescr.TabIndex = 5;
            this.lableDescr.Text = "Описание:";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.BackColor = System.Drawing.SystemColors.Control;
            this.descriptionTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTxt.Enabled = false;
            this.descriptionTxt.Location = new System.Drawing.Point(391, 173);
            this.descriptionTxt.Multiline = true;
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(225, 77);
            this.descriptionTxt.TabIndex = 6;
            // 
            // kindOfSportsTxt
            // 
            this.kindOfSportsTxt.AutoSize = true;
            this.kindOfSportsTxt.ForeColor = System.Drawing.Color.Black;
            this.kindOfSportsTxt.Location = new System.Drawing.Point(388, 71);
            this.kindOfSportsTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.kindOfSportsTxt.Name = "kindOfSportsTxt";
            this.kindOfSportsTxt.Size = new System.Drawing.Size(91, 13);
            this.kindOfSportsTxt.TabIndex = 7;
            this.kindOfSportsTxt.Text = "Вид тренировки:";
            // 
            // TrainingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 347);
            this.Controls.Add(this.kindOfSportsTxt);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.lableDescr);
            this.Controls.Add(this.placeTxt);
            this.Controls.Add(this.dateAndTimeTxt);
            this.Controls.Add(this.durationTxt);
            this.Controls.Add(this.distanceTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.AddTrBtn);
            this.Controls.Add(this.TrListBox);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "TrainingsForm";
            this.Text = "TrainingsForm";
            this.Load += new System.EventHandler(this.TrainingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox TrListBox;
        private System.Windows.Forms.Button AddTrBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameTxt;
        private System.Windows.Forms.Label distanceTxt;
        private System.Windows.Forms.Label durationTxt;
        private System.Windows.Forms.Label dateAndTimeTxt;
        private System.Windows.Forms.Label placeTxt;
        private System.Windows.Forms.Label lableDescr;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.Label kindOfSportsTxt;
    }
}