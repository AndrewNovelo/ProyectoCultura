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

        ConexionDAO Conex = new ConexionDAO();

        public QuienesDAO()
        {
            Conex = new ConexionDAO();
        }
                
        public int Modificar(QuienesBO OBQuienes)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Quienes SET Mensaje=@Mensaje WHERE id=@ID");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = OBQuienes.Id;
            cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar).Value = OBQuienes.Mensaje;
            return Conex.EjecutarComando(cmd);
        }
                
        public DataSet Listar()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Quienes");
            cmd.CommandType = CommandType.Text;
            return Conex.EjecutarSentencia(cmd);
        }        
    }
}
