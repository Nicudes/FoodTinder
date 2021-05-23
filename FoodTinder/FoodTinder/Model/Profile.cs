using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodTinder.Model
{
    public class Profile
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        List<User> Users { get; set; }
        List<WeeklySchedule> MyWeeklySchedule { get; set; }
        List<Dish> MyAddedDishes { get; set; }
        List<FoodFilter> MyFoodFilter { get; set; }
        List<Dish> MyChosenDishes { get; set; }
    }
}
