﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace v20
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}
		protected void LinkButton1_Click(object sender, EventArgs e)
		{
			SqlDataSource1.InsertParameters["name"].DefaultValue = ((TextBox)
				GridView1.FooterRow.FindControl("TextBox6")).Text;

            SqlDataSource1.InsertParameters["gender"].DefaultValue = ((DropDownList)
                GridView1.FooterRow.FindControl("DropDownList2")).SelectedValue;

            SqlDataSource1.InsertParameters["class"].DefaultValue = ((TextBox)
                GridView1.FooterRow.FindControl("TextBox7")).Text;

            SqlDataSource1.Insert();

            //int a = SqlDataSource1.Insert();
            //if (a>0)
            //{
            //	Page.ClientScript.RegisterStartupScript(this.GetType, "Scripts", "<script>alert('Insertion Successful')</script>");
            //}
            //else
            //{
            //	Page.ClientScript.RegisterStartupScript(this.GetType, "Scripts", "<script>alert('Insertion Failed')</script>");


            //         }
        }

    }
}