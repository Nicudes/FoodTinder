using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FoodTinder.View;

namespace FoodTinder
{
    public partial class App : Application
    {
        public static double ScreenHeight;
        public static double ScreenWidth;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
