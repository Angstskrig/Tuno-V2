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
    /// Interaction logic for OpdaterVareSide.xaml
    /// </summary>
    public partial class EditItemPage : Page
    {
        public EditItemPage()
        {
            InitializeComponent();
            BindComboBox(comboBoxVareValg);
        }
        private List<ItemModel> varenavne;
        public void BindComboBox(ComboBox comboBoxVareValg)
        {
            varenavne = SQLiteDataAccess.GetItemName();
            comboBoxVareValg.ItemsSource = varenavne;
        }
        private void BtnOpdaterVare_Click(object sender, RoutedEventArgs e)
        {
            string navn = comboBoxVareValg.SelectedValue.ToString();
            int nytAntal = int.Parse(textBoxNytAntal.Text);

            SQLiteDataAccess.UpdateItem(navn, nytAntal);
            BindComboBox(comboBoxVareValg);

            comboBoxVareValg.Text = "";
            textBoxNytAntal.Text = "";

        }
    }
}
