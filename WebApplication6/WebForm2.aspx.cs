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
    public partial class WebForm2 : System.Web.UI.Page
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
         //   SqlCommand com = new SqlCommand();
         //   com.Connection = con;
         //   com.Parameters.AddWithValue("@x", TextBox3.Text);
         //   com.CommandText = "select * from final where Column1=@x";
         //   SqlDataAdapter da = new SqlDataAdapter(com);

         //DataSet ds = new DataSet();
         //   da.Fill(ds);  ds.Tables[0].Rows[0][2].ToString();


            string str = "dhanush";
            


            SqlCommand com2 = new SqlCommand();
            com2.Connection = con;
           
            com2.CommandText = "select * from routes1";
            SqlDataAdapter da2 = new SqlDataAdapter(com2);
            DataSet ds2 = new DataSet();
           
           
            da2.Fill(ds2);
            for (int i = 0; i <ds2.Tables[0].Rows.Count; i++)
		{
                 if(str==ds2.Tables[0].Rows[i][0].ToString())
                 {
                     Label1.Text = "Equal!!";
                 }
			 else
                {
                     Label1.Text = "Wrong!!";
                 }
			}

            //Label5.Text = ds.Tables[0].Rows[0][2].ToString();






        }
    }
}