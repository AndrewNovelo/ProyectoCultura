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
    public class CTRLEvento
    {
        EventoDAO oEventoDAO;
        public CTRLEvento()
        {
            oEventoDAO = new EventoDAO();
        }

        public bool Accion(string Action, EventoBO OBEventoBO, HorarioBO OBHorarioBO, EventoXHorarioBO OBEventoHora)
        {
            switch (Action)
            {
                case "btnAgregar":
                    oEventoDAO.AgregarEvento(OBEventoBO);
                    oEventoDAO.AgregarHorario(OBHorarioBO);
                    oEventoDAO.AgregarEventoHorario(OBEventoHora);
                    break;
                case "btnModificar":
                    //oEventoDAO.Modificar(OBEventoBO);
                    break;
                case "btnEliminar":
                    //oEventoDAO.Eliminar(OBEventoBO);
                    break;
            }
            return true;
        }

        public DataSet Listar()
        {
            return oEventoDAO.ListarEvento();
        }
    }
}
