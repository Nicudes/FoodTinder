using FoodTinder.Model;
using FoodTinder.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FoodTinder.DataHandling
{
    public class HandleUserData : BasePageViewModel
    {


        private int _numberOfUsers;
        public int NumberOfUsers
        {
            get { return _numberOfUsers; }
            set { _numberOfUsers = value;
                RaisePropertyChanged();
            }
        }


        public ObservableCollection<User> _users = new ObservableCollection<User>();
        public ObservableCollection<User> Users
        {
            get { return _users; }
            set { _users = value;
                RaisePropertyChanged();
            }
        }

       public void setNumberOfUsers(int NumOfUsers)
        {
              _numberOfUsers = NumOfUsers;

            Users.Add(new User() { Name = "Huy", IsAdult = true, NumberOfPowerUps = 2 });
            Users.Add(new User() { Name = "Fia", IsAdult = true, NumberOfPowerUps = 2 });
            Users.Add(new User() { Name = "Molly", IsAdult = false, NumberOfPowerUps = 2 });

        }


    }
}
