using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace v10
{
	public partial class WebForm3 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ViewState["username"] != null)
            {
                TextBox1.Text = ViewState["username"].ToString();

            }
            if (ViewState["password"] != null)
            {

                TextBox2.Text = ViewState["password"].ToString();
            }
        }
    }
}