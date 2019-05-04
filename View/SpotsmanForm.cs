using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Serialization;
using ANSystem.Data;
using ANSystem.Model;
using ANSystem.Helpers;

namespace ANSystem.View
{
    public partial class SpotsmanForm : Form
    {
        public List<Sportsman> SportsmanList;

        public SpotsmanForm()
        {
            InitializeComponent();
            SportsmanList = new List<Sportsman>();
            var sp1 = new Sportsman
            {
                FirstName = "Александр",
                LastName = "Попов",
                Email = "AlexPopov1999@gmail.com",
                DateOfBirth = DateTime.Parse("13.11.1999"),
                Gender = "м",
                SportsCategory = "КМС",
                Photo = ImageChange.ImageToByteArray(Properties.Resources.camera_200),
                Trainings = new List<Training>
                {
                    new Training
                    {
                        NameTraining = "Training1",
                        Distance = 200,
                    },
                     new Training
                    {
                        NameTraining = "Training2",
                        Distance = 300,
                    }
                }
            };

            var sp2 = new Sportsman
            {
                FirstName = "Станислав",
                LastName = "Воложанин",
                Email = "email@gmail.com",
                DateOfBirth = DateTime.Parse("28.05.1999"),
                Gender = "м",
                SportsCategory = "КМС",
                Photo = ImageChange.ImageToByteArray(Properties.Resources.camera_200),
                Trainings = new List<Training>
                {
                    new Training
                    {
                        NameTraining = "Training1",
                        Distance = 300,
                    },
                    new Training
                    {
                        NameTraining = "Training2",
                        Distance = 500,
                    }
                }
            };

            var sp3 = new Sportsman
            {
                FirstName = "Ловской",
                LastName = "Кирилл",
                Email = "emailKirill@gmail.com",
                DateOfBirth = DateTime.Parse("20.10.1999"),
                Gender = "м",
                SportsCategory = "КМС",
                Photo = ImageChange.ImageToByteArray(Properties.Resources.camera_200),
                Trainings = new List<Training>
                {
                    new Training
                    {
                        NameTraining = "Бег вечером",
                        Distance = 5,
                        Description = "Побегал классно, самочувствие отличное",
                        Time = DateTime.Parse("20:20"),
                        Date = DateTime.Parse("20.03.2019"),
                        Duration = DateTime.Parse("01:10:20"),
                        UnitSystem = "км",
                        KindOfSports = "Бег",
                        Place = "Стадион"
                    },
                    new Training
                    {
                        NameTraining = "Бег утром",
                        Distance = 4,
                        Description = "Побегал неплохо, было тяжко",
                        Time = DateTime.Parse("10:20"),
                        Date = DateTime.Parse("23.03.2019"),
                        Duration = DateTime.Parse("01:00:20"),
                        UnitSystem = "км",
                        KindOfSports = "Бег",
                        Place = "Парк"
                    }
                }
            };

            SportsmanList.Add(sp1);
            SportsmanList.Add(sp2);
            SportsmanList.Add(sp3);
            dataListBox.DataSource = null;
            dataListBox.DataSource = SportsmanList;

            dataListBox.SelectedIndexChanged += DataListBox_SelectedIndexChanged;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var sa = new SpotsmanAddForm() {Sportsman = new Sportsman() {DateOfBirth = DateTime.Now, }, Label = "Новый спортсмен", Im = Properties.Resources.camera_200 };
            if (sa.ShowDialog(this) == DialogResult.OK)
            {
                SportsmanList.Add(sa.Sportsman);
                dataListBox.DataSource = null;
                dataListBox.DataSource = SportsmanList;

            }
        }

        private void DataListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            delBtn.Enabled = dataListBox.SelectedItem is Sportsman;
            editBtn.Enabled = dataListBox.SelectedItem is Sportsman;
        }

        private void DataListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = dataListBox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                var item = (Sportsman)dataListBox.Items[index];
                if (item.Trainings == null)
                {
                    item.Trainings = new List<Training>();
                }
                var tr = new TrainingsForm() { TrainigsList = item.Trainings };
                tr.ShowDialog();
            }

        }

        private void DataListBox_MouseClick(object sender, MouseEventArgs e)
        {
            int index = dataListBox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                var item = (Sportsman)dataListBox.Items[index];
                InfoChange(item);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            int index = dataListBox.SelectedIndex;
            if (index != ListBox.NoMatches)
            {
                var item = (Sportsman)dataListBox.Items[index];
                var ms = new MemoryStream(item.Photo);
                var ff = new SpotsmanAddForm() { Sportsman = item, Im = Image.FromStream(ms), Label = "Редактирование", BtnTxt = "Изменить" };
                if (ff.ShowDialog(this) == DialogResult.OK)
                {
                    SportsmanList.Remove(item);
                    SportsmanList.Insert(index, item);
                    dataListBox.DataSource = null;
                    dataListBox.DataSource = SportsmanList;
                    InfoChange(item);
                }
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (dataListBox.SelectedItem is Sportsman)
            {
                SportsmanList.Remove((Sportsman)dataListBox.SelectedItem);
                dataListBox.DataSource = null;
                dataListBox.DataSource = SportsmanList;
            }
            InfoChange((Sportsman)dataListBox.SelectedItem);
        }
       
        private void SpotsmanForm_Load(object sender, EventArgs e)
        {
            dataListBox.DataSource = null;
            dataListBox.DataSource = SportsmanList;
        }

        private void InfoChange(Sportsman item)
        {
            if (item == null) 
            {
                FirstNameTxt.Text = "Фамилия: ";
                LastNameTxt.Text = "Имя: ";
                DateOfBirthTxt.Text = "Дата рождения: ";
                EmailTxt.Text = "Email: ";
                SportCategoryTxt.Text = "Спортивный разряд: ";
                pictureBox.Image = null;
            }
            else
            {
                FirstNameTxt.Text = "Фамилия: " + item.FirstName;
                LastNameTxt.Text = "Имя: " + item.LastName;
                DateOfBirthTxt.Text = "Дата рождения: " + item.DateOfBirth.ToLongDateString();
                EmailTxt.Text = "Email: " + item.Email;
                SportCategoryTxt.Text = "Спортивный разряд: " + item.SportsCategory;
                pictureBox.Image = ImageChange.ByteToImage(item.Photo);
            }
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog() { Filter = "Файл журнала|*.ans" };
            if (sfd.ShowDialog(this) != DialogResult.OK)
                return;
            var xs = new XmlSerializer(typeof(List<Sportsman>));
            var file = File.Create(sfd.FileName);
            xs.Serialize(file, SportsmanList);
            file.Close();
        }

        private void DownloadMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Файл журнала|*.ans" };

            if (ofd.ShowDialog(this) != DialogResult.OK)
                return;
            var xs = new XmlSerializer(SportsmanList.GetType());
            var file = File.OpenRead(ofd.FileName);
            SportsmanList = (List<Sportsman>)xs.Deserialize(file);
            file.Close();
            dataListBox.DataSource = null;
            dataListBox.DataSource = SportsmanList;
        }
    }
}
