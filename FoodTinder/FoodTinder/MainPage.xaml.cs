using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FoodTinder
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<FoodProfile> _Profiles = new ObservableCollection<FoodProfile>();
        public MainPage()
        {
            InitializeComponent();
            CardBinding();
            BindingContext = this;
        }

        public void CardBinding()
        {
            _Profiles.Add(new FoodProfile(){ Name="Taco", Type="Mexican", Photo="Taco.jpg"});
            _Profiles.Add(new FoodProfile(){ Name="Burger and Fries", Type="American", Photo="BurgerAndFries.jpg"});
            _Profiles.Add(new FoodProfile(){ Name="Sushi", Type="Japanese", Photo="Sushi.jpg"});
            _Profiles.Add(new FoodProfile(){ Name="Pho", Type="Vietnamese", Photo="Pho.jpg"});
        }
        public ObservableCollection<FoodProfile> Profiles
        {
            get => _Profiles;
            set
            {
                _Profiles = value;
            }
        }

        public class FoodProfile
        {
            public string Name { get; set; }

            public string Type { get; set; }

            public string Photo { get; set; }
        }
    }
}
