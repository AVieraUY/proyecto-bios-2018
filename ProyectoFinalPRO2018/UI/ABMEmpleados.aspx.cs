using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using EntidadesCompartidas;

public partial class ABMEmpleados : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
          Limpiar();
        }
    }
    private void Limpiar()
    {
        txtApellido.Text = string.Empty;
        txtContraseña.Text = string.Empty;
        txtNCompleto.Text = string.Empty;
        txtNombre.Text = string.Empty;
        txtUsuario.Text = string.Empty;

        btnAgregar.Enabled = false;
        btnEliminar.Enabled = false;
        btnModificar.Enabled = false;

        lblError.Text = string.Empty;
    }
    private void Encontrado()
    {
        btnModificar.Enabled = true;
        btnEliminar.Enabled = true;

        txtApellido.Enabled = true;
        txtContraseña.Enabled = true;
        txtNCompleto.Enabled = true;
        txtNombre.Enabled = true;
    }
    private void NoEncontrado()
    {
        lblError.Text = "Completa los datos para agregar al empleado";

        txtApellido.Enabled = true;
        txtContraseña.Enabled = true;
        txtNCompleto.Enabled = true;
        txtNombre.Enabled = true;

        btnAgregar.Enabled = true;
    }
    protected void btnLimpiar_Click(object sender, EventArgs e)
    {
        Limpiar();
    }
    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        try
        {
           // Empleado empleado = new Empleado(txtNombre.Text, txtContraseña, txtNCompleto.Text, txtApellido.Text, )

        }

        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }
    protected void btnModificar_Click(object sender, EventArgs e)
    {
        try
        {

        }

        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }

    }
    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        try
        {

        }

        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }

    }
    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        try
        {

        }

        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }

    }
}