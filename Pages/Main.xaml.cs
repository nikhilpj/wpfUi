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
using WpfApp.Models;
using WpfApp.ViewModels;

namespace WpfApp.Pages
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        private Frame _mainFrame;
        private int _userId;
        public Main(Frame mainFrame,int userId)
        {
            InitializeComponent();
            _mainFrame = mainFrame;
            _userId = userId;
            DataContext = new MainViewModel(_userId);
        }

        private void AddTicket_click(object sender, RoutedEventArgs e)
        {
            _mainFrame.Navigate(new AddTicket(_mainFrame, _userId));
        }

        private void EditTicket_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Tag is Ticket ticket)
            {
                _mainFrame.Navigate(new EditTicket(_mainFrame, ticket));
            }
        }
    }
}
