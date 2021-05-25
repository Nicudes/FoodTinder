using FoodTinder.Model;
using FoodTinder.ViewModel;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FoodTinder.DataHandling
{
    public class HandleUserData : BasePageViewModel
    {

        public static ObservableCollection<User> Users = new ObservableCollection<User>();
     
        public static ObservableCollection<Dish> MyDishes = new ObservableCollection<Dish>();

        public static ObservableCollection<FoodFilter> MyFoodFilter = new ObservableCollection<FoodFilter>();

        public static ObservableCollection<WeeklySchedule> WeeklySchedules = new ObservableCollection<WeeklySchedule>();
       


    }
}
