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

namespace Chapter2_13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static int _createCount;

        public MainWindow()
        {
            InitializeComponent();
            Title = "ウインドウ" + _createCount;
            _createCount++;
        }

        private void NewWindowClicked(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
        }

        private void ListOpenWindows(object sender, RoutedEventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Window window in Application.Current.Windows)
            {
                stringBuilder.AppendLine(window.Title);
            }

            MessageBox.Show(stringBuilder.ToString(), "Open Windows");
        }
    }
}
