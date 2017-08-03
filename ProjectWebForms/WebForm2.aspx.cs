using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectWebForms.ServiceReference1;

namespace ProjectWebForms
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Service1Client o = new Service1Client();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int CustomerId = Convert.ToInt32(TextBox1.Text);
            string CustorName = TextBox2.Text;
            string Address = TextBox3.Text;

            o.AddCustomer(CustomerId, CustorName, Address);
            Response.Redirect("WebForm1.aspx");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int CustomerId = Convert.ToInt32(TextBox1.Text);
            string CustorName = TextBox2.Text;
            string Address = TextBox3.Text;

            o.UpdateCustomer(CustomerId, CustorName, Address);
            Response.Redirect("WebForm1.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int CustomerId = Convert.ToInt32(TextBox1.Text);
            o.DeleteUserById(CustomerId);
            Response.Redirect("WebForm1.aspx");
        }
    }
}