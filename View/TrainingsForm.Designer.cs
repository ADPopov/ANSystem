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
            this.EditTrBtn = new System.Windows.Forms.Button();
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
            this.TrListBox.FormattingEnabled = true;
            this.TrListBox.Location = new System.Drawing.Point(12, 54);
            this.TrListBox.Name = "TrListBox";
            this.TrListBox.Size = new System.Drawing.Size(307, 251);
            this.TrListBox.TabIndex = 1;
            this.TrListBox.SelectedIndexChanged += new System.EventHandler(this.TrListBox_SelectedIndexChanged);
            // 
            // AddTrBtn
            // 
            this.AddTrBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddTrBtn.Location = new System.Drawing.Point(445, 282);
            this.AddTrBtn.Name = "AddTrBtn";
            this.AddTrBtn.Size = new System.Drawing.Size(75, 23);
            this.AddTrBtn.TabIndex = 2;
            this.AddTrBtn.Text = "Add";
            this.AddTrBtn.UseVisualStyleBackColor = true;
            this.AddTrBtn.Click += new System.EventHandler(this.AddTrBtn_Click);
            // 
            // EditTrBtn
            // 
            this.EditTrBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditTrBtn.Location = new System.Drawing.Point(364, 282);
            this.EditTrBtn.Name = "EditTrBtn";
            this.EditTrBtn.Size = new System.Drawing.Size(75, 23);
            this.EditTrBtn.TabIndex = 3;
            this.EditTrBtn.Text = "Edit";
            this.EditTrBtn.UseVisualStyleBackColor = true;
            // 
            // TrainingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 322);
            this.Controls.Add(this.EditTrBtn);
            this.Controls.Add(this.AddTrBtn);
            this.Controls.Add(this.TrListBox);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "TrainingsForm";
            this.Text = "TrainingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox TrListBox;
        private System.Windows.Forms.Button AddTrBtn;
        private System.Windows.Forms.Button EditTrBtn;
    }
}