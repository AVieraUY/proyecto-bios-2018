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
            MenuCli.Visible = true;
        else if (Session["usuario"] is Empleado)
            MenuEmp.Visible = true;
    }
}
