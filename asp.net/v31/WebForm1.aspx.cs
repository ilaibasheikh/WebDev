using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Reflection.Emit;
using Label = System.Web.UI.WebControls.Label;

namespace v31
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				bindgridview(); 
			}

		}
		void bindgridview()
		{
			SqlConnection con =new SqlConnection(cs);
			string query = "Select * from tb1";
			SqlDataAdapter sda = new SqlDataAdapter(query, con);
			DataTable data = new DataTable();
			sda.Fill(data);
			GridView1.DataSource = data;
			GridView1.DataBind();	
		}

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
			GridViewRow row = GridView1.SelectedRow;
			Label lblid =(Label)row.FindControl("Labelid");
            Label lblname = (Label)row.FindControl("Labelname");
            Label lblage = (Label)row.FindControl("Labelage");

			Response.Redirect("WebForm2.aspx?id="+lblid.Text+"&name="+lblname.Text+ "&age=" + lblage.Text );
        }
    }
}