using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

namespace Chapter6_8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Person()
            {
                Name = new Name
                {
                    First = "山田",
                    Last = "太郎"
                },
                Addresses = new[]
                {
                    new Address()
                    {
                        AddressName = "会社",
                        Zip = "160-0006",
                        Province = "東京",
                        City = "新宿区",
                        Street = "船町5番"
                    }
                }
            };
        }

    }

    public class Person
    {
        public Name Name { get; set; }
        public Address[] Addresses { get; set; }
    }

    public class Address
    {
        public string AddressName { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
    }

    public class Name
    {
        public string First { get; set; }
        public string Last { get; set; }
        public string Full => First + " " + Last;
    }
}
