using System;
using System.Web.Services;

namespace v38
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Any page load logic can be placed here
        }

        // WebMethod to handle the AJAX request
        [WebMethod]
        public static string GetData(string uname, string surname)
        {
            // Return a message with the provided name and surname
            return "Your name is " + uname + " and surname is " + surname;
        }
    }
}
