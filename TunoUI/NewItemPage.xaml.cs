using HelperLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Interaction logic for NewItemPage.xaml
    /// </summary>
    public partial class NewItemPage : Page
    {
        private List<TypeModel> typer;

        public NewItemPage()
        {
            InitializeComponent();
            BindComboBox(comboBoxVareType);
        }
        
        // Bind the types of items from the db to the combobox. Calling GetType() to make a list of types.
        public void BindComboBox(ComboBox comboBoxVareType)
        {
            typer = SQLiteDataAccess.GetType();
            comboBoxVareType.ItemsSource = typer;
        }
        private void BtnSaveItem_Click(object sender, RoutedEventArgs e)
        {
            ItemModel i = new ItemModel();

            i.navn = textBoxVareNavn.Text;
            i.type = comboBoxVareType.Text;
            i.antal = int.Parse(textBoxAntal.Text);
            i.startAntal = i.antal;

            SQLiteDataAccess.SaveItem(i);

            textBoxVareNavn.Text = "";
            comboBoxVareType.Text = "";
            textBoxAntal.Text = "";
        }
    }
}
