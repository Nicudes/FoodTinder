using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodTinder.DataHandling;
using FoodTinder.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodTinder.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddUserPage : ContentPage
    {
        public AddUserPage()
        {
            InitializeComponent();
        }

        bool _isAdult;

        private void Adult_Switch_Toggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                AdultOrNot.Text = "Adult";
                _isAdult = true;
            }
            else if(!e.Value)
            {
                AdultOrNot.Text = "Child";
                _isAdult = false;
            }
        }

        private void Add_User_Clicked(object sender, EventArgs e)
        {
            User user = new User()
            {
                Name = NameEntry.Text,
                IsAdult = _isAdult
            };

            HandleUserData.Users.Add(user);
            Navigation.PopAsync();

        }
    }
}