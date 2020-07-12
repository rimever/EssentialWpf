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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chapter5_32
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Title = "3D";
            Viewport3D viewport = new Viewport3D();

            Model3DGroup group = new Model3DGroup();
            GeometryModel3D model = new GeometryModel3D();
            model.Geometry = CreateTriangle();
            model.Material = new DiffuseMaterial(Brushes.Red);
            group.Children.Add(model);

            PerspectiveCamera viewer = new PerspectiveCamera();
            viewer.LookDirection = new Vector3D(0, 0, -1);
            viewer.Position = new Point3D(0, 0, 12);
            viewer.FieldOfView = 45;
            viewer.UpDirection = new Vector3D(0, 1, 0);
            viewport.Camera = viewer;

            PointLight light = new PointLight();
            light.Position = new Point3D(12, 12, 12);
            light.Color = Colors.White;
            light.Range = 150;
            light.ConstantAttenuation = 1.0;
            group.Children.Add(light);

            ModelVisual3D scene = new ModelVisual3D();
            scene.Content = group;
            viewport.Children.Add(scene);
            Content = viewport;
        }

        private Geometry3D CreateTriangle()
        {
            var mesh = new MeshGeometry3D();
            mesh.Positions.Add(new Point3D(0, 0, 0));
            mesh.Positions.Add(new Point3D(1, 0, 0));
            mesh.Positions.Add(new Point3D(0, 1, 0));
            mesh.TriangleIndices.Add(0);
            mesh.TriangleIndices.Add(1);
            mesh.TriangleIndices.Add(2);
            return mesh;
        }
    }
}
