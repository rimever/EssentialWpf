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

namespace Chapter5_25
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

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var bitmap = new RenderTargetBitmap(
                (int)RichTextBox1.ActualWidth,
                (int)RichTextBox1.ActualHeight,
                96,96,
                PixelFormats.Pbgra32);
            bitmap.Render(RichTextBox1);
            Image1.Source = bitmap;
        }
    }
}
