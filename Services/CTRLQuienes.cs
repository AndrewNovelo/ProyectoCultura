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

        QuienesDAO oQuienesDAO;
        QuienesBO oQuienesBO;

        public CTRLQuienes()
        {
            oQuienesDAO = new QuienesDAO();
        }

        public bool Accion(string Action, QuienesBO oEventoBO)
        {
            switch (Action)
            {
                case "btnModificar":
                    oQuienesDAO.ModificarMensaje(oEventoBO);
                    break;
            }
            return true;
        }

        public string Listar()
        {
            return oQuienesDAO.ModificarMensaje(oQuienesBO);
        }

    }
}
