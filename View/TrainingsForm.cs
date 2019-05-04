using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ANSystem.Model;

namespace ANSystem.View
{
    public partial class TrainingsForm : Form
    {
        public List<Training> TrainigsList;

        public TrainingsForm()
        {
            InitializeComponent();
        }

        private void AddTrBtn_Click(object sender, EventArgs e)
        {
            var tr = new TrainingAddForm() { Training = new Training() {Date = DateTime.Now, Time = DateTime.Now, Duration = DateTime.Now} };
            if (tr.ShowDialog(this) == DialogResult.OK)
            {
                TrainigsList.Add(tr.Training);
                TrListBox.DataSource = null;
                TrListBox.DataSource = TrainigsList;
            }
        }

        private void TrListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            delBtn.Enabled = TrListBox.SelectedItem is Training;
            editBtn.Enabled = TrListBox.SelectedItem is Training;
            TrListBox.DataSource = null;
            TrListBox.DataSource = TrainigsList;
        }

        private void TrainingsForm_Load(object sender, EventArgs e)
        {
             TrListBox.DataSource = null;
             TrListBox.DataSource = TrainigsList;
        }

        private void TrListBox_MouseClick(object sender, MouseEventArgs e)
        {
            int index = TrListBox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                var item = (Training)TrListBox.Items[index];
                InfoChange(item);
            }
        }

        private void InfoChange(Training item)
        {
            if (item == null)
            {
                nameTxt.Text = "Название: ";
                distanceTxt.Text = "Дистанция: ";
                durationTxt.Text = "Продолжительность:";
                dateAndTimeTxt.Text = "Дата и время начала: ";
                descriptionTxt.Text = "";
                placeTxt.Text = "Место: ";
                kindOfSportsTxt.Text = "Вид тренировки: ";
            }
            else
            {
                nameTxt.Text = "Название: " + item.NameTraining;
                distanceTxt.Text = "Дистанция: " + item.Distance;
                durationTxt.Text = "Продолжительность:" + item.Duration.ToLongTimeString();
                dateAndTimeTxt.Text = "Дата и время начала: " + item.Date.ToLongDateString() + " " + item.Time.ToLongTimeString();
                descriptionTxt.Text = item.Description;
                placeTxt.Text = "Место: " + item.Place;
                kindOfSportsTxt.Text = "Вид тренировки: " + item.KindOfSports;
            }
            
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (TrListBox.SelectedItem is Training)
            {
                TrainigsList.Remove((Training)TrListBox.SelectedItem);
                TrListBox.DataSource = null;
                TrListBox.DataSource = TrainigsList;
            }
            InfoChange((Training)TrListBox.SelectedItem);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            int index = TrListBox.SelectedIndex;
            if (index != ListBox.NoMatches)
            {
                var item = (Training)TrListBox.Items[index];
                var ff = new TrainingAddForm() { Training = item, Label = "Редактирование", Button = "Изменить" };
                if (ff.ShowDialog(this) == DialogResult.OK)
                {
                    TrainigsList.Remove(item);
                    TrainigsList.Insert(index, item);
                    TrListBox.DataSource = null;
                    TrListBox.DataSource = TrainigsList;
                    InfoChange(item);
                }
            }
        }
    }
}
