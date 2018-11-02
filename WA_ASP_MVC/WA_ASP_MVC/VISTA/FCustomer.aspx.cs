using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WA_ASP_MVC.VISTA
{
    public partial class FCustomer : System.Web.UI.Page
    {
        CONTROLADOR.CCustomer objCustomer = new CONTROLADOR.CCustomer();


        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack==false)
            {
                ListarCustomerCBX();
            }
        }
    
        void ListarCustomerCBX()
        {
            DropDownList1.DataSource = objCustomer.ListaCustomers();
            DropDownList1.DataTextField = "CompanyName";
            DropDownList1.DataValueField = "CustomerID";
            DropDownList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = DropDownList1.SelectedValue.ToString();
            GridView1.DataSource = objCustomer.ListaPedidos(txtCodigo.Text);
            GridView1.DataBind();
        }
    
    
    }
}