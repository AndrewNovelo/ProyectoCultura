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
    public class CTRLHorario
    {

        EventoDAO oEventoDAO;
        public CTRLHorario()
        {
            oEventoDAO = new EventoDAO();
        }

        public bool Accion(string Action, HorarioBO OBHOrarioBO)
        {
            switch (Action)
            {
                case "btnAgregar":
                    oEventoDAO.AgregarHorario(OBHOrarioBO);
                    break;
                case "btnModificar":
                    //oEventoDAO.Modificar(OBHOrarioBO);
                    break;
                case "btnEliminar":
                    //oEventoDAO.Eliminar(OBHOrarioBO);
                    break;
            }
            return true;
        }

        /*public DataSet ListarHorario()
        {
            return oEventoDAO.ListarHorario();
        }*/

    }
}
