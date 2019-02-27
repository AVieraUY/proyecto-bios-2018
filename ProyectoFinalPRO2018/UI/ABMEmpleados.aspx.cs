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
        txtHIngreso.Text = string.Empty;
        txtHSalida.Text = string.Empty;

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
        txtHIngreso.Enabled = true;
        txtHSalida.Enabled = true;
    }
    private void NoEncontrado()
    {
        lblError.Text = "Completa los datos para agregar al empleado";

        txtApellido.Enabled = true;
        txtContraseña.Enabled = true;
        txtNCompleto.Enabled = true;
        txtNombre.Enabled = true;
        txtHIngreso.Enabled = true;
        txtHSalida.Enabled = true;

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
            Empleado emp = new Empleado(txtNombre.Text, txtContraseña.Text, txtNCompleto.Text, txtApellido.Text, txtHIngreso.Text, txtHSalida.Text);

            negUsuario.Alta(emp);
            lblError.Text = "Empleado agregado con éxito";

            Session["empleado"] = emp;

            Limpiar();
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
            Empleado emp = (Empleado)Session["empleado"];

            emp.Apellido = txtApellido.Text;
            emp.HoraFin = txtHSalida.Text;
            emp.HoraInicio = txtHIngreso.Text;
            emp.Nombre = txtNombre.Text;
            emp.NombreCompleto = txtNCompleto.Text;
            emp.Password = txtContraseña.Text;
            emp.Username = txtUsuario.Text;

            negUsuario.Modificacion(emp);
            lblError.Text = "Empleado modificado con éxito";
            
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
           Empleado emp = (Empleado)negUsuario.Buscar(txtUsuario.Text);

           if (emp == null)
           {
               NoEncontrado();
           }
           else
           {
               txtApellido.Text = emp.Apellido;
               txtHSalida.Text = emp.HoraFin;
               txtHIngreso.Text = emp.HoraInicio;
               txtNombre.Text = emp.Nombre;
               txtNCompleto.Text = emp.NombreCompleto;
               txtContraseña.Text = emp.Password;
               txtUsuario.Text = emp.Username;
              
               Encontrado();
               Session["empleado"] = emp;
           }

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
            Empleado emp = (Empleado)Session["empleado"];
            negUsuario.Baja(emp);
            Limpiar();
            lblError.Text = "Empleado eliminado con éxito";
            
        }

        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }

    }
}