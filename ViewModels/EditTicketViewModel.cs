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
using WpfApp.Views;

namespace WpfApp.ViewModels
{
    public class EditTicketViewModel : NotifyPropertyChangedBase
    {
       
       

        private readonly TicketService _ticketService;
        private Ticket _ticket;
        public ICommand SaveCommand { get; }

        public Ticket Ticket
        {
            get
            {
                return _ticket;
            }
            set
            {
               
                Set(ref _ticket, value);
            }
        }

        public bool IsOpen
        {
            get
            {
                return Ticket.Status == "Open";
            }
            set
            {
                //if (value)
                //{
                //    Ticket.Status = "Open";
                //}
                //OnPropertyChanged(nameof(IsOpen));
                //OnPropertyChanged(nameof(IsInProgress));
                //OnPropertyChanged(nameof(IsClosed));

                if (Ticket.Status != "Open")
                {
                    var updatedTicket = Ticket;
                    updatedTicket.Status = "Open";
                    Set(ref _ticket, updatedTicket); // Update entire Ticket object
                    RaisePropertyChanged(nameof(IsOpen));
                    RaisePropertyChanged(nameof(IsInProgress));
                    RaisePropertyChanged(nameof(IsClosed));
                    RaisePropertyChanged(nameof(IsOpenEnabled));
                }
            }
        }

        public bool IsInProgress
        {
            get
            {
                return Ticket.Status == "In Progress";
            }
            set
            {
                //if(value)
                //{
                //    Ticket.Status = "In Progress";
                //}
                //OnPropertyChanged(nameof(IsInProgress));
                //OnPropertyChanged(nameof(IsOpen));
                //OnPropertyChanged(nameof(IsClosed));
                //OnPropertyChanged(nameof(IsOpenEnabled));

                if (Ticket.Status != "In Progress")
                {
                    var updatedTicket = Ticket;
                    updatedTicket.Status = "In Progress";
                    Set(ref _ticket, updatedTicket); // Update entire Ticket object
                    RaisePropertyChanged(nameof(IsInProgress));
                    RaisePropertyChanged(nameof(IsOpen));
                    RaisePropertyChanged(nameof(IsClosed));
                    RaisePropertyChanged(nameof(IsOpenEnabled));
                }
            }
        }

        public bool IsOpenEnabled
        {
            get
            {
                return Ticket.Status != "In Progress"; // Disable if "In Progress" is selected
            }
        }

        public bool IsClosed
        {
            get
            {
                return Ticket.Status == "Closed";
            }
            set
            {
                //if(value)
                //{
                //    Ticket.Status = "Closed";
                //}
                //OnPropertyChanged(nameof(IsClosed));
                //OnPropertyChanged(nameof(IsOpen));
                //OnPropertyChanged(nameof(IsInProgress));

                if (Ticket.Status != "Closed")
                {
                    var updatedTicket = Ticket;
                    updatedTicket.Status = "Closed";
                    Set(ref _ticket, updatedTicket); // Update entire Ticket object
                    RaisePropertyChanged(nameof(IsClosed));
                    RaisePropertyChanged(nameof(IsOpen));
                    RaisePropertyChanged(nameof(IsInProgress));
                    RaisePropertyChanged(nameof(IsOpenEnabled));
                }
            }
        }


        public EditTicketViewModel(Ticket ticket)
        {
            _ticketService = new TicketService();
            Ticket = ticket;
            
            SaveCommand = new RelayCommand(SaveTicket, CanSaveTicket);
            if (IsClosed)
            {
                MainWindow mainWindow = new MainWindow(Ticket.UserId);
                mainWindow.Show();
            }
        }

        private bool CanSaveTicket(object obj)
        {
            
            
            return true;
        }

        private async void SaveTicket(object obj)
        {
            await _ticketService.UpdateTicketStatus(Ticket.Id, Ticket.Status);

            if(obj is Window EditTicket)
            {
                EditTicket.Close();
            }
            MainWindow mainWindow = new MainWindow(Ticket.UserId);
            mainWindow.Show();

           
        }

       
    }
}
