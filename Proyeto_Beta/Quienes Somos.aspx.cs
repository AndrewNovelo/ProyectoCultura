using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAO;
using BO;
using Services;
using System.Data;
using System.Data.SqlClient;


namespace Proyeto_Beta
{
    public partial class Quienes_Somos : System.Web.UI.Page
    {

        ConexionDAO Conex = new ConexionDAO();
        QuienesDAO oQuienesDAO = new QuienesDAO();
        QuienesBO oQuienesBO = new QuienesBO();
        CTRLQuienes oQuienesService = new CTRLQuienes();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                ListarMensaje();
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            Button Seleccionar = (Button)sender;
            oQuienesService.Accion(Seleccionar.ID, RecolectarINFO());
            ListarMensaje();
            
        }

        public QuienesBO RecolectarINFO()
        {
            QuienesBO oQuienesBO = new QuienesBO();
            int ID = 0; int.TryParse(txtID.Text, out ID);
            oQuienesBO.Id = ID;
            oQuienesBO.Mensaje = txtQuienes.Text;
            return oQuienesBO;
        }

        public void ListarMensaje()
        {
            txtQuienes.Text = oQuienesService.Listar().ToString();
            txtQuienes.DataBind();
        }
        
    }
}