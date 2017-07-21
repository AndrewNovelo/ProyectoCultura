using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BO;

namespace DAO
{
    public class QuienesDAO
    {
        ConexionDAO Conex;

        public QuienesDAO()
        {
            Conex = new ConexionDAO();
        }

        public string ModificarMensaje(QuienesBO oQuienes)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Quienes SET Mensaje=@Mensaje WHERE id=@ID");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = oQuienes.Id;
            cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar).Value = oQuienes.Mensaje;
            return Conex.EjecutarConTexto(cmd);
        }



    }
}
