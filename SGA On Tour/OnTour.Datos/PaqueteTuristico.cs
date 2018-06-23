using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTour.Datos
{
    class PaqueteTuristico
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }

        public int IdAct { get; set; }
        public int IdSeguro { get; set; }
        public int IdHotel { get; set; }
        public int IdTransporte { get; set; }
    }
}
