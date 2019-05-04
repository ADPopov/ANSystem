using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ANSystem.Model;
using ANSystem.Helpers;

namespace ANSystem.Data
{
    class FakeData
    {
        public List<Sportsman> SportsmanFakeList { get; set; }

        public FakeData()
        {
            SportsmanFakeList = new List<Sportsman>();
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

            SportsmanFakeList.Add(sp1);
            SportsmanFakeList.Add(sp2);
            SportsmanFakeList.Add(sp3);
        }

        
    }
}
