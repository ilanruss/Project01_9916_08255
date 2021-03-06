﻿using BL;
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

namespace PLWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            IBL myBL;
           
        }
        private void guestRequestButton_Click(object sender, RoutedEventArgs e)
        {
            Window GuestRequestWindow = new GuestRequest();
            GuestRequestWindow.Show();

            this.Close();
        }
        private void Close_Button(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void עברית(object sender, RoutedEventArgs e)
        {
            Window mainWindowHeberew = new GuestRequest();
            mainWindowHeberew.Show();

            this.Close();
        }
        private void hostingUnitButton_Click(object sender, RoutedEventArgs e)
        {
            Window addHostingUnitWindow = new HostWindow();
            addHostingUnitWindow.Show();
            this.Close();

        }
        private void orderButton_Click(object sender, RoutedEventArgs e)
        {
            Window addOrderWindow = new Order();
            addOrderWindow.Show();
            this.Close();

        }
    }
}
