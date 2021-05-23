using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodTinder.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodTinder.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {

        private static int _numberOfUsers;

        public List<User> _users = new List<User>(_numberOfUsers);
        public List<User> Users
        {
            get { return _users; }
            set { _users = value;}
        }



        public MainPage()
        {
            InitializeComponent();
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

        private void userNumberConfirm_Clicked(object sender, EventArgs e)
        {
            try
            {
                _numberOfUsers = Convert.ToInt32(NumberOfUsers.Text);

            }
            catch (Exception)
            {
                DisplayAlert("Invalid input", "Please choose a valid number", "Ok");
            }
            if (_numberOfUsers > 0)
            {
                NumberOfUsers.IsVisible = false;
                userNumberConfirm.IsVisible = false;
            }
            else
            {
                DisplayAlert("Invalid input", "Please choose a valid number", "Ok");

            }
        }



    }
}