using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class TipoUsuarioBO
    {

        public int ID { set; get; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public int IDPermiso { set; get; }
        public int DNIUsuario{ set; get; }

    }
}
