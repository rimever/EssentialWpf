using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace ChapterA_1
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

        private void DownloadNormally(object sender, RoutedEventArgs e)
        {
            var webClient = new WebClient();
            webClient.DownloadStringCompleted += delegate(object o, DownloadStringCompletedEventArgs args)
            {
                TextBox1.Text = args.Result;
            };
            webClient.DownloadStringAsync(new Uri("https://www.msn.com"));
        }
    }
}
