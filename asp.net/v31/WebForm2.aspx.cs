using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace v31
{
	public partial class WebForm2 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			TextBox1.Text = Request.QueryString["id"];
			TextBox2.Text = Request.QueryString["name"];
            TextBox3.Text = Request.QueryString["age"];

        }
	}
}