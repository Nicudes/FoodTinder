using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodTinder.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodTinder.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddDishesPage : ContentPage
    {
        public AddDishesPage()
        {
            BindingContext = new SwipePageViewModel();
            InitializeComponent();
        }

        private void Add_Dish_Clicked(object sender, EventArgs e)
        {

        }

        private void UploadDishImage_Clicked(object sender, EventArgs e)
        {

        }

        private void My_Dishes_Clicked(object sender, EventArgs e)
        {

        }
    }
}