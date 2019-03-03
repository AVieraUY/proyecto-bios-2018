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
        try
        {
            //negPedido.ListarPorCliente
            //negPedido.ListarPorEstado
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }
}