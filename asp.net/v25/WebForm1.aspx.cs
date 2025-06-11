using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace v25
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				BindDropDownList();
			}
		}
		void BindDropDownList()
		{
			SqlConnection con = new SqlConnection(cs);
			String query = "Select * from employee";
			SqlDataAdapter sda = new SqlDataAdapter(query, con);
			DataTable data = new DataTable();	
			sda.Fill(data);
			DropDownList1.DataSource = data;
			DropDownList1.DataTextField = "name";
            DropDownList1.DataValueField = "id";
            DropDownList1.DataBind();

			ListItem listItem = new ListItem("Select employee", "-1");	
			listItem.Selected = true;
			DropDownList1.Items.Insert(0,listItem);
		}

        protected void Button1_Click(object sender, EventArgs e)
        {
			if (DropDownList1.SelectedValue == "-1")
			{
				Response.Write("Select an employee");
			}
			else
			{
				//Response.Write("Selected employee is, " +DropDownList1.SelectedItem.Text);
				//Response.Write("Select  employee value is,  " + DropDownList1.SelectedItem.Value);
				//Response.Write("Select  employee index  is " + DropDownList1.SelectedIndex);
				SqlConnection con = new SqlConnection(cs);
                String query = "Select * from employee where name = @name ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
				sda.SelectCommand.Parameters.AddWithValue("@name", DropDownList1.SelectedItem.Text);
                DataTable data = new DataTable();
                sda.Fill(data);
                GridView1.DataSource = data;
                
                GridView1.DataBind();

                
            }
        }
    }
}