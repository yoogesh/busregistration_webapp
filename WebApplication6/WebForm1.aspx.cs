using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using System.Data;
using System.Data.SqlClient;
namespace WebApplication6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "Server=tcp:sbk02zodz4.database.windows.net,1433;Database=yoodb;User ID=chinni@sbk02zodz4;Password=Yoogiethegreat1;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;";
            SqlConnection con = new SqlConnection();

            con.ConnectionString = s;
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.Parameters.AddWithValue("@name", TextBox1.Text);
            com.Parameters.AddWithValue("@email", TextBox2.Text);
            com.CommandText = "insert into final values(@name,@email)";
            
          
           int i=  com.ExecuteNonQuery();
    
        }

        protected void Button2_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }

                
        
    }
}