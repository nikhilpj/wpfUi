using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Generic;

namespace WpfApp.Models
{
    public  class Ticket: NotifyPropertyChangedBase
    {
        private int _id;
        private int _userId;
        private string _title;
        private string _description;
        private string _status;
        public int Id { get {
            return _id;
            }

            set
            {
               
                Set(ref _id, value);
            }
        
        }
            
        public int UserId { get; set; }
        public string Title { get {
                return _title;
            }
            set
            {
               
                Set(ref _title, value);
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
            }
        }
        public string Status
        {
            get
            { 
                return _status; 
            }
        
            set
            {
                _status = value;
                //OnPropertyChanged(nameof(Status));
            }
        }

        public bool isEditable
        {
            get
            {
                return Status != "Closed";
            }
        }

    }
}
