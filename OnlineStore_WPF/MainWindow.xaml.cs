using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace OnlineStore_WPF
{

    public partial class MainWindow : Window
    {



        public MainWindow()
        {
            InitializeComponent();
        }

        private void basketButton_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window();
            window.Width = 300;
            window.Height = 300;
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Show();
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
          

        }





    }
}
