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
using System.Windows.Shapes;

using MahApps.Metro.Controls;

namespace OnTour.Interface
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class Principal : MetroWindow
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
       

        private void Alumno_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new LoginAlumno();
            GridMain.Children.Clear();
            GridMain.Children.Add(usc);
        }

        private void Representante_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new LoginRepresentante();
            GridMain.Children.Clear();
            GridMain.Children.Add(usc);
        }

        private void Gerente_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new LoginGerente();
            GridMain.Children.Clear();
            GridMain.Children.Add(usc);
        }
    }
}
