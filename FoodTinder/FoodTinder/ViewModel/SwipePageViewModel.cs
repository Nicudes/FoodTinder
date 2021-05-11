using MLToolkit.Forms.SwipeCardView.Core;
using FoodTinder.Model;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace FoodTinder.ViewModel
{
    class SwipePageViewModel : BasePageViewModel
    {
        private ObservableCollection<Dish> _dishes = new ObservableCollection<Dish>();

        private uint _threshold;

        public SwipePageViewModel()
        {
            InitializeProfiles();

            Threshold = (uint)(App.ScreenWidth / 3);

            SwipedCommand = new Command<SwipedCardEventArgs>(OnSwipedCommand);
            DraggingCommand = new Command<DraggingCardEventArgs>(OnDraggingCommand);

            ClearItemsCommand = new Command(OnClearItemsCommand);
            AddItemsCommand = new Command(OnAddItemsCommand);
        }

        public ObservableCollection<Dish> Dishes
        {
            get => _dishes;
            set
            {
                _dishes = value;
                RaisePropertyChanged();
            }
        }

        public uint Threshold
        {
            get => _threshold;
            set
            {
                _threshold = value;
                RaisePropertyChanged();
            }
        }

        public ICommand SwipedCommand { get; }

        public ICommand DraggingCommand { get; }

        public ICommand ClearItemsCommand { get; }

        public ICommand AddItemsCommand { get; }

        private void OnSwipedCommand(SwipedCardEventArgs eventArgs)
        {
        }

        private void OnDraggingCommand(DraggingCardEventArgs eventArgs)
        {
            switch (eventArgs.Position)
            {
                case DraggingCardPosition.Start:
                    return;

                case DraggingCardPosition.UnderThreshold:
                    break;

                case DraggingCardPosition.OverThreshold:
                    break;

                case DraggingCardPosition.FinishedUnderThreshold:
                    return;

                case DraggingCardPosition.FinishedOverThreshold:
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void OnClearItemsCommand()
        {
            Dishes.Clear();
        }

        private void OnAddItemsCommand()
        {
        }

        private void InitializeProfiles()
        {

            Dishes.Add(new Dish() { Name = "Taco", Type = "Mexican", Photo = "Taco.jpg" });
            Dishes.Add(new Dish() { Name = "Burger", Type = "American", Photo = "BurgerAndFries.jpg" });
            Dishes.Add(new Dish() { Name = "Sushi", Type = "Japanese", Photo = "Sushi.jpg" });
            Dishes.Add(new Dish() { Name = "Pho", Type = "Vietnamese", Photo = "Pho.jpg" });
        }
    }
}
