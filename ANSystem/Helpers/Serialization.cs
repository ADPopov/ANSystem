using ANSystem.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ANSystem.Helpers
{
    class Serialization
    {
        public static void Download(List<Sportsman> list, ListBox listBox)
        {
            var ofd = new OpenFileDialog() { Filter = "Файл журнала|*.ans" };

            if (ofd.ShowDialog() != DialogResult.OK)
                return;
            var xs = new XmlSerializer(list.GetType());
            var file = File.OpenRead(ofd.FileName);
            list = (List<Sportsman>)xs.Deserialize(file);
            file.Close();
            listBox.DataSource = null;
            listBox.DataSource = list;
        }

        public static void Save(List<Sportsman> list, ListBox listBox)
        {
            var sfd = new SaveFileDialog() {Filter = "Файл журнала|*.ans"};
            if (sfd.ShowDialog() != DialogResult.OK)
                return;
            var xs = new XmlSerializer(typeof(List<Sportsman>));
            var file = File.Create(sfd.FileName);
            xs.Serialize(file, list);
            file.Close();
        }
    }
}
