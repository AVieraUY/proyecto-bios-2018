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
        //try
        //{
            Farmaceutica f = (Farmaceutica)Session["farmaceutica"];
            Medicamento m = negMedicamento.Buscar(f, Convert.ToInt32(grdMedicamentos.SelectedRow.Cells[1].Text));

            GridView1.DataSource = negPedido.ListarPorMedicamento(m);
            GridView1.DataBind();
            
        //}
        //catch (Exception ex)
        //{
        //    lblError.Text = ex.Message;
        //}
    }
}