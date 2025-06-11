using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace v10
{
	public partial class WebForm6 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (Application["user"] != null)
            {
                Response.Write("Welome " + Application["user"].ToString());
            }
            else
            {
                Response.Redirect("WebForm4.aspx");
            }

        }
	}
}