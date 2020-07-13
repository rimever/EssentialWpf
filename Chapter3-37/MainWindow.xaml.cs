using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chapter3_37
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double _originalLeft;
        private double _originalTop;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Thumb1_OnDragStarted(object sender, DragStartedEventArgs e)
        {
            _originalLeft = Canvas.GetLeft(Thumb1);
            _originalTop = Canvas.GetTop(Thumb1);
        }

        private void Thumb1_OnDragDelta(object sender, DragDeltaEventArgs e)
        {
            double left = _originalLeft + e.HorizontalChange;
            double top = _originalTop + e.VerticalChange;
            Canvas.SetLeft(Thumb1,left);
            Canvas.SetTop(Thumb1,top);
            _originalLeft = left;
            _originalTop = top;
        }
    }
}
