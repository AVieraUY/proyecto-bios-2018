using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using EntidadesCompartidas;

public partial class RealizarPedido : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            grdMeds.DataSource = negMedicamento.Listar();
            grdMeds.DataBind();

        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }


    }
    protected void grdMeds_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}