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

namespace Chapter3_36
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.MouseMove += ToolTipOnMouseMove;
        }

        private void ToolTipOnMouseMove(object sender, MouseEventArgs e)
        {
            var hit = VisualTreeHelper.HitTest(this, e.GetPosition(this)) as PointHitTestResult;
            if (hit != null && hit.VisualHit != null)
            {
                ToolTip1.Content = hit.VisualHit.ToString();
                ToolTip1.PlacementRectangle = new Rect(e.GetPosition(this), new Size(0, 0));
            }
        }
    }
}
