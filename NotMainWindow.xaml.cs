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
            Frame MainFR = new Frame();
            MainFR.Navigate(new RegAsRun());
        }
    }
}
