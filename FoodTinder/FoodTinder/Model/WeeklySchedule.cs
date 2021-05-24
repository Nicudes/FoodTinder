using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodTinder.Model
{
   public class WeeklySchedule
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Monday { get; set; }
        public string Tuesday { get; set; }
        public string Wednsday { get; set; }
        public string Thursday { get; set; }
        public string Friday { get; set; }
        public string Saturday { get; set; }
        public string Sunday { get; set; }


    }
}
