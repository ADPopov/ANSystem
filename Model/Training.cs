using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANSystem.Model
{
    /// <summary>
    /// Тренировка
    /// </summary>
    public class Training
    {
        public Training(DateTime date, int distance)
        {
            Date = date;
            Distance = distance;

        }
        /// <summary>
        /// Дата
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Время
        /// </summary>
        public DateTime Time { get; set; }
        /// <summary>
        /// Дистанция пройденная спортсменом
        /// </summary>
        public int Distance { get; set; }
        /// <summary>
        /// Продолжительность
        /// </summary>
        public int Duration { get; set; }
        /// <summary>
        /// Тип
        /// </summary>
        public string KindOfSports { get; set; }
        /// <summary>
        /// Название
        /// </summary>
        public string NameTraining { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Место
        /// </summary>
        public string Place { get; set; }

        public override string ToString()
        {
            return "Дата тренировки: " + Date.Hour + "      Дистанция: " + Distance;
        }
    }
}
