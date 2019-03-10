using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntidadesCompartidas;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["usuario"] is Cliente)
        {
            Cliente cli = (Cliente)Session["usuario"];
            MenuCli.Visible = true;
            lblUsuario.Text = cli.Username;
            btnOut.Visible = true;
        }

        else if (Session["usuario"] is Empleado)
        {
            Empleado emp = (Empleado)Session["usuario"];
            MenuEmp.Visible = true;
            lblUsuario.Text = emp.Username;
            btnOut.Visible = true;
        }
    }
    protected void btnOut_Click(object sender, EventArgs e)
    {
        Session["usuario"] = null;
        Response.Redirect(Page.ResolveUrl("~/Logueo.aspx"));
    }
}
