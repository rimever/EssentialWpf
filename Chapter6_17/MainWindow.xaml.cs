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

namespace Chapter6_17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var stackPanel = new StackPanel();
            var names = new Person[]
            {
                new Person()
                {
                    Name = new Name()
                    {
                        First = "Chris", 
                        Last = "Anderson"
                    }
                },
                new Person()
                {
                    Name = new Name()
                    {
                        First = "Don",
                        Last = "Box"
                    }
                },
                new Person()
                {
                    Name = new Name()
                    {
                        First = "Chris",
                        Last = "Sells"
                    }
                },
            };
            var listBox = new ListBox()
            {
                IsSynchronizedWithCurrentItem = true,
                DisplayMemberPath = "Name.Full",
                ItemsSource = names
            };
            var selected = new TextBlock()
            {
                FontSize = 24
            };
            var text = new Binding
            {
                Source = names,
                Path = new PropertyPath("Name.Full"),
            };
            selected.SetBinding(TextBlock.TextProperty, text);
            stackPanel.Children.Add(listBox);
            stackPanel.Children.Add(selected);
            Content = stackPanel;
        }
    }
}
