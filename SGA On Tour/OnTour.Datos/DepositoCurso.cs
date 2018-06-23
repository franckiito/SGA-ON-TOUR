using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTour.Datos
{
    class DepositoCurso
    {
        public int Id { get; set; }
        public string NumeroCuenta { get; set; }
        public DateTime FechaDeposito { get; set; }
        public int Monto { get; set; }
        public int IdActividad { get; set; }
        public string RutRepresentante { get; set; }
    }
}
