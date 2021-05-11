using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodTinder.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
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
    }
}