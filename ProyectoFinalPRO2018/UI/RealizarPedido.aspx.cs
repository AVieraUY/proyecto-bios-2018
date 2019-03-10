using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using EntidadesCompartidas;

public partial class RealizarPedido : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["usuario"] is Empleado)
            Response.Redirect("BienvenidaEmpleado.aspx");
        else if(!(Session["usuario"] is Cliente))
            Response.Redirect("Logueo.aspx");
        try
        {
            grdMeds.DataSource =  negMedicamento.Listar();
            grdMeds.DataBind();

        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }


    }
    protected void grdMeds_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            lblPrecio.Visible = false;
            BtnPedir.Visible = false;
            txtCantidad.Text = string.Empty;

            Medicamento med = negMedicamento.Listar()[grdMeds.SelectedRow.RowIndex];
            Session["med"] = med;
            List<Medicamento> lm = new List<Medicamento>();
            lm.Add(med);

            grd1Med.DataSource = lm;
            grd1Med.DataBind();

            Label1.Visible = true;
            txtCantidad.Visible = true;
            btnListo.Visible = true;
        }
     
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }

    }
    protected void grd1Med_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void btnListo_Click(object sender, EventArgs e)
    {
        Medicamento med = (Medicamento)Session["med"];
        lblPrecio.Visible = true;
        BtnPedir.Visible = true;
        lblPrecio.Text = "Se realizará un pedido de " + txtCantidad.Text + " " + med.Nombre + " por $" +((Convert.ToDecimal(txtCantidad.Text) * Convert.ToDecimal(med.Precio)).ToString());
    }
    protected void BtnPedir_Click(object sender, EventArgs e)
    {
        try
        {
            Medicamento med = (Medicamento)Session["med"];
            Cliente cli = (Cliente)Session["usuario"];

            Pedido pe = new Pedido(med, cli, 1, Convert.ToInt32(txtCantidad.Text), "Generado");

            negPedido.Alta(pe);

            lblError.Text = "Pedido realizado con éxito";

            Label1.Visible = false;
            txtCantidad.Visible = false;
            btnListo.Visible = false;
            lblPrecio.Visible = false;
            BtnPedir.Visible = false;
            grd1Med.Visible = false;

        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }
}