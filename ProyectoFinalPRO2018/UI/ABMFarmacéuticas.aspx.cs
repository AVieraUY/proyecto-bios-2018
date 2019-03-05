using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntidadesCompartidas;
using Negocio;

public partial class ABMFarmacéuticas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!(Session["usuario"] is Empleado))
            Response.Redirect("Logueo.aspx");
        if (!IsPostBack)
        {
            Limpiar();
        }

    }
    private void Encontrado()
    {
        btnModificar.Enabled = true;
        btnEliminar.Enabled = true;
        btnAgregar.Enabled = false;

        txtCorreo.Enabled = true;
        txtDireccion.Enabled = true;
        txtNombre.Enabled = true;

    }
    private void NoEncontrado()
    {
        lblError.Text = "Complete los datos para agregar la farmacéutica";
        
        txtCorreo.Enabled = true;
        txtDireccion.Enabled = true;
        txtNombre.Enabled = true;

        btnAgregar.Enabled = true;
    }
    private void Limpiar()
    {
        txtCorreo.Text = string.Empty;
        txtDireccion.Text = string.Empty;
        txtNombre.Text = string.Empty;
        txtRuc.Text = string.Empty;
        
        lblError.Text = string.Empty;

        btnModificar.Enabled = false;
        btnEliminar.Enabled = false;
        btnAgregar.Enabled = false;

        txtCorreo.Enabled = false;
        txtDireccion.Enabled = false;
        txtNombre.Enabled = false;

    }
    
    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        lblError.Text = string.Empty;
        try
        {
            Farmaceutica f = negFarmaceutica.Buscar(Convert.ToInt64(txtRuc.Text));

            if (f == null)
            {
                NoEncontrado();
           
            }
            else
            {

                txtNombre.Text = f.Nombre;
                txtCorreo.Text = f.Correo;
                txtDireccion.Text = f.Direccion;

                Encontrado();
                Session["farmaceutica"] = f;
            }


        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }

    }


    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        lblError.Text = string.Empty;
        try
        {
            Farmaceutica f = new Farmaceutica(Convert.ToInt64(txtRuc.Text), txtNombre.Text, txtCorreo.Text, txtDireccion.Text);
            negFarmaceutica.Alta(f);

            lblError.Text = "Farmacéutica agregada con éxito";

            Session["farmaceutica"] = f;

            Limpiar();
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }


    protected void btnModificar_Click(object sender, EventArgs e)
    {
        lblError.Text = string.Empty;
        try
        {
            Farmaceutica f = (Farmaceutica)Session["farmaceutica"];

            f.Nombre = txtNombre.Text;
            f.Direccion = txtDireccion.Text;
            f.Correo = txtCorreo.Text;

            negFarmaceutica.Modificacion(f);

            lblError.Text = "Farmacéutica modificada con éxito";
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }


    }
    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        lblError.Text = string.Empty;
        try
        {
            Farmaceutica f = (Farmaceutica)Session["farmaceutica"];

            negFarmaceutica.Baja(f);
            Limpiar();
            lblError.Text = "Farmacéutica eliminada con éxito";
        }

        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }

    }
    protected void btnLimpiar_Click(object sender, EventArgs e)
    {
        Limpiar();
    }
}