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

namespace begunBezikov
{
    /// <summary>
    /// Логика взаимодействия для BegunMenu.xaml
    /// </summary>
    public partial class BegunMenu : Page
    {
        public BegunMenu()
        {
            InitializeComponent();
        }

        private void MarReg(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MarReg());
        }

        private void MyResi(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Reziki());
        }

        private void ProfEdit(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditBegun());
        }

        private void Sponsori(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Sponsorshit());
        }

        private void Mobila(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }

        private void Nothing(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Здесь никого нету");
        }
    }
}
