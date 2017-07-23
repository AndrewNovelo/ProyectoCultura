using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BO;
using DAO;
using Services;


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
            if (!IsPostBack)
            {
                Listar2();
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {

            Button Seleccionada = (Button)sender;
            oQuienesService.Accion(Seleccionada.ID, Recolectar());
            Listar2();

        }

        public QuienesBO Recolectar()
        {
            QuienesBO oQuienes = new QuienesBO();

            int id = 0; int.TryParse(txtID.Text, out id);
            oQuienesBO.Id = id;
            oQuienesBO.Mensaje = txtQuienes.Text;
            return oQuienesBO;            
        }


        protected void Seleccionar(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "dgvbtnSeleccionar")
            {
                int Indice = Convert.ToInt32(e.CommandArgument);

                txtID.Text = GvQuienes.Rows[Indice].Cells[1].Text;
                txtQuienes.Text = GvQuienes.Rows[Indice].Cells[2].Text;
            }            
        }

        public void Listar2()
        {
            GvQuienes.DataSource = oQuienesService.Listar().Tables[0];
            GvQuienes.DataBind();
        }        
    }
}