using System;
using MLToolkit.Forms.SwipeCardView.Core;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FoodTinder.Model;
using FoodTinder.ViewModel;
using MLToolkit.Forms.SwipeCardView;

namespace FoodTinder.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwipePage : ContentPage
    {
   
        public SwipePage()
        {
            InitializeComponent();
            BindingContext = new SwipePageViewModel();

            SwipeCardView.Dragging += OnDragging;
        }


        private void OnDislikeClicked(object sender, EventArgs e)
        {
            SwipeCardView.InvokeSwipe(SwipeCardDirection.Left);
        }

        private void OnSuperLikeClicked(object sender, EventArgs e)
        {
            SwipeCardView.InvokeSwipe(SwipeCardDirection.Up);
        }

        private void OnLikeClicked(object sender, EventArgs e)
        {
            SwipeCardView.InvokeSwipe(SwipeCardDirection.Right);
        }

        private void OnDragging(object sender, DraggingCardEventArgs e)
        {
            var view = (Xamarin.Forms.View)sender;
            var nopeFrame = view.FindByName<Frame>("NopeFrame");
            var likeFrame = view.FindByName<Frame>("LikeFrame");
            var superLikeFrame = view.FindByName<Frame>("SuperLikeFrame");
            var threshold = (BindingContext as SwipePageViewModel).Threshold;

            var draggedXPercent = e.DistanceDraggedX / threshold;

            var draggedYPercent = e.DistanceDraggedY / threshold;

            switch (e.Position)
            {
                case DraggingCardPosition.Start:
               
                    break;

                case DraggingCardPosition.UnderThreshold:
                    if (e.Direction == SwipeCardDirection.Left)
                    {
                      
                    }
                    else if (e.Direction == SwipeCardDirection.Right)
                    {
                       
                    }
                    else if (e.Direction == SwipeCardDirection.Up)
                    {
                  
                    }
                    break;

                case DraggingCardPosition.OverThreshold:
                    if (e.Direction == SwipeCardDirection.Left)
                    {
                      
                    }
                    else if (e.Direction == SwipeCardDirection.Right)
                    {
                     
                    }
                    else if (e.Direction == SwipeCardDirection.Up)
                    {
                    
                    }
                    break;

                case DraggingCardPosition.FinishedUnderThreshold:
           
                    break;

                case DraggingCardPosition.FinishedOverThreshold:
                
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

    }
}