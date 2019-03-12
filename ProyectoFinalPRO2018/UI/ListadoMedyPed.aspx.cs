using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntidadesCompartidas;
using Negocio;

public partial class ListadoMedyPed : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                ddl.DataSource = negFarmaceutica.Listar();
                ddl.DataTextField = "nombre";
                ddl.DataValueField = "ruc";
                ddl.DataBind();
           
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

    }
    protected void ddl_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            GridView1.Visible = false;
            ddlEstado.Visible = false;
            Farmaceutica f = negFarmaceutica.Buscar(Convert.ToInt64(ddl.SelectedValue));
            Session["farmaceutica"] = f;

            List<Medicamento> lm = negMedicamento.ListarPorFarmaceutica(f);

            grdMedicamentos.DataSource = lm;
            grdMedicamentos.DataBind();
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }
    protected void grdMedicamentos_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            GridView1.Visible = true;
            ddlEstado.SelectedIndex = 0;
            lblError.Text = string.Empty;
            Farmaceutica f = (Farmaceutica)Session["farmaceutica"];
            Medicamento m = negMedicamento.Buscar(f, Convert.ToInt32(grdMedicamentos.SelectedRow.Cells[1].Text));

            Session["m"] = m;
            GridView1.DataSource = negPedido.ListarPorMedicamento(m, "Todos");
            GridView1.DataBind();
            ddlEstado.Visible = true;
            if (negPedido.ListarPorMedicamento(m, "Todos").Count == 0)
            {
                ddlEstado.Visible = false;
                throw new Exception("No se encontraron pedidos de este medicamento");
            }


        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }
    protected void ddlEstado_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            Medicamento m = (Medicamento)Session["m"];

            if (ddlEstado.SelectedIndex == 0)
            {
                lblError.Text = string.Empty;
                List<Pedido> lp = negPedido.ListarPorMedicamento(m, "Todos");
                
                GridView1.DataSource = lp;
                GridView1.DataBind();

                if (lp.Count == 0)
                    throw new Exception("No se encontraron pedidos de este medicamento");
            }

            else if (ddlEstado.SelectedIndex == 1)
            {
                lblError.Text = string.Empty;
                List<Pedido> lp = negPedido.ListarPorMedicamento(m, "Generado");

                GridView1.DataSource = lp;
                GridView1.DataBind();


                if (lp.Count == 0)
                    throw new Exception("No se encontraron pedidos con estado generado de este medicamento");
            }

            else if (ddlEstado.SelectedIndex == 2)
            {
                lblError.Text = string.Empty;
                List<Pedido> lp = negPedido.ListarPorMedicamento(m, "Entregado");

                GridView1.DataSource = lp;
                GridView1.DataBind();


                if (lp.Count == 0)
                    throw new Exception("No se encontraron pedidos entregados de este medicamento");
            }
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }
}