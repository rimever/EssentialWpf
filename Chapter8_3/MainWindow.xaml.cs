using System;
using System.Collections;
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

namespace Chapter8_3
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

        private void CheckBox1_OnChecked(object sender, RoutedEventArgs e)
        {
            var resourceDictionary = new ResourceDictionary();
            foreach (DictionaryEntry dictionaryEntry in Resources)
            {
                resourceDictionary[dictionaryEntry.Key] = dictionaryEntry.Value;
            }

            if (CheckBox1.IsChecked == false)
            {
                var theme = Application.LoadComponent(new Uri
                    ("DefaultButtons.xaml", UriKind.Relative)) as ResourceDictionary;
                resourceDictionary.MergedDictionaries.Add(theme);
            }
            else
            {
                var theme = Application.LoadComponent(new Uri
                    ("CustomButtons.xaml", UriKind.Relative)) as ResourceDictionary;
                resourceDictionary.MergedDictionaries.Add(theme);
            }

            Resources = resourceDictionary;
        }
    }
}
