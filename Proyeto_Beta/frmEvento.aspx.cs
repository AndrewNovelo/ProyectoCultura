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
    public partial class frmEvento : System.Web.UI.Page
    {
        ConexionDAO Conex = new ConexionDAO();
        EventoDAO oEventoDAO = new EventoDAO();
        EventoBO oEventoBO = new EventoBO();
        CTRLEvento oEventoService = new CTRLEvento();
        CTRLHorario oHorarioService = new CTRLHorario();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Ver comentario en DAO
            txtIDOrganizador.Text = oEventoDAO.UltimoOrganizador().ToString();
            txtIDClasificacion.Text = IDClasificacion().ToString();
            txtIDDireccion.Text = oEventoDAO.UltimDireccion().ToString();
            if (!IsPostBack)
            {
           
                ListarEventos();
                //ListarHorario();
                
            }
            
        }

        //Selecciona el ID de la clasificacion con el elemento DDL seleccionado
        public int IDClasificacion()
        {
            SqlCommand cmd = new SqlCommand("SELECT ID FROM CLASIFICACION WHERE NOMBRE = '" +DropDownList1.SelectedItem + "'");
            return Conex.EjecutarComando(cmd);
        }



        protected void btnVer_Click(object sender, EventArgs e)
        {
       
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void Accion(object sender, EventArgs e)
        {
            Button Selecciona = (Button)sender;
            oEventoService.Accion(Selecciona.ID, RecolectarEvento(), RecolectarHorario(), RecolectarIDS());
            ListarEventos();
        }

        public EventoBO RecolectarEvento()
        {
            EventoBO OBEventoBO = new EventoBO();
            int ID = 0; int.TryParse(txtIDEvento.Text, out ID);
            OBEventoBO.ID = ID;
            OBEventoBO.NOMBRE= txtNombre.Text;
            OBEventoBO.DESCRIPCION = txtDescripcion.Text;
            OBEventoBO.COSTO = double.Parse(txtCosto.Text);
            OBEventoBO.CUPO = int.Parse(txtCupo.Text);
            OBEventoBO.ID_DIRECCION = int.Parse(txtIDDireccion.Text);
            OBEventoBO.ID_ORGANIZADOR = int.Parse(txtIDOrganizador.Text);
            OBEventoBO.ID_CLASIFICACION = int.Parse(txtIDClasificacion.Text);
            return OBEventoBO;            
        }

        public HorarioBO RecolectarHorario()
        {
            HorarioBO OBHorarioBO = new HorarioBO();
            int Codigo = 0; int.TryParse(txtCodigo.Text, out Codigo);
            OBHorarioBO.Codigo = Codigo;
            //OBHorarioBO.HORAINICIO = int.Parse(txtHoraInicio.Text);
            //OBHorarioBO.HORAFIN = int.Parse(txtHoraFin.Text);
            OBHorarioBO.FECHAINICION = DateTime.Parse(txtFechaInicio.Text);
            OBHorarioBO.FECHAFIN = DateTime.Parse(txtFechaFin.Text);
            OBHorarioBO.DIA = txtDia.Text;
            return OBHorarioBO;
        }


        public EventoXHorarioBO RecolectarIDS()
        {
            EventoDAO Recolectar = new EventoDAO();
            EventoXHorarioBO OBIDS = new EventoXHorarioBO();
            OBIDS.CodigoEvento = Recolectar.UltimoDatoEvento();
            OBIDS.CodigoHorario = Recolectar.UltimoDatoHorario();
            return OBIDS;
        }

        public void ListarEventos()
        {
            dgvDatos.DataSource = oEventoService.Listar().Tables[0];
            dgvDatos.DataBind();
        }

        protected void Seleccionar(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "dgvbtnSeleccionar")
            {
                int Indice = Convert.ToInt32(e.CommandArgument);

                txtIDEvento.Text = dgvDatos.Rows[Indice].Cells[1].Text;
                txtNombre.Text = dgvDatos.Rows[Indice].Cells[2].Text;
                txtDescripcion.Text = dgvDatos.Rows[Indice].Cells[3].Text;
                txtCosto.Text = dgvDatos.Rows[Indice].Cells[4].Text;
                txtCupo.Text = dgvDatos.Rows[Indice].Cells[6].Text;
                txtIDDireccion.Text = dgvDatos.Rows[Indice].Cells[7].Text;
                txtIDOrganizador.Text = dgvDatos.Rows[Indice].Cells[8].Text;
                txtIDClasificacion.Text = dgvDatos.Rows[Indice].Cells[9].Text;
                txtCodigo.Text = dgvDatos.Rows[Indice].Cells[11].Text;
                //txtHoraInicio.Text = dgvDatos.Rows[Indice].Cells[13].Text;
                //txtHoraFin.Text = dgvDatos.Rows[Indice].Cells[14].Text;
                txtFechaInicio.Text = dgvDatos.Rows[Indice].Cells[13].Text;
                txtFechaFin.Text = dgvDatos.Rows[Indice].Cells[14].Text;
                txtDia.Text = dgvDatos.Rows[Indice].Cells[15].Text;
            }
        }

        /*public void ListarHorario()
        {
            dgvDatos.DataSource = oHorarioService.ListarHorario().Tables[0];
            dgvDatos.DataBind();
        }*/ //dgvbtnSeleccionar
    }
}