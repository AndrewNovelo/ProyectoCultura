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
    public class EventoDAO
    {
        ConexionDAO Conex;
        EventoBO oEventoBO = new EventoBO();

        public EventoDAO()
        {
            Conex = new ConexionDAO();
        }

        //Este Metodo debe cambiar de buscar el ultimo ID_Organizador a buscar el ID del organizador que esta logueado en el sistema
        public int UltimoOrganizador()
        {
            SqlCommand cmd = new SqlCommand("SELECT MAX(ID) FROM TIPO_USUARIO WHERE ID_PERMISO = 2");
            return Conex.EjecutarComando(cmd);
        }

        public int UltimDireccion()
        {
            SqlCommand cmd = new SqlCommand("SELECT MAX(ID) FROM DIRECCION");
            return Conex.EjecutarComando(cmd);
        }

        public int AgregarEvento(EventoBO ObjEvento)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO EVENTO(NOMBRE, DESCRIPCION, COSTO, CUPO, ID_DIRECCION, ID_ORGANIZADOR, ID_CLASIFICACION) VALUES (@NOMBRE,@DESCRIPCION,@COSTO,@CUPO,@IDDIREC, @IDORG, @IDCLASI)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = ObjEvento.NOMBRE;
            cmd.Parameters.Add("@DESCRIPCION", SqlDbType.VarChar).Value = ObjEvento.DESCRIPCION;
            cmd.Parameters.Add("@COSTO", SqlDbType.Money).Value = ObjEvento.COSTO;
            cmd.Parameters.Add("@CUPO", SqlDbType.Int).Value = ObjEvento.CUPO;
            cmd.Parameters.Add("@IDDIREC", SqlDbType.Int).Value = ObjEvento.ID_DIRECCION;
            cmd.Parameters.Add("@IDORG", SqlDbType.Int).Value = ObjEvento.ID_ORGANIZADOR;
            cmd.Parameters.Add("@IDCLASI", SqlDbType.Int).Value = ObjEvento.ID_CLASIFICACION;
            return Conex.EjecutarComando(cmd);
        }

        public int AgregarHorario(HorarioBO ObjHORARIO)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO HORARIO (FECHA_INICIO, FECHA_FIN, DIA) VALUES (@FEINICIO,@FEFIN,@DIA)");
            cmd.CommandType = CommandType.Text;
            //cmd.Parameters.Add("@HRINICIO", SqlDbType.VarChar).Value = ObjHORARIO.HORAINICIO;
            //cmd.Parameters.Add("@HRFIN", SqlDbType.VarChar).Value = ObjHORARIO.HORAFIN;
            cmd.Parameters.Add("@FEINICIO", SqlDbType.DateTime).Value = ObjHORARIO.FECHAINICION;
            cmd.Parameters.Add("@FEFIN", SqlDbType.DateTime).Value = ObjHORARIO.FECHAFIN;
            cmd.Parameters.Add("@DIA", SqlDbType.VarChar).Value = ObjHORARIO.DIA;
            return Conex.EjecutarComando(cmd);
        }

        public int AgregarEventoHorario(EventoXHorarioBO OBEventoHora)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO HORARIOXEVENTO (ID_EVENTO, ID_HORARIO)VALUES(@IDEVENTO,@IDHORARIO)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@IDEVENTO", SqlDbType.Int).Value = OBEventoHora.CodigoEvento;
            cmd.Parameters.Add("@IDHORARIO", SqlDbType.Int).Value = OBEventoHora.CodigoHorario;
            return Conex.EjecutarComando(cmd); 
        }

        public int UltimoDatoEvento()
        {
            SqlCommand cmd = new SqlCommand("SELECT MAX(CODIGO) FROM EVENTO");
            return Conex.EjecutarComando(cmd);
        }

        public int UltimoDatoHorario()
        {
            SqlCommand cmd = new SqlCommand("SELECT MAX(CODIGO) FROM HORARIO");
            return Conex.EjecutarComando(cmd);
        }




        public DataSet ListarEvento()
        {
            SqlCommand cmd = new SqlCommand("select * from EVENTO inner join HORARIOXEVENTO on EVENTO.CODIGO = HORARIOXEVENTO.ID_EVENTO inner join HORARIO on HORARIO.CODIGO = HORARIOXEVENTO.ID_HORARIO");
            cmd.CommandType = CommandType.Text;
            return Conex.EjecutarSentencia(cmd);
        }

        /*public DataSet ListarHorario()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HORARIO");
            cmd.CommandType = CommandType.Text;
            return Conex.EjecutarSentencia(cmd);

        }*/


    }
}
