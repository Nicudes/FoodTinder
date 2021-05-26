using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodTinder.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FoodTinder.DataHandling;
using FoodTinder.ViewModel;
using System.Collections.ObjectModel;
using SQLite;

namespace FoodTinder.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new HandleUserData();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            AppStartup();
            UserAdd.ItemsSource = HandleUserData.Users;

        }

        private void Swipe_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SwipePage());
        }

        private void Add_Dish_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddDishesPage());
        }

        private void Weekly_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WeeklySchedulePage());

        }

        private void Preference_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FoodPreferencePage());

        }

        private void Edit_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UserPage());

        }


        public void GetUsers()
        {

            SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);
            conn.CreateTable<User>();
            var SqliteUsers = conn.Table<User>().ToList();
            conn.Close();

            foreach (var i in SqliteUsers)
            {
                HandleUserData.Users.Add(i);
            }
        }

        public void GetDishes()
        {
            SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);
            conn.CreateTable<Dish>();
            var SqliteDishes = conn.Table<Dish>().ToList();
            conn.Close();

            foreach (var i in SqliteDishes)
            {
                HandleUserData.MyDishes.Add(i);
            }
        }

        public void GetFoodFilter()
        {
            SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);
            conn.CreateTable<FoodFilter>();
            var SqliteFoodFilter = conn.Table<FoodFilter>().ToList();
            conn.Close();

            foreach (var i in SqliteFoodFilter)
            {
                HandleUserData.MyFoodFilter.Add(i);
            }
        }

        public void GetWeeklySchedule()
        {
            SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);
            conn.CreateTable<WeeklySchedule>();
            var SqliteSchedules = conn.Table<WeeklySchedule>().ToList();
            conn.Close();

            foreach (var i in SqliteSchedules)
            {
                HandleUserData.WeeklySchedules.Add(i);
            }
        }

        public void CheckIfFirstCreationIsTrue()
        {
            SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);
            conn.CreateTable<UserAuth>();
            var SqliteAuthDone = conn.Table<UserAuth>().ToList();
            conn.Close();

            foreach (var i in SqliteAuthDone)
            {
                HandleUserData.FirstCreation.Add(i);
            }
        }

        public void AppStartup()
        {
            GetUsers();
            GetDishes();
            GetFoodFilter();
            GetWeeklySchedule();
            CheckIfFirstCreationIsTrue();

            if (HandleUserData.FirstCreation.Any())
            {
                MenuView.IsVisible = true;
                AddUserStack.IsVisible = false;
            }
            else
            {
                AddUserStack.IsVisible = true;
                MenuView.IsVisible = false;
            }

        }

        private void AddUser_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddUserPage());

        }

        private void ConfirmUsers_Clicked(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);
            conn.CreateTable<User>();
            int rows = 0;
            foreach (var i in HandleUserData.Users)
            {
                rows = conn.Insert(i);
            }
            
            conn.Close();

            if (rows > 0)
            {
                DisplayAlert("Success", "User successfully added", "ok");
                SetUserFirstCreationToTrue();
                MenuView.IsVisible = true;
                AddUserStack.IsVisible = false;
            }
            else
            {
                DisplayAlert("Failure", "Failed to add users", "ok");
            }
        }

        void SetUserFirstCreationToTrue()
        {
            UserAuth userAuth = new UserAuth()
            {
                IsUserCreated = true
            };

            HandleUserData.FirstCreation.Add(userAuth);

            SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);
            conn.CreateTable<UserAuth>();
            foreach (var i in HandleUserData.FirstCreation)
            {
                conn.Insert(i);
            }
        }




        //INSERT DISH
        //SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);
        //conn.CreateTable<Dish>();
        //int rows = conn.Insert(_dish);
        //conn.Close();








    }
}