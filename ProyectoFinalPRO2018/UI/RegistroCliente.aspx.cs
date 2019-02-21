using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using EntidadesCompartidas;

public partial class RegistroCliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLimpiar_Click(object sender, EventArgs e)
    {
        txtApellido.Text = string.Empty;
        txtContraseña.Text = string.Empty;
        txtDirEntrega.Text = string.Empty;
        txtNCompleto.Text = string.Empty;
        txtNombre.Text = string.Empty;
        txtTel.Text = string.Empty;
        txtUsuario.Text = string.Empty;
    }

    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        Cliente uc = new Cliente(txtUsuario.Text, txtContraseña.Text, txtNombre.Text, txtApellido.Text, txtDirEntrega.Text, txtTel.Text);

        negUsuario.Alta(uc);

        lblError.Text = "Cliente agregado con éxito";
    }
}