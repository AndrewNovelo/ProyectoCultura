using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class HorarioBO
    {
        public int Codigo { get; set; }
        //public double HORAINICIO { set; get; }
        //public double HORAFIN { set; get; }
        public DateTime FECHAINICION { set; get; }
        public DateTime FECHAFIN { set; get; }
        public string DIA { set; get; }

    }
}
