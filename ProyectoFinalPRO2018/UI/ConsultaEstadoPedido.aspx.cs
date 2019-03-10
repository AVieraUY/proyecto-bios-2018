using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntidadesCompartidas;
using Negocio;

public partial class ConsultaEP : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnConsular_Click(object sender, EventArgs e)
    {
        try
        {
            Pedido p = negPedido.Buscar(Convert.ToInt32(txtCodigo.Text));

            lblMensaje.Text = p.Estado;
        }
        catch (Exception ex)
        {
            lblMensaje.Text = ex.Message;
        }
    }
}