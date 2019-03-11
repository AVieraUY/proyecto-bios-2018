using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using EntidadesCompartidas;

public partial class ListadoPedidosGenerados : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblError.Text = string.Empty;
        if (Session["usuario"] is Empleado)
            Response.Redirect("BienvenidaEmpleado.aspx");
        else if (!(Session["usuario"] is Cliente))
            Response.Redirect("Logueo.aspx");
        try
        {
            Cliente cli = (Cliente)Session["usuario"];
            List <Pedido> lp = negPedido.ListarPorCliente(cli);
            grdPedidos.DataSource = lp;
            grdPedidos.DataBind();

            if (lp.Count == 0)
                lblError.Text = "No se encontraron pedidos generados.";
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }
    protected void grdPedidos_SelectedIndexChanged(object sender, EventArgs e)
    {
        Pedido p = negPedido.Buscar(Convert.ToInt32(grdPedidos.SelectedRow.Cells[0].Text));
        Session["p"] = p;

        List<Pedido> lp = new List<Pedido>();
        lp.Add(p);

        GridView1.DataSource = lp;
        GridView1.DataBind();

        btnEliminar.Visible = true;
        GridView1.Visible = true;
    }
    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        try
        {

            Pedido p = (Pedido)Session["p"];
            negPedido.Baja(p);
            
            Cliente cli = (Cliente)Session["usuario"];
            grdPedidos.DataSource = negPedido.ListarPorCliente(cli);
            grdPedidos.DataBind();
            
            lblError.Text = "Pedido eliminado con éxito";
            GridView1.Visible = false;
            btnEliminar.Visible = false;
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }
}