using System;
using System.Collections.Generic;
using System.Text;

namespace FoodTinder.Model
{
    class Profile
    {
        List<User> Users { get; set; }
        List<WeeklySchedule> MyWeeklySchedule { get; set; }
        List<Dish> MyAddedDishes { get; set; }
    }
}
