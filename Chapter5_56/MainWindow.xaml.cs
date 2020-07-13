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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chapter5_56
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var storyboard = new Storyboard();
            TextBlock1.TextEffects = new TextEffectCollection();
            for (int i = 0; i < TextBlock1.Text.Length; i++)
            {
                var effect = new TextEffect
                {
                    Transform = new TranslateTransform(), PositionStart = i, PositionCount = 1
                };
                TextBlock1.TextEffects.Add(effect);

                var animation = new DoubleAnimation
                {
                    To = 20,
                    AccelerationRatio = .2,
                    DecelerationRatio = .2,
                    RepeatBehavior = RepeatBehavior.Forever,
                    AutoReverse = true,
                    Duration = TimeSpan.FromSeconds(2),
                    BeginTime = TimeSpan.FromMilliseconds(250 * i)
                };
                Storyboard.SetTargetProperty(animation,new PropertyPath("TextEffects[" + i + "].Transform.Y"));
                Storyboard.SetTargetName(animation, TextBlock1.Name);
                storyboard.Children.Add(animation);
            }
            storyboard.Begin(this);
        }
    }
}
