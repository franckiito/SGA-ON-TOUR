using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTour.Datos
{
    class DepositoAlumno
    {
        public int Id { get; set; }
        public DateTime FechaDeposito { get; set; }
        public int Monto { get; set; }

        public string RutApoderado { get; set; }
        public string RutAlumno { get; set; }
        public string RutRepresentante { get; set; }
    }
}
