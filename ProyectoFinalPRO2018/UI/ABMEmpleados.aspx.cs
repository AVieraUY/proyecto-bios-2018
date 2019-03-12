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
        if  (!(Session["usuario"] is Empleado))
            Response.Redirect("Logueo.aspx");
        if (!IsPostBack)
        {
          Limpiar();
        }  
     
    }
    private void Limpiar()
    {
        txtApellido.Text = string.Empty;
        txtContraseña.Text = string.Empty;
        txtNombre.Text = string.Empty;
        txtUsuario.Text = string.Empty;
        txtHIngreso1.Text = string.Empty;
        txtHoraIngreso2.Text = string.Empty;
        txtHSalida.Text = string.Empty;
        txtHSalida2.Text = string.Empty;

        btnAgregar.Enabled = false;
        btnEliminar.Enabled = false;
        btnModificar.Enabled = false;

        txtApellido.Enabled = false;
        txtContraseña.Enabled = false;
        txtContraseña0.Enabled = false;
        txtNombre.Enabled = false;
        txtHIngreso1.Enabled = false;
        txtHoraIngreso2.Enabled = false;
        txtHSalida.Enabled = false;
        txtHSalida2.Enabled = false;

        lblError.Text = string.Empty;
    }
    private void Encontrado()
    {
        btnModificar.Enabled = true;
        btnEliminar.Enabled = true;

        txtApellido.Enabled = true;
        txtContraseña.Enabled = true;
        txtContraseña0.Enabled = true;
        txtNombre.Enabled = true;
        txtHIngreso1.Enabled = true;
        txtHoraIngreso2.Enabled = true;
        txtHSalida.Enabled = true;
        txtHSalida2.Enabled = true;
    }
    private void NoEncontrado()
    {
        lblError.Text = "Completa los datos para agregar al empleado";

        txtApellido.Enabled = true;
        txtContraseña.Enabled = true;
        txtContraseña0.Enabled = true;
        txtNombre.Enabled = true;
        txtHIngreso1.Enabled = true;
        txtHoraIngreso2.Enabled = true;
        txtHSalida.Enabled = true;
        txtHSalida2.Enabled = true;

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
            if (Convert.ToInt32(txtHIngreso1.Text) > 60 || Convert.ToInt32(txtHSalida.Text) > 60 || Convert.ToInt32(txtHSalida2.Text) > 23 || Convert.ToInt32(txtHoraIngreso2.Text) > 23)
                throw new Exception("Hora inválida");

            Empleado emp = new Empleado(txtUsuario.Text, txtContraseña.Text,txtNombre.Text, txtApellido.Text, (txtHIngreso1.Text + ":" + txtHoraIngreso2.Text), txtHSalida.Text + ":" + txtHSalida2.Text);

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
            if (Convert.ToInt32(txtHIngreso1.Text) > 60 || Convert.ToInt32(txtHSalida.Text) > 60 || Convert.ToInt32(txtHSalida2.Text) > 23 || Convert.ToInt32(txtHoraIngreso2.Text) > 23)
                throw new Exception("Hora inválida");
            Empleado emp = (Empleado)Session["empleado"];

            emp.Apellido = txtApellido.Text;
            emp.HoraFin = txtHSalida.Text + ":" + txtHSalida2.Text;
            emp.HoraInicio = txtHIngreso1.Text + ":" + txtHoraIngreso2.Text;
            emp.Nombre = txtNombre.Text;
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
               txtHSalida.Text = emp.HoraFin.Substring(0, 2);
               txtHSalida2.Text = emp.HoraFin.Substring(3);
               txtHIngreso1.Text = emp.HoraInicio.Substring(0,2);
               txtHoraIngreso2.Text = emp.HoraInicio.Substring(3);
               txtNombre.Text = emp.Nombre;
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
    protected void txtHIngreso2_TextChanged(object sender, EventArgs e)
    {

    }
}