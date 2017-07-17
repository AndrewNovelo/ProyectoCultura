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
    public class PersonaDAO
    {

        ConexionDAO Conex;

        public PersonaDAO()
        {
            Conex = new ConexionDAO();
        }

        public int Agregar(PersonaBO ObjPersona)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO USUARIO(NOMBRE, APELLIDO_P, APELLIDO_M, CORREO, TELEFONO) VALUES (@NOMBRE,@APEP,@APEM,@CORREO,@TELEFONO)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = ObjPersona.Nombre;
            cmd.Parameters.Add("@APEP", SqlDbType.VarChar).Value = ObjPersona.ApellidoP;
            cmd.Parameters.Add("@APEM", SqlDbType.VarChar).Value = ObjPersona.ApellidoM;
            cmd.Parameters.Add("@CORREO", SqlDbType.VarChar).Value = ObjPersona.Correo;
            cmd.Parameters.Add("@TELEFONO", SqlDbType.VarChar).Value = ObjPersona.Telefono;
            return Conex.EjecutarComando(cmd);
        }

        public int Modificar(PersonaBO ObjPersona)
        {
            SqlCommand cmd = new SqlCommand("UPDATE USUARIO SET NOMBRE=@NOMBRE, APELLIDO_P=@APEP, APELLIDO_M=@APEM, CORREO=@CORREO, TELEFONO=@TELEFONO WHERE DNI=@DNI");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = ObjPersona.Nombre;
            cmd.Parameters.Add("@APEP", SqlDbType.VarChar).Value = ObjPersona.ApellidoP;
            cmd.Parameters.Add("@APEM", SqlDbType.VarChar).Value = ObjPersona.ApellidoM;
            cmd.Parameters.Add("@CORREO", SqlDbType.VarChar).Value = ObjPersona.Correo;
            cmd.Parameters.Add("@TELEFONO", SqlDbType.VarChar).Value = ObjPersona.Telefono;
            cmd.Parameters.Add("@DNI", SqlDbType.Int).Value = ObjPersona.DNI;
            return Conex.EjecutarComando(cmd);
        }

        public int Eliminar(PersonaBO ObjPersona)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM USUARIO WHERE DNI=@DNI");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@DNI", SqlDbType.Int).Value = ObjPersona.DNI;
            return Conex.EjecutarComando(cmd);
        }

        public DataSet Listar()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM USUARIO");
            cmd.CommandType = CommandType.Text;
            return Conex.EjecutarSentencia(cmd);
        }
    }
}
