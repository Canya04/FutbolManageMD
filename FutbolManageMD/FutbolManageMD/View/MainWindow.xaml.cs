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
using System.Runtime.InteropServices;
using System.Windows.Interop;

namespace FutbolManageMD
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Funció per a poder arrossegar la finestra
        private void pnlBarraControl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WindowInteropHelper helper = new WindowInteropHelper(this);
            SendMessage(helper.Handle, 161, 2, 0);
        }

        //Funció per actualitzar l'alt màxim de la finestra en cas que l'usuari utilitzi més d'un monitor amb diferents resolucions
        private void pnlBarraControl_MouseEnter(object sender, MouseEventArgs e)
        {
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }

        //Funció per a tancar el programa
        private void botoTancar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        //Funció per a fer gran la pestanya
        private void botoMaximitzar_Click(object sender, RoutedEventArgs e)
        {
            //Si la pestanya està en la mida normal el fem gran
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            //Si no el posem a la mida normal
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }

        //Funció per a minimitzar la pestanya
        private void botoMinimitzar_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
