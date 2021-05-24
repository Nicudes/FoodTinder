using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodTinder.Model
{
   public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsAdult { get; set; }

        public int NumberOfPowerUps { get; set; }
    }
}
