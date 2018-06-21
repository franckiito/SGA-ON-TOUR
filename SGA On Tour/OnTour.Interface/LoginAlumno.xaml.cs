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

namespace OnTour.Interface
{
    /// <summary>
    /// Lógica de interacción para LoginAlumno.xaml
    /// </summary>
    public partial class LoginAlumno : Window
    {
        public LoginAlumno()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, RoutedEventArgs e)
        {
            string user, clave;
            user = TxtNombre.Text;
            clave = TxtClave.Text;


        }
    }
}
