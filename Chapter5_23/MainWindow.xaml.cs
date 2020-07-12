using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Chapter5_23
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "image.png");
            var frame = BitmapFrame.Create(new Uri(path));
            var crop = new CroppedBitmap();
            crop.BeginInit();
            crop.Source = frame;
            crop.SourceRect = new Int32Rect(100, 150, 400, 250);
            crop.EndInit();

            var color = new FormatConvertedBitmap();
            color.BeginInit();
            color.Source = crop;
            color.DestinationFormat = PixelFormats.BlackWhite;
            color.EndInit();

            var image = new Image();
            image.Source = color;
            Content = image;
            Title = "画像パイプライン";
            DumpMetadata(frame.Metadata);
        }

        public void DumpMetadata(object v)
        {
            var metadata = v as BitmapMetadata;
            if (metadata != null)
            {
                foreach (var name in metadata)
                {
                    Debug.WriteLine(name);
                    Debug.IndentLevel++;
                    DumpMetadata(metadata.GetQuery(name));
                    Debug.IndentLevel--;
                }
            }
            else
            {
                Debug.WriteLine("value: " + v);
            }
        }
    }
}
