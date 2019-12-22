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

namespace TunoUI
{
    /// <summary>
    /// Interaction logic for TunoHome.xaml
    /// </summary>
    public partial class TunoHome : Page
    {
        public TunoHome()
        {
            InitializeComponent();
        }

        private void BtnNewItemPage_Click(object sender, RoutedEventArgs e)
        {
            // opens the new item page
            MainFrame.Navigate(new System.Uri("NewItemPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void BtnAllItemsPage_Click(object sender, RoutedEventArgs e)
        {
            // opens the inventory page
            MainFrame.Navigate(new System.Uri("AllItemsPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void BtnEditItemPage_Click(object sender, RoutedEventArgs e)
        {
            // opens the edit inventory page
            MainFrame.Navigate(new System.Uri("EditItemPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void BtnNewOrderPage_Click(object sender, RoutedEventArgs e)
        {
            // opens the new order page
            MainFrame.Navigate(new System.Uri("NewOrderPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void BtnMemberPage_Click(object sender, RoutedEventArgs e)
        {
            // opens the members page
            MainFrame.Navigate(new System.Uri("MemberPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void BtnNewMemberPage_Click(object sender, RoutedEventArgs e)
        {
            // opens the new member page
            MainFrame.Navigate(new System.Uri("NewMemberPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void BtnHelpPage_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new System.Uri("HelpPage.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
