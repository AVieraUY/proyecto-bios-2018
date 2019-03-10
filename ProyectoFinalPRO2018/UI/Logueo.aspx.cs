using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using EntidadesCompartidas;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            Limpiar();
    }

    private void Limpiar()
    {
        txtUsername.Text = string.Empty;
        txtPassword.Text = string.Empty;
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        try
        {
            Usuario u = negUsuario.Login(txtUsername.Text, txtPassword.Text);
            if(u is Cliente)
            {
                Session["usuario"] = (Cliente)u;
                Response.Redirect(Page.ResolveUrl("~/RealizarPedido.aspx"));
            }
            else if(u is Empleado)
            {
                Session["usuario"] = (Empleado)u;
                Response.Redirect(Page.ResolveUrl("~/BienvenidaEmpleado.aspx"));
            }
            else
            {
                Limpiar();
            }
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }    
}