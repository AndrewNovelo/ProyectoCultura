using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class EventoBO
    {
        public int ID { set; get; }
        public string NOMBRE { get; set; }
        public string DESCRIPCION { get; set; }

        public double COSTO { get; set; }
        public int CUPO { get; set; }

        public int ID_DIRECCION { get; set; }
        public int ID_ORGANIZADOR { get; set; }
        public int ID_CLASIFICACION { get; set; }

    }
}
