using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace v10
{
	public partial class WebForm4 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void Button1_Click(object sender, EventArgs e)
        {
			//Session.Add("user", TextBox1.Text);
			//Session["user"] = TextBox1.Text;
            Application["user"] = TextBox1.Text;
            Response.Redirect("WebForm5.aspx");
		}
    }
}