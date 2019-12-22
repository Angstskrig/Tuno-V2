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
    /// Interaction logic for LagerbeholdningSide.xaml
    /// </summary>
    public partial class InventoryPage : Page
    {
        public InventoryPage()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            // back to home
            TunoHome tunoHome = new TunoHome();
            this.NavigationService.Navigate(tunoHome);
        }

        private void BtnAll_Click(object sender, RoutedEventArgs e)
        {
            // navigate to the All Items Page
            AllItemsPage allItemsPage = new AllItemsPage();
            this.NavigationService.Navigate(allItemsPage);
        }
    }
}
