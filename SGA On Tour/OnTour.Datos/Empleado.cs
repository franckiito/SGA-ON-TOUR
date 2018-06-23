using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTour.Datos
{
    class Empleado
    {
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaContratacion { get; set; }
        public int Sueldo { get; set; }
        public string Contrasena { get; set; }
        public string Estado { get; set; }
    }
}
