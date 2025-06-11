using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace v10
{
	public partial class WebForm2 : System.Web.UI.Page
	{
		
		protected void Page_Load(object sender, EventArgs e)
		{
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            ViewState["username"] = TextBox1.Text;
            ViewState["password"] = Password1.Text;

			TextBox1.Text = String.Empty;
            Password1.Text = String.Empty;

            Response.Redirect("WebForm3.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (ViewState["username"] !=null)
            {
            TextBox1.Text = ViewState["username"].ToString();

            }
            if (ViewState["password"] != null)
            {

            Password1.Text = ViewState["password"].ToString();
            }

        }

    }
}