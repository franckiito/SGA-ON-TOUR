using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTour.Datos
{
    class Curso
    {
        public int Id { get; set; }
        public string Grado { get; set; }
        public int Anio { get; set; }
        public int CantidadAlumnos { get; set; }
        public int IdColegio { get; set; }
        public int Abono { get; set; }
    }
}
