using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTour.Datos
{
    class Alumno
    {
        public string Rut { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Abono { get; set; }
        public string Telefono { get; set; }
        public string Contrasena { get; set; }

        public int IdCurso { get; set; }
        public string RutApoderado { get; set; }
        

    }
}
