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
    /// Interaction logic for NewMemberPage.xaml
    /// </summary>
    public partial class NewMemberPage : Page
    {
        public NewMemberPage()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            // back to home
            TunoHome tunoHome = new TunoHome();
            this.NavigationService.Navigate(tunoHome);
        }

        private void BtnGemNytMedlem_Click(object sender, RoutedEventArgs e)
        {
            // Gemmer det nye medlem i databasen!
            MemberModel m = new MemberModel();

            m.forNavn = forNavnTekst.Text;
            m.efterNavn = efterNavnTekst.Text;
            m.alias = aliasTekst.Text;
            m.mobil = mobilTekst.Text;
            m.email = emailTekst.Text;

            SQLiteDataAccess.SaveMember(m);

            forNavnTekst.Text = "";
            efterNavnTekst.Text = "";
            aliasTekst.Text = "";
            mobilTekst.Text = "";
            emailTekst.Text = "";

        }
    }
}
