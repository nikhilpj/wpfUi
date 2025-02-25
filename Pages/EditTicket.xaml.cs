﻿using System;
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
    /// Interaction logic for EditTicket.xaml
    /// </summary>
    public partial class EditTicket : Page
    {
        private Frame _mainFrame;
        public EditTicket(Frame mainFrame,Ticket ticket)
        {
            InitializeComponent();
            _mainFrame = mainFrame;
            DataContext = new EditTicketViewModel(_mainFrame,ticket);
        }

        //private void Save_Click(object sender, RoutedEventArgs e)
        //{
        //    _mainFrame.GoBack(); // Navigate back to MainPage
        //}
    }
}
