using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodTinder.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FoodTinder.DataHandling;
using System.Collections.ObjectModel;
using SQLite;

namespace FoodTinder.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        private static int _numberOfUsers;
        public ObservableCollection<User> Users = new ObservableCollection<User>();


        public MainPage()
        {
            InitializeComponent();

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //Users.Add(new User() { Name = "Huy", IsAdult = true, NumberOfPowerUps = 2 });
            //Users.Add(new User() { Name = "Fia", IsAdult = true, NumberOfPowerUps = 2 });
            //Users.Add(new User() { Name = "Molly", IsAdult = false, NumberOfPowerUps = 2 });

            UserAdd.ItemsSource = Users;
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

        HandleUserData HandleData = new HandleUserData();

        private void userNumberConfirm_Clicked(object sender, EventArgs e)
        {
            //try
            //{
            //   HandleData.setNumberOfUsers(Convert.ToInt32(NumberOfUsers.Text));

            //}
            //catch (Exception)
            //{
            //    DisplayAlert("Invalid input", "Please choose a valid number", "Ok");
            //}
            //if (HandleData.NumberOfUsers > 0)
            //{
            //    NumberOfUsers.IsVisible = false;
            //    userNumberConfirm.IsVisible = false;
            //}
            //else
            //{
            //    DisplayAlert("Invalid input", "Please choose a valid number", "Ok");

            //}

            User _user = new User() {
                Name = NumberOfUsers.Text,
                IsAdult = true,
                NumberOfPowerUps = 2};

            SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);
            conn.CreateTable<User>();
            int rows = conn.Insert(_user);
            conn.Close();

            Users.Add(_user);

            if (rows > 0)
            {
                DisplayAlert("Success", "Added", "ok");
            }
        }





    }
}