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
    /// Логика взаимодействия для MarReg.xaml
    /// </summary>
    public partial class MarReg : Page
    {
        public MarReg()
        {
            InitializeComponent();
        }

        private void Da1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Спасибо за вашу регистрацию на марафоне Marathon skills 2016! С вами свяжутся по поводу оплаты");
            NavigationService.Navigate(new BegunMenu());
        }

        private void Net1(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
