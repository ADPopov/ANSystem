using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ANSystem.Model;
using ANSystem.Data;

namespace ANSystem.View
{

    public partial class TrainingAddForm : Form
    {
        public Training Training { get; set; }
        public string Label = "Новая тренировка";
        public string Button = "Добавить";

        public TrainingAddForm()
        {
            InitializeComponent();
        }

        private void AddTrBtn_Click(object sender, EventArgs e)
        {
            Training.Description = descriptionBox.Text;
            Training.KindOfSports = kindOfSportsBox.Text;
            Training.Time = timeTrainingBox.Value;
            Training.Date = dateTrainingBox.Value;
            Training.Distance = Convert.ToInt32(distanceBox.Text);
            Training.Duration = durationBox.Value;
            Training.UnitSystem = UnitSystemBox.Text;
            Training.Place = placeBox.Text;
            Training.NameTraining = nameTr.Text;
        }

        private void TrainingAddForm_Load(object sender, EventArgs e)
        {
            label.Text = Label;
            AddTrBtn.Text = Button;

            descriptionBox.Text = Training.Description;
            kindOfSportsBox.Text = Training.KindOfSports;
            timeTrainingBox.Value = Training.Time;
            dateTrainingBox.Value = Training.Date;
            nameTr.Text = Training.NameTraining;
            distanceBox.Text = Convert.ToString(Training.Distance);
            durationBox.Value = Training.Duration;
            UnitSystemBox.Text = Training.UnitSystem;
            placeBox.Text = Training.Place;
        }

        private void dateTimeTrBox_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
