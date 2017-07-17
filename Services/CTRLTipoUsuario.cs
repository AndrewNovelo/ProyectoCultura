using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BO;
using DAO;

namespace Services
{
    public class CTRLTipoUsuario
    {

        TipoUsuarioDAO OBUsuarioDAO;

        public CTRLTipoUsuario()
        {
            OBUsuarioDAO = new TipoUsuarioDAO();
        }

        public bool Accion(string Action, TipoUsuarioBO OBUsuariosBO)
        {
            switch (Action)
            {
                case "btnAgregar":
                    OBUsuarioDAO.Agregar(OBUsuariosBO);
                    break;
                case "btnModificar":
                    OBUsuarioDAO.Modificar(OBUsuariosBO);
                    break;
                case "btnEliminar":
                    OBUsuarioDAO.Eliminar(OBUsuariosBO);
                    break;
            }
            return true;
        }

        public DataSet Listar()
        {
            return OBUsuarioDAO.Listar();
        }

    }
}
