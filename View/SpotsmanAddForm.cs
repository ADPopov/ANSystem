using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ANSystem.Model;

namespace ANSystem.View
{
    public partial class SpotsmanAddForm : Form
    {
        public ListBox DataListBox { get; set; }

        public List<Sportsman> Sportsman;

        public string Label;

        public SpotsmanAddForm(List<Sportsman> sportsman, ListBox dataListbox)
        {
            InitializeComponent();
            DataListBox = dataListbox;
            Sportsman = sportsman;
            Sportsman = new List<Sportsman>();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var stream = new MemoryStream();
            imageBox.Image.Save(stream, ImageFormat.Jpeg);

            var sp = new Sportsman()
            {
                FirstName = firstNameBox.Text,
                LastName = lastNameBox.Text,
                Email = emailBox.Text,
                Gender = genderBox.Text,
                SportsCategory = sportCantegoryBox.Text,
                DateOfBirth = dateOfBirthBox.Value,
                Photo = stream.ToArray()
            };
            Sportsman.Add(sp);
            DataListBox.DataSource = null;
            DataListBox.DataSource = Sportsman;
            Close();
        }

        private void ImageBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            NewImage();
        }

        private void EditPhotoBtn_Click(object sender, EventArgs e)
        {
            NewImage();
        }

        public void NewImage()
        {
            var ofd = new OpenFileDialog() { Filter = "Фотография|*.jpg" };
            var dr = ofd.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                imageBox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SpotsmanAddForm_Load(object sender, EventArgs e)
        {
            label4.Text = Label;
        }
    }
}
