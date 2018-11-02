using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WA_ASP_MVC.VISTA
{
    public partial class FEmployee : System.Web.UI.Page
    {
        CONTROLADOR.CEmployee objEmployee = new CONTROLADOR.CEmployee();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack==false)
            {
                ListarPedido();
            }
        }

        void ListarPedido()
        {
            DropDownList1.DataSource = objEmployee.ListarEmployees();
            DropDownList1.DataTextField = "FirstName";
            DropDownList1.DataValueField = "EmployeeID";
            DropDownList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = DropDownList1.SelectedValue.ToString();
            GridView1.DataSource = objEmployee.ListaPedidosEmployee(txtCodigo.Text);
            GridView1.DataBind();
        }
    }
}