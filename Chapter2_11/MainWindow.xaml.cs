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

namespace Chapter2_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowMethod(object sender, RoutedEventArgs e)
        {
            Window window = new Window {Title = "Show"};
            window.Show();
        }

        private void UserVisibilityProperty(object sender, RoutedEventArgs e)
        {
            var window = new Window {Title = "Visibility = Visible"};
            window.Visibility = Visibility.Visible;
        }

        private void ShowDialogMethod(object sender, RoutedEventArgs e)
        {
            Window window = new Window
            {
                Title = "ShowDialog",
                Owner = this,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                ShowInTaskbar = false
            };
            window.ShowDialog();
        }
    }
}
