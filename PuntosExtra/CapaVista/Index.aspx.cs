using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PuntosExtra.CapaVista
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load (object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
              
                cboTipo.Items.Add("Desayuno");
                cboTipo.Items.Add("Almuerzo");
                cboTipo.Items.Add("Cena");
               
            }
        }

        protected void btnAdd_Click (object sender, EventArgs e)
        {
            if (new CapaNegocios.clsReservaNegocios().InsertarReserv(txtName.Text, txtFecha.Text, txtCedula.Text, cboTipo.SelectedItem.Text))
            {                     
                Label5.Text = "Ingresado";
                limpiar();
            }
            else
            {
                Label5.Text = "Error, cliente no agregado";
            }
        }

        public void limpiar ()
        {
            txtName.Text = " ";
            txtCedula.Text = " ";
            txtFecha.Text = " ";
            cboTipo.SelectedItem.Text = " ";
        }

        protected void bntVer_Click (object sender, EventArgs e)
        {
            dgVerTodos.DataSource = new CapaNegocios.clsReservaNegocios().BuscarReserv();
            dgVerTodos.DataBind();
        }

        protected void bntVerUno_Click (object sender, EventArgs e)
        {
            dgVer.DataSource = new CapaNegocios.clsReservaNegocios().SelectReserv();
            dgVer.DataBind();
        }
    }
}