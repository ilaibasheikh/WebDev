using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace v16
{
    public partial class Login : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs2"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from Login where username = @user and password = @pass"; // Consider hashing passwords
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@user", TextBox1.Text);
            cmd.Parameters.AddWithValue("@pass", TextBox2.Text);

            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    Session["user"] = TextBox1.Text;
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Login Successful');</script>");
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Login Failed');</script>");
                }
            }
            catch (Exception ex)
            {
                // Handle errors (you could log them if needed)
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('An error occurred: " + ex.Message + "');</script>");
            }
            finally
            {
                // Ensure the connection is always closed
                con.Close();
            }
        }
    }
}
