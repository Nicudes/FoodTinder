using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodTinder.Model
{
    public class UserAuth
    {
        //Prep in case we want the app to be used online

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public bool IsUserCreated { get; set; }


    }
}
