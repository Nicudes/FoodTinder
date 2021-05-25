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
    public partial class AddUserPage : ContentPage
    {
        public AddUserPage()
        {
            InitializeComponent();
        }

        private void Adult_Switch_Toggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                AdultOrNot.Text = "Adult";
            }
            else if(!e.Value)
            {
                AdultOrNot.Text = "Child";
            }
        }

        private void Add_User_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}