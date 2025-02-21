using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp.Commands;
using WpfApp.Generic;
using WpfApp.Models;

using WpfApp.Services;

namespace WpfApp.ViewModels
{
    public class AddTicketViewModel : NotifyPropertyChangedBase
    {
        private readonly TicketService _ticketService;

      

        private string _title;
        private string _description;
        private int _userId;
        private string _statusMessage;
        public ICommand SubmitCommand { get; }


        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
               
                Set(ref _title, value);
                ((RelayCommand)SubmitCommand).RaiseCanExecuteChanged();
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
              
                Set(ref _description, value);
                ((RelayCommand)SubmitCommand).RaiseCanExecuteChanged();
            }
        }

        public string StatusMessage
        {
            get
            {
                return _statusMessage;
            }
            set
            {
               
                Set(ref _statusMessage, value);
            }
        }

        public AddTicketViewModel(int userId)
        {
            _userId = userId;
            _ticketService = new TicketService();
            SubmitCommand = new RelayCommand(SubmitTicket,CanSubmitTicket);
        }

        private bool CanSubmitTicket(object obj)
        {
            return !string.IsNullOrWhiteSpace(Title) && !string.IsNullOrWhiteSpace(Description);
           
        }

        private async void SubmitTicket(object obj)
        {
            var newTicket = new Ticket
            {
                UserId = _userId,
                Title = Title,
                Description = Description,
                Status = "Open"
            };

            bool isSucess = await _ticketService.CreateTicket(newTicket);
            if (isSucess)
            {
                StatusMessage = "Ticket added successfully";
                MessageBox.Show(StatusMessage);

                Application.Current.Windows[1].Close();
                MainWindow mainWindow = new MainWindow(_userId);
                mainWindow.Show();


            }
            else
            {
                StatusMessage = "error in adding Ticket";
                MessageBox.Show(StatusMessage);
                MainWindow mainWindow = new MainWindow(_userId);
                mainWindow.Show();

            }


        }

       
    }
}
