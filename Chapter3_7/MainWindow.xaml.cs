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

namespace Chapter3_7
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

        private void ChangeIt(object sender, RoutedEventArgs e)
        {
            ControlTemplate template = new ControlTemplate(typeof(Button))
            {
                VisualTree = new FrameworkElementFactory(typeof(Ellipse))
            };
            template.VisualTree.SetValue(Shape.FillProperty, Brushes.Blue);
            template.VisualTree.SetValue(WidthProperty, 75.0);
            template.VisualTree.SetValue(HeightProperty, 23.0);
            ((Button) sender).Template = template;
        }
    }
}
