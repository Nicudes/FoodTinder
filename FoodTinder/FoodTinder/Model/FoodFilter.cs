using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodTinder.Model
{
    public class FoodFilter
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public bool RedMeat { get; set; }
        public bool Fish { get; set; }
        public bool Chicken { get; set; }
        public bool Pork { get; set; }
        public bool Vegan { get; set; }
        public bool Vegetarian { get; set; }


    }
}
