using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntidadesCompartidas;
using Negocio;

public partial class ABMMedicamentos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            Limpiar();
    }

    private void Limpiar()
    {
         txtPrecio.Text = string.Empty;
         txtNombre.Text = string.Empty;
         txtDescripcion.Text = string.Empty;
         txtCodigo.Text = string.Empty;
         txtRuc.Text = string.Empty;

         btnAgregar.Enabled = false;
         txtPrecio.Enabled = false;
         txtNombre.Enabled = false;
         txtDescripcion.Enabled = false;

         txtPrecio.Enabled = false;
         txtNombre.Enabled = false;
         txtDescripcion.Enabled = false;

         lblError.Text = string.Empty;
    }

    private void Encontrado()
    {
        txtPrecio.Enabled = true;
        txtNombre.Enabled = true;
        txtDescripcion.Enabled = true;

        btnEliminar.Enabled = true;
        btnModificar.Enabled = true;
    }

    private void NoEncontrado()
    {
        lblError.Text = "Complete los datos para agregar ell medicamento";
        btnAgregar.Enabled = true;
        txtPrecio.Enabled = true;
        txtNombre.Enabled = true;
        txtDescripcion.Enabled = true;
    }
    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        lblError.Text = string.Empty;
        try
        {
            Farmaceutica f = negFarmaceutica.Buscar(Convert.ToInt64(txtRuc.Text));

            Medicamento m = negMedicamento.Buscar(f, Convert.ToInt32(txtCodigo.Text));

            if (m == null)
            {
                NoEncontrado();
            }
            else
            {
                txtNombre.Text = m.Nombre;
                txtDescripcion.Text = m.Descripcion;
                txtPrecio.Text = m.Precio.ToString();
                Encontrado();

                Session["medicamento"] = m;
            }
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
    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        try
        {
            Farmaceutica f = negFarmaceutica.Buscar(Convert.ToInt64(txtRuc.Text));
            Medicamento m = new Medicamento(f, Convert.ToInt32(txtCodigo.Text), txtNombre.Text.ToString(), txtDescripcion.Text.ToString(), Convert.ToDecimal(txtPrecio.Text));

            negMedicamento.Alta(m);

            lblError.Text = "Medicamento agregado con éxito";

            Session["medicamento"] = m;

            Encontrado();
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
            
            Medicamento m = (Medicamento)Session["medicamento"];

            m.Precio = Convert.ToDecimal(txtPrecio.Text);
            m.Nombre = txtNombre.Text.ToString();
            m.Descripcion = txtDescripcion.Text.ToString();

            negMedicamento.Modificacion(m);

            lblError.Text = "Medicamento modificado con éxito";
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
            Medicamento m = (Medicamento)Session["medicamento"];

            negMedicamento.Baja(m);

            Limpiar();
            lblError.Text = "Medicamento eliminado con éxito";
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }

    }
}