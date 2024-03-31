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
    /// Логика взаимодействия для EditBegun.xaml
    /// </summary>
    public partial class EditBegun : Page
    {
        public EditBegun()
        {
            InitializeComponent();
            Paul.Items.Add("Мужской");
            Paul.Items.Add("Женский");
            Paul.Items.Add("Перфоратор");
            Country.Items.Add("СССР");
        }

        private void Yes2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new BegunMenu());
        }
    }
}
