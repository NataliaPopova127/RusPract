using Pract2.View.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Pract2.View
{
    /// <summary>
    /// Логика взаимодействия для DashboardWindow.xaml
    /// </summary>
    public partial class DashboardWindow : Window
    {
        public DashboardWindow()
        {
            InitializeComponent();
        }

        private void btnClient_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new ClientPage());
        }

        private void btnManager_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new ManagerPage());
        }

        private void btnAdmin_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new AdminPage());
        }
    }
}
