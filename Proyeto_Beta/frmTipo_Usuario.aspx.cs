using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAO;
using BO;
using Services;


namespace Proyeto_Beta
{
    public partial class Tipo_Usuario : System.Web.UI.Page
    {
        TipoUsuarioDAO OBUsuario = new DAO.TipoUsuarioDAO();
        CTRLTipoUsuario OBS = new CTRLTipoUsuario();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            txtIDUsu.Text = OBUsuario.UltimoRegistro().ToString();
            rbtOrganizador.GroupName = "Tipo";
            rbtUsuario.GroupName = "Tipo";
            if (!IsPostBack)
            {                
                Listar();
                txtIDUsu.Text = "";
            }
        }

        protected void Accion(object sender, EventArgs e)
        {

            Button Selecciona = (Button)sender;
            OBS.Accion(Selecciona.ID, Recolectar());
            Listar();
                           
        }

        public TipoUsuarioBO Recolectar()
        {
            TipoUsuarioBO OBPersonaBO = new TipoUsuarioBO();
            int ID = 0; int.TryParse(txtID.Text, out ID);
            OBPersonaBO.ID = ID;
            OBPersonaBO.Nombre = txtNombre.Text;
            OBPersonaBO.Contraseña = txtContraseña.Text;
            OBPersonaBO.DNIUsuario= Convert.ToInt32(txtIDUsu.Text);
            OBPersonaBO.IDPermiso= ValidarRadio();
            return OBPersonaBO;
        }

        public int ValidarRadio()
        {
            int permiso;
            if (rbtOrganizador.Checked == true)
            {
                permiso = 2; return permiso;
            }
            else if (rbtUsuario.Checked == true)
            {
                permiso = 3; return permiso;
            }
            return permiso = 2;
        }

        protected void rbtUsuario_CheckedChanged(object sender, EventArgs e)
        {
            //rbtOrganizador.Checked = true;

        }

        protected void rbtOrganizador_CheckedChanged(object sender, EventArgs e)
        {
            //rbtUsuario.Checked = true;
        }

        public void Listar()
        {
            dgvUsuario.DataSource = OBS.Listar().Tables[0];
            dgvUsuario.DataBind();
        }

        protected void btnDatos_Click(object sender, EventArgs e)
        {
            
        }

        protected void Seleccionar(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "dgvbtnSeleccionar")
            {
                int Indice = Convert.ToInt32(e.CommandArgument);

                txtID.Text = dgvUsuario.Rows[Indice].Cells[1].Text;
                txtNombre.Text = dgvUsuario.Rows[Indice].Cells[2].Text;
                txtContraseña.Text = dgvUsuario.Rows[Indice].Cells[3].Text;
                txtIDUsu.Text = dgvUsuario.Rows[Indice].Cells[4].Text;
                
            }
        }
    }
}