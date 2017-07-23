using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class ConexionDAO
    {

        SqlCommand comandosql;
        SqlDataAdapter adaptador;
        DataSet datasetadaptador;
        SqlConnection coneccion;

        public ConexionDAO()
        {
            adaptador = new SqlDataAdapter();
            comandosql = new SqlCommand();
            coneccion = new SqlConnection();
        }

        public SqlConnection establecerConexion()
        {
            string cs = "Data Source=TAILESSHEART_PC\\SQLEXPRESS; Initial catalog=PROYECTO3A; integrated security=true";
            coneccion = new SqlConnection(cs);
            return coneccion;
        }


        public void abrirConexion()
        {
            coneccion.Open();
        }
        public void cerrarConexion()
        {
            coneccion.Close();
        }
        public DataSet EjecutarSentencia(SqlCommand SqlComando)
        {

            // SELECT (Devolver registros)
            adaptador = new SqlDataAdapter();
            comandosql = new SqlCommand();
            datasetadaptador = new DataSet();

            comandosql = SqlComando;
            comandosql.Connection = this.establecerConexion();
            this.abrirConexion();
            adaptador.SelectCommand = comandosql;
            adaptador.Fill(datasetadaptador);
            this.cerrarConexion();
            return datasetadaptador;

        }
        public int EjecutarComando(SqlCommand SqlComando)
        {
            // INSERT, DELETE, UPDATE
            comandosql = new SqlCommand();
            comandosql = SqlComando;
            comandosql.Connection = this.establecerConexion();
            this.abrirConexion();
            int id = 0; id = Convert.ToInt32(comandosql.ExecuteScalar());
            this.cerrarConexion();
            return id;

        }
    }
}
