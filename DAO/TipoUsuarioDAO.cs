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
    public class TipoUsuarioDAO
    {

        ConexionDAO Conex = new ConexionDAO();

        public TipoUsuarioDAO()
        {
            Conex = new ConexionDAO();
        }

        public int Agregar(TipoUsuarioBO OBTipoUsu)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO TIPO_USUARIO (NOMBRE, CONTRASEÑA, ID_PERMISO, DNI_USUARIO) VALUES (@NOMBRE, @CONTRASEÑA, @IDPERMISO, @DNIUSUARIO)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = OBTipoUsu.Nombre;
            cmd.Parameters.Add("@CONTRASEÑA", SqlDbType.VarChar).Value = OBTipoUsu.Contraseña;
            cmd.Parameters.Add("@IDPERMISO", SqlDbType.Int).Value = OBTipoUsu.IDPermiso;
            cmd.Parameters.Add("@DNIUSUARIO", SqlDbType.Int).Value = OBTipoUsu.DNIUsuario;
            return Conex.EjecutarComando(cmd); 
        }

        public int Modificar(TipoUsuarioBO OBTipoUsu)
        {
            SqlCommand cmd = new SqlCommand("UPDATE TIPO_USUARIO SET NOMBRE=@NOMBRE, CONTRASEÑA=@CONTRASEÑA, ID_PERMISO=@IDPERMISO, DNI_USUARIO=@DNIUSUARIO WHERE ID=@ID");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = OBTipoUsu.ID;
            cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = OBTipoUsu.Nombre;
            cmd.Parameters.Add("@CONTRASEÑA", SqlDbType.VarChar).Value = OBTipoUsu.Contraseña;
            cmd.Parameters.Add("@IDPERMISO", SqlDbType.Int).Value = OBTipoUsu.IDPermiso;
            cmd.Parameters.Add("@DNIUSUARIO", SqlDbType.Int).Value = OBTipoUsu.DNIUsuario;
            return Conex.EjecutarComando(cmd);
        }
        
        public int Eliminar(TipoUsuarioBO OBTipoUsu)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM TIPO_USUARIO WHERE ID=@ID");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = OBTipoUsu.IDPermiso;
            return Conex.EjecutarComando(cmd);
        }

        public int UltimoRegistro()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM USUARIO WHERE DNI = (SELECT MAX(DNI) FROM USUARIO)");
            return Conex.EjecutarComando(cmd);
        }

        public DataSet Listar()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TIPO_USUARIO");
            cmd.CommandType = CommandType.Text;
            return Conex.EjecutarSentencia(cmd);
        }

        public int IDPersona()
        {
            SqlCommand cmd = new SqlCommand("SELECT ID FROM PERMISO WHERE DNI = (SELECT ID FROM TIPO_USUARIO = @ID)");
            return Conex.EjecutarComando(cmd);
        }

    }
}
