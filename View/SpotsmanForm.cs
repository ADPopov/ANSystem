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
using ANSystem.View;

namespace ANSystem
{
    public partial class SpotsmanForm : Form
    {
        public List<Sportsman> SportsmanList;

        public SpotsmanForm()
        {
            InitializeComponent();
            SportsmanList = new List<Sportsman>();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var sa = new SpotsmanAddForm() {Sportsman = new Sportsman() {DateOfBirth = DateTime.Now}, Label = "Новый спортсмен" };
            if (sa.ShowDialog(this) == DialogResult.OK)
            {
                dataListBox.Items.Add(sa.Sportsman);
            }
        }



        private void SpotsmanForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        private void dataListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = dataListBox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                var item = (Sportsman)dataListBox.Items[index];
                var ms = new MemoryStream(item.Photo);
                var ff = new SpotsmanAddForm() {Sportsman = item, Im = Image.FromStream(ms), Label = "Редактирование", BtnTxt = "Изменить"};
                if (ff.ShowDialog(this) == DialogResult.OK)
                {
                    dataListBox.Items.Remove(item);
                    dataListBox.Items.Insert(index, item);
                }
            }
        }

        private void dataListBox_MouseClick(object sender, MouseEventArgs e)
        {
            int index = dataListBox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                var item = (Sportsman)dataListBox.Items[index];
                firstNameBox.Text = item.FirstName + " " + item.LastName;
                dateOfBirthBox.Text = "Дата рождения: " + item.DateOfBirth.ToLongDateString();
                emailBox.Text = item.Email;
                pictureBox.Image = ByteToImage(item.Photo);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
