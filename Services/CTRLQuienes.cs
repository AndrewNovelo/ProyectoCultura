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
    public class CTRLQuienes
    {

        QuienesDAO OBQuienesDAO;

        public CTRLQuienes()
        {
            OBQuienesDAO = new QuienesDAO();
        }

        public bool Accion(string Action, QuienesBO oQuienesBO)
        {
            switch (Action)
            {
                /*case "btnAgregar":
                    OBQuienesDAO.Agregar(OBPersonaBO);
                    break;*/
                case "btnActualizar":
                    OBQuienesDAO.Modificar(oQuienesBO);
                    break;
                /*case "btnEliminar":
                    OBQuienesDAO.Eliminar(OBPersonaBO);
                    break;*/
            }
            return true;
        }

        public DataSet Listar()
        {
            return OBQuienesDAO.Listar();
        }

    }
}
