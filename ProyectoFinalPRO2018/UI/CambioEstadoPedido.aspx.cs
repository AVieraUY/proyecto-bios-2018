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
            List<Pedido> lp = negPedido.ListarPedido();

            if (lp.Count == 0)
                throw new Exception("No hay pedidos con estado generado o enviado.");

            grd.DataSource = lp;
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
            lblError.Text = string.Empty;
            Pedido p = negPedido.Buscar(Convert.ToInt32(grd.SelectedRow.Cells[0].Text));
            negPedido.CambiarEstado(p);
            
            List<Pedido> lp = negPedido.ListarPedido();

            if (lp.Count == 0)
                throw new Exception("No hay pedidos con estado generado o enviado.");

            grd.DataSource = lp;
            grd.DataBind();
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }
}