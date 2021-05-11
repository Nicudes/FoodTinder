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
    public partial class WeeklySchedulePage : ContentPage
    {
        public WeeklySchedulePage()
        {
            BindingContext = new SwipePageViewModel();

            InitializeComponent();
        }
    }
}