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

namespace Number_Guessing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Random random = new Random();
        int number = 0;

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void generator(object sender, RoutedEventArgs e)
        {
            number = random.Next(0, 1000);
            Generatbox.Text = number.ToString();
        }

        private void again(object sender, RoutedEventArgs e)
        {
            Generatbox.Text = "";
        }
    }
}
