using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodTinder.Model
{
   public class Dish
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Photo { get; set; }

        public string AddedBy { get; set; }
    }
}
