using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANSystem.View
{
    public partial class TrainingsForm : Form
    {
        public TrainingsForm()
        {
            InitializeComponent();
        }

        private void AddTrBtn_Click(object sender, EventArgs e)
        {
            var tr = new TrainingAddForm();
            tr.ShowDialog();
        }

        private void TrListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
