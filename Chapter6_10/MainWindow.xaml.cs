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

namespace Chapter6_10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Person();
        }

        private void AddAddress(object sender, RoutedEventArgs e)
        {
            var address = new Address
            {
                City = TextBoxCity.Text,
                Province = TextBoxProvince.Text,
                Street = TextBoxStreet.Text,
                Zip = TextBoxZip.Text
            };
            (DataContext as Person)?.Addresses.Add(address);
        }
    }
}
