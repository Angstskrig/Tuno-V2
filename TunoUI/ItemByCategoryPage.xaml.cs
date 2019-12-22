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
    /// Interaction logic for ItemByCategoryPage.xaml
    /// </summary>
    public partial class ItemByCategoryPage : Page
    {
        private List<TypeModel> typer;
        public ItemByCategoryPage()
        {
            InitializeComponent();
            BindComboBox(comboBoxSelectCategory);
        }
        public void BindComboBox(ComboBox comboBoxVareType)
        {
            typer = SQLiteDataAccess.GetType();
            comboBoxVareType.ItemsSource = typer;
        }

        List<ItemModel> items = new List<ItemModel>();

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            // back to home
            TunoHome tunoHome = new TunoHome();
            this.NavigationService.Navigate(tunoHome);
        }

        private void BtnViewSelectedItems_Click(object sender, RoutedEventArgs e)
        {
            string category = comboBoxSelectCategory.Text;
            items = SQLiteDataAccess.GetItemByCategory(category);

            listViewItemsByCategory.ItemsSource = items;
        }

        private void BtnAllItems_Click(object sender, RoutedEventArgs e)
        {
            items = SQLiteDataAccess.GetItem();
            listViewItemsByCategory.ItemsSource = items;
        }
    }
}
