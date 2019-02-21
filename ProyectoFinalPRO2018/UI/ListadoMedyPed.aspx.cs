using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntidadesCompartidas;
using Negocio;

public partial class ListadoMedyPed : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                ddl.DataSource = negFarmaceutica.Listar();
                ddl.DataTextField = "rut";
                ddl.DataValueField = "rut";
                ddl.DataBind();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

    }
    protected void ddl_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}