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
            var ff = new SpotsmanAddForm(SportsmanList, dataListBox) {Sportsman = SportsmanList, Label = "Новый спортсмен"};
            if (ff.ShowDialog(this) == DialogResult.OK)
            {
                dataListBox.Items.Add(ff.Sportsman);
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
            
            var index = this.dataListBox.SelectedIndex;
            if (index >= 0 && SportsmanList.Count > 0 && dataListBox.GetSelected(index))
            {
                var sp = SportsmanList[index];
                firstNameBox.Text =  sp.FirstName + " " + sp.FirstName;
                dateOfBirthBox.Text = sp.DateOfBirth.ToLongDateString();
                emailBox.Text = sp.Email;
                pictureBox.Image = ByteToImage(sp.Photo);

            }
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
            int index = this.dataListBox.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                var item = (Sportsman)dataListBox.Items[index];
                var ff = new SpotsmanAddForm(SportsmanList, dataListBox) {Sportsman = SportsmanList, Label = "Редактирование" };
                if (ff.ShowDialog(this) == DialogResult.OK)
                {
                    dataListBox.Items.Remove(item);
                    dataListBox.Items.Insert(index, item);
                }
            }
        }
    }
}
