using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Chapter6_19
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
                new Person(new Name("Chris", "Anderson")),
                new Person(new Name("Don", "Box")),
                new Person(new Name("Chris", "Sells")),
                new Person(new Name("Bret", "Anderson")),
                new Person(new Name("Dave", "Sells")),
            };
            stackPanel.Children.Add(new TextBlock(new Run("変更なし")));
            var listBox = new ListBox()
            {
                DisplayMemberPath = "Name.Full",
                ItemsSource = names
            };
            stackPanel.Children.Add(listBox);

            stackPanel.Children.Add(new TextBlock(new Run("変更済み")));
            var modified = new ListBox();
            var view = new ListCollectionView(names);
            view.Filter = delegate (object item)
            {
                return (item as Person).Name.First != "Don";
            };
            view.SortDescriptions.Add(new SortDescription("Name.Last",ListSortDirection.Ascending));
            view.SortDescriptions.Add(new SortDescription("Name.First", ListSortDirection.Ascending));
            modified.DisplayMemberPath = "Name.Full";
            modified.ItemsSource = view;
            stackPanel.Children.Add(modified);
            Content = stackPanel;
        }
    }
}
