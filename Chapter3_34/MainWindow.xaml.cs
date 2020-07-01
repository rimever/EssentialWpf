#region

using System.Windows;
using System.Windows.Controls;
using System.Windows.Ink;

#endregion

namespace Chapter3_34
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InkCanvas.SetEnabledGestures(new[] {ApplicationGesture.AllGestures});
        }

        private void InkCanvas_OnGesture(object sender, InkCanvasGestureEventArgs e)
        {
            ListBox1.Items.Add(e.GetGestureRecognitionResults()[0].ApplicationGesture);
        }
    }
}