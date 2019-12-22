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
using System.Data.SQLite;


namespace TunoUI
{
    /// <summary>
    /// Interaction logic for MedlemSide.xaml
    /// </summary>
    public partial class MemberPage : Page
    {
        List<MemberModel> members = new List<MemberModel>();
        public MemberPage()
        {
            InitializeComponent();
            GetMemberList();
        }
        
        private void GetMemberList()
        {
            members = SQLiteDataAccess.GetMember();

            listViewMembers.ItemsSource = members;
        }
        

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            // back to home
            TunoHome tunoHome = new TunoHome();
            this.NavigationService.Navigate(tunoHome);
        }

        private void BtnNewMemberPage_Click(object sender, RoutedEventArgs e)
        {
            // opens the NewMemberPage
            NewMemberPage newMemberPage = new NewMemberPage();
            this.NavigationService.Navigate(newMemberPage);
        }

       
    }
}
