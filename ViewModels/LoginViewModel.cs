using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;
using WpfApp.Commands;
using WpfApp.Generic;
using WpfApp.Models;
using WpfApp.Pages;
using WpfApp.Services;

namespace WpfApp.ViewModels
{
    public class LoginViewModel : NotifyPropertyChangedBase
    {
        private string _username;
        private string _password;
        private string _statusMessage;
        private Login _loginPage;
       
      
        private readonly TicketService _ticketService;
        public ICommand LoginCommand { get; set; }

        public string UserName
        {
            get
            {
                return _username;
            }
            set
            {
                
                Set(ref _username, value);
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                
                Set(ref _password, value);
            }
        }

        public string StatusMessage
        {
            
            set
            {
               
                Set(ref _statusMessage, value);
            }
        }

        public LoginViewModel(Login loginPage)
        {
            _loginPage = loginPage;
            _ticketService = new TicketService();
           
            LoginCommand = new RelayCommand(LoginUser, CanLoginUser);
           
        }

        private bool CanLoginUser(object obj)
        {
            return true;
        }

        private async void LoginUser(object obj)
        {

            
            var user = new User
            {
                UserName = UserName,
                Password = Password
            };
            var exUser =await _ticketService.LoginUser(user);

            if (exUser != null)
            {
                MessageBox.Show("login sucess");
                StatusMessage = "Login Successfull";
                _loginPage.NavigateToMain(1);

            }
            else
            {
                MessageBox.Show("login not sucess");
                StatusMessage = "Invalid username or password";
            }
        }

       


       
    }
}
