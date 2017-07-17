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
    public partial class Usuario : System.Web.UI.Page
    {
        CTRLPersona OBService = new CTRLPersona();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Listar();
            }
        }

        protected void Accion(object sender, EventArgs e)
        {
            Button Seleccionada = (Button)sender;
            OBService.Accion(Seleccionada.ID, Recolectar());
            Listar();            
        }

        public void Listar()
        {
            dgvDatos.DataSource = OBService.Listar().Tables[0];
            dgvDatos.DataBind();
        }

        public PersonaBO Recolectar()
        {
            PersonaBO OBPersonaBO = new PersonaBO();
            int DNI = 0; int.TryParse(txtDNI.Text, out DNI);
            OBPersonaBO.DNI = DNI;
            OBPersonaBO.Nombre = txtNombre.Text;
            OBPersonaBO.ApellidoP = txtApeP.Text;
            OBPersonaBO.ApellidoM = txtApeM.Text;
            OBPersonaBO.Correo = txtCorreo.Text;
            OBPersonaBO.Telefono = txtTelefono.Text;
            return OBPersonaBO;
        }

        protected void dgvDatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Seleccionar(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "dgvbtnSeleccionar")
            {
                int Indice = Convert.ToInt32(e.CommandArgument);

                txtDNI.Text = dgvDatos.Rows[Indice].Cells[1].Text;
                txtNombre.Text = dgvDatos.Rows[Indice].Cells[2].Text;
                txtApeP.Text = dgvDatos.Rows[Indice].Cells[3].Text;
                txtApeM.Text = dgvDatos.Rows[Indice].Cells[4].Text;
                txtCorreo.Text = dgvDatos.Rows[Indice].Cells[5].Text;
                txtTelefono.Text = dgvDatos.Rows[Indice].Cells[6].Text;
            }
        }

        protected void SoloNumeros(object sender, EventArgs e)
        {
            
        }
    }
}