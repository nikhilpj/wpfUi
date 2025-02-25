using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp.ViewModels;

namespace WpfApp.Pages
{
    /// <summary>
    /// Interaction logic for AddTicket.xaml
    /// </summary>
    public partial class AddTicket : Page
    {
        private Frame _mainFrame;
        private int _userId;
        public AddTicket(Frame mainFrame,int userId)
        {
            InitializeComponent();
            _mainFrame = mainFrame;
            _userId = userId;
            DataContext = new AddTicketViewModel(_mainFrame,_userId);
        }
        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            _mainFrame.GoBack(); // Navigate back to MainPage
        }
    }
}
