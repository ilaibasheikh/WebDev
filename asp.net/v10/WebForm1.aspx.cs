using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace v10
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (IsPostBack)
			{
				Response.Write("This is postback request");
				//AddListBoxItems();

			}
			if (!IsPostBack)
            {
                Response.Write("This is not postback request");
                AddListBoxItems();


            }
        }
		void AddListBoxItems (){
            ListBox1.Items.Add("Item 1");
            ListBox1.Items.Add("Item 2");
            ListBox1.Items.Add("Item 3");
        }
	}
}