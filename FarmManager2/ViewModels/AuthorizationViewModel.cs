using FarmManager2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManager2.ViewModels
{
    internal class AuthorizationViewModel : ViewModelBase
    {
        public static User User { get; private set; }
        public string Role { get; set; }
        public AuthorizationViewModel() 
        {
            Title = "Авторизация";
        }
        public IGettingPassword GettingPassword { private get; set; }
        
        private string Password
        {
           get => GettingPassword?.GetPassword();
        }
        //public bool LogIn()
        //{
          //  try
            //{
                
            //}
        //}
    }
}
