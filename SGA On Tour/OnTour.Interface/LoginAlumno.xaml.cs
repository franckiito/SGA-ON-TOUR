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
    public partial class LoginAlumno : UserControl
    {
        public LoginAlumno()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, RoutedEventArgs e)
        {
            string rut, clave;
            rut = TxtRut.Text;
            clave = TxtClave.Password;

            if(rut == "Alumno" )
            {
                if (clave == "123")
                {
                    
                    UserAlumno alumno = new UserAlumno(); 
                    alumno.Show();
                }
            }

        }
        
    }
}
