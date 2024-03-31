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
using System.Windows.Shapes;

namespace begunBezikov
{
    /// <summary>
    /// Логика взаимодействия для NotMainWindow.xaml
    /// </summary>
    public partial class NotMainWindow : Window
    {
        public NotMainWindow()
        {
            InitializeComponent();
            MainFR.Content = new RegAsRun();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MainFR.CanGoBack) { MainFR.GoBack(); }
            else 
            {
                MainWindow yes = new MainWindow();
                yes.Show();
                Close(); 
            }
        }
    }
}
