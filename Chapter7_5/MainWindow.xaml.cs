using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

namespace Chapter7_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly RoutedCommand OpenCommand = new RoutedCommand("Open", typeof(MainWindow));

        public static readonly RoutedCommand BlockedCommand = new RoutedCommand("Blocked", typeof(MainWindow));

        public MainWindow()
        {
            InitializeComponent();
            var fileList = new DirectoryInfo("C:\\").GetFiles("*.*");
            ListBoxFiles.ItemsSource = fileList;
            CommandBindings.Add(new CommandBinding(OpenCommand, delegate(object sender, ExecutedRoutedEventArgs e)
            {
                Process.Start("notepad.exe", e.Parameter.ToString());
            }));
            CommandBindings.Add(new CommandBinding(BlockedCommand, delegate(object sender, ExecutedRoutedEventArgs e)
            {
                MessageBox.Show(e.Parameter.ToString(), "ブロックされました");
            }));
        }
    }
}
