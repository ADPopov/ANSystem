using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ANSystem.Model;

namespace ANSystem.Data
{
    class FakeData
    {
        public Sportsman Sportsman;

        public FakeData()
        {
            var sp = new List<Sportsman>();
            var sp1 = new Sportsman() {FirstName = "Александр", LastName = "Попов", DateOfBirth = DateTime.Parse("13.11.1999"), Gender = "м"};   
        }
    }
}
