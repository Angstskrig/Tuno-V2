using HelperLibrary;
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
    /// Interaction logic for AllItemsPage.xaml
    /// </summary>
    public partial class AllItemsPage : Page
    {
        public AllItemsPage()
        {
            InitializeComponent();
            GetItemList();
            GetDrinksList();
            GetNonDrinksList();
        }

        List<ItemModel> items = new List<ItemModel>();
        private void GetItemList()
        {
            items = SQLiteDataAccess.GetItem();
            listViewAllItems.ItemsSource = items;
        }

        List<ItemModel> drinks = new List<ItemModel>();
        private void GetDrinksList()
        {
            drinks = SQLiteDataAccess.GetDrinks();
            listViewAllDrinks.ItemsSource = drinks;
        }

        List<ItemModel> nonDrinks = new List<ItemModel>();
        private void GetNonDrinksList()
        {
            nonDrinks = SQLiteDataAccess.GetNonDrinks();
            listViewAllNonDrinks.ItemsSource = nonDrinks;
        }

            private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            // back to home
            TunoHome tunoHome = new TunoHome();
            this.NavigationService.Navigate(tunoHome);
        }
    }
}
