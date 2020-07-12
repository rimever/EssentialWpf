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

namespace Chapter5_13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Title = "ビジュアルブラシ";
            var stackPanel = new StackPanel();
            var button = new Button();
            button.HorizontalAlignment = HorizontalAlignment.Left;
            button.VerticalAlignment = VerticalAlignment.Top;
            button.Content = "ここをクリック！";
            stackPanel.Children.Add(button);
            var rectangle = new Rectangle();
            rectangle.Margin = new Thickness(5);
            rectangle.Width = 200;
            rectangle.Height = 200;
            rectangle.Stroke = Brushes.Black;
            rectangle.StrokeThickness = 5;
            var visualBrush = new VisualBrush();
            visualBrush.Visual = button;
            visualBrush.TileMode = TileMode.Tile;
            visualBrush.Stretch = Stretch.Uniform;
            visualBrush.Viewport = new Rect(0,0,50,20);
            visualBrush.ViewportUnits = BrushMappingMode.Absolute;
            rectangle.Fill = visualBrush;
            stackPanel.Children.Add(rectangle);

            var rectangle2 = new Rectangle();
            rectangle2.Margin = new Thickness(5);
            rectangle2.Width = 500;
            rectangle2.Height = 200;
            rectangle2.Stroke = Brushes.Black;
            rectangle2.StrokeThickness = 5;
            var visualBrush2 = new VisualBrush();
            visualBrush2.Visual = button;
            rectangle2.Fill = visualBrush2;
            stackPanel.Children.Add(rectangle2);

            Content = stackPanel;
        }
    }
}
