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
    public class CTRLPersona
    {

        PersonaDAO OBPersonaDAO;

        public CTRLPersona()
        {
            OBPersonaDAO = new PersonaDAO();
        }

        public bool Accion(string Action, PersonaBO OBPersonaBO)
        {
            switch (Action)
            {
                case "btnAgregar":
                    OBPersonaDAO.Agregar(OBPersonaBO);
                    break;
                case "btnModificar":
                    OBPersonaDAO.Modificar(OBPersonaBO);
                    break;
                case "btnEliminar":
                    OBPersonaDAO.Eliminar(OBPersonaBO);
                    break;
            }
            return true;
        }

        public DataSet Listar()
        {
            return OBPersonaDAO.Listar();
        }

    }
}
