﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace v2
{
	public partial class WebForm4 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void Button1_Click(object sender, EventArgs e)
        {
			Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts","<script> alert('Form Submitted')</script>"); 
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (RadioButton1.Checked || RadioButton2.Checked)
            {
               args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }
    }
}