using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ProjecteRobot
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public const int ROBOT_HEAD_WIDTH = 35;
        public const int ROBOT_HEAD_HEIGHT = 35;

        public const int TRESOR_HEAD_WIDTH = 55;
        public const int TRESOR_HEAD_HEIGHT = 55;

        SolidColorBrush brushRobot = new SolidColorBrush(Colors.White);
        SolidColorBrush brushTresor = new SolidColorBrush(Colors.Yellow);

        JocRobot joc;
        JocRobot tresor;
        DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();

            joc = new JocRobot();
            tresor = new JocRobot();
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = TimeSpan.FromSeconds(1);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //Pintar.
            canvas.Children.Clear();
            Ellipse ellipseRobot = new Ellipse()
            {
                Fill = brushRobot,
                Width = ROBOT_HEAD_WIDTH,
                Height = ROBOT_HEAD_HEIGHT
            };

            Ellipse ellipseTresor = new Ellipse()
            {
                Fill = brushTresor,
                Width = TRESOR_HEAD_WIDTH,
                Height = TRESOR_HEAD_HEIGHT
            };
            Canvas.SetTop(ellipseTresor, joc.Cap.Y * TRESOR_HEAD_HEIGHT);
            Canvas.SetLeft(ellipseTresor, joc.Cap.X * TRESOR_HEAD_WIDTH);
            canvas.Children.Add(ellipseTresor);

            Canvas.SetTop(ellipseRobot, joc.Cap.Y * ROBOT_HEAD_HEIGHT);
            Canvas.SetLeft(ellipseRobot, joc.Cap.X * ROBOT_HEAD_WIDTH);
            canvas.Children.Add(ellipseRobot);

            joc.MoureRobot();
        }

        private void btnIniciaJoc_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }
    }
}
