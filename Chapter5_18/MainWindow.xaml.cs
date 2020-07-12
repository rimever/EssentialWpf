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

namespace Chapter5_18
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var toShare = new GeometryDrawing(Brushes.Red, null, new EllipseGeometry(new Rect(2,2,15,15)));
            var main = new DrawingGroup();
            var a = new DrawingGroup();
            a.Children.Add(toShare);
            a.Transform = new TranslateTransform(8,8);

            var b = new DrawingGroup();
            b.Children.Add(toShare);
            b.Transform = new TranslateTransform(0,0);

            main.Children.Add(a);
            main.Children.Add(b);

            var brush = new DrawingBrush();
            brush.Drawing = main;
            brush.Viewport = new Rect(0,0,20,20);
            brush.ViewportUnits = BrushMappingMode.Absolute;
            brush.TileMode = TileMode.Tile;

            Rectangle.Fill = brush;
        }
    }
}
