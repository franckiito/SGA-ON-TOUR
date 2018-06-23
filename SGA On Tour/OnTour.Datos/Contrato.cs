using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTour.Datos
{
    class Contrato
    {
        public int IdContrato { get; set; }
        public DateTime FechaContrato { get; set; }
        public int IdReserva { get; set; }
        public int IdPaquete { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaTermino { get; set; }
        public string Estado { get; set; }

        public string Empleado_Rut { get; set; }
    }
}
