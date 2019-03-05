using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntidadesCompartidas;

public partial class BienvenidaEmpleado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!(Session["usuario"] is Empleado))
            Response.Redirect("Logueo.aspx");

    }
}