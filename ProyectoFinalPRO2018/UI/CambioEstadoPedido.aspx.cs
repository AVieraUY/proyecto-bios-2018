using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using EntidadesCompartidas;

public partial class CambioEstadoPedido : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!(Session["usuario"] is Empleado))
            Response.Redirect("Logueo.aspx");
        try
        {
            grd.DataSource = negPedido.ListarPedido();
            grd.DataBind();
            
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }
    protected void grd_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            Pedido p = negPedido.Buscar(Convert.ToInt32(grd.SelectedRow.Cells[0].Text));
            negPedido.CambiarEstado(p);

            grd.DataSource = negPedido.ListarPedido();
            grd.DataBind();
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }
}