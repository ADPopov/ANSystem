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
                SportsCategory = "I",
                Photo = ImageChange.ImageToByteArray(Properties.Resources.camera_200),
                Trainings = new List<Training>
                {
                    new Training
                    {
                        NameTraining = "Бег у озера",
                        Distance = 5,
                        Description = "Самочувствие отличное. Встретил бабу Нину, скзала что я молодец!)))",
                        Time = DateTime.Parse("20:20"),
                        Date = DateTime.Parse("10.03.2019"),
                        Duration = DateTime.Parse("01:10:20"),
                        UnitSystem = "км",
                        KindOfSports = "Бег",
                        Place = "Стадион"
                    },
                    new Training
                    {
                        NameTraining = "Бег в манеже УрФУ",
                        Distance = 4,
                        Description = "Побегал неплохо, проколол колесо",
                        Time = DateTime.Parse("10:20"),
                        Date = DateTime.Parse("25.04.2019"),
                        Duration = DateTime.Parse("01:00:20"),
                        UnitSystem = "км",
                        KindOfSports = "Велосипед",
                        Place = "Парк"
                    },
                    new Training
                    {
                        NameTraining = "Прогулка по парку",
                        Distance = 4,
                        Description = "Спокойным шагом",
                        Time = DateTime.Parse("10:20"),
                        Date = DateTime.Parse("05.03.2019"),
                        Duration = DateTime.Parse("01:00:20"),
                        UnitSystem = "км",
                        KindOfSports = "Бег",
                        Place = "Парк"
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
                SportsCategory = "I",
                Photo = ImageChange.ImageToByteArray(Properties.Resources.camera_200),
                Trainings = new List<Training>
                {
                    new Training
                    {
                        NameTraining = "Бег по парку",
                        Distance = 5,
                        Description = "Самочувствие отличное, шел снег",
                        Time = DateTime.Parse("20:20"),
                        Date = DateTime.Parse("10.05.2019"),
                        Duration = DateTime.Parse("01:10:20"),
                        UnitSystem = "км",
                        KindOfSports = "Бег",
                        Place = "Стадион"
                    },
                    new Training
                    {
                        NameTraining = "Поездка на велосипеде",
                        Distance = 4,
                        Description = "Побегал неплохо, проколол колесо",
                        Time = DateTime.Parse("10:20"),
                        Date = DateTime.Parse("23.03.2019"),
                        Duration = DateTime.Parse("01:00:20"),
                        UnitSystem = "км",
                        KindOfSports = "Велосипед",
                        Place = "Парк"
                    },
                    new Training
                    {
                    NameTraining = "Прогулка по парку",
                    Distance = 4,
                    Description = "Спокойным шагом",
                    Time = DateTime.Parse("10:20"),
                    Date = DateTime.Parse("05.03.2019"),
                    Duration = DateTime.Parse("01:00:20"),
                    UnitSystem = "км",
                    KindOfSports = "Бег",
                    Place = "Парк"
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
                    
