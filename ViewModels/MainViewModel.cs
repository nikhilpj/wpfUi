using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp.Generic;
using WpfApp.Models;
using WpfApp.Services;

namespace WpfApp.ViewModels
{
    public class MainViewModel : NotifyPropertyChangedBase
    {
        private readonly TicketService _ticketService;
        private readonly int _userId;
        private ObservableCollection<Ticket> _tickets;
        
        public ObservableCollection<Ticket> Tickets
        {
            get
            {
                return _tickets;
            }
            set
            {
                
                Set(ref _tickets, value);
            }
        }

       

        public MainViewModel(int userId)
        {
            _userId = userId;
            _ticketService = new TicketService();
            LoadTickets();
        }


        public async Task LoadTickets()
        {
            var tickets = await _ticketService.GetUserTickets(_userId);
            Tickets = new ObservableCollection<Ticket>(tickets);
        }


    }
}
