using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class Login : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void BtnLogin_Click(object sender, EventArgs e)
    {
        string UID = TxtUserID.Text;
        string Password = TxtPass.Text;

        string CONSTR = ConfigurationManager.ConnectionStrings["CONSTR"].ConnectionString;
        SqlConnection con = new SqlConnection(CONSTR);

        SqlCommand cmd = new SqlCommand("select * from UserLogin where UserID = @userID and Password = @Password", con);
        cmd.Parameters.AddWithValue("@userID", UID);
        cmd.Parameters.AddWithValue("@Password", Password);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();

        sda.Fill(dt);

       

        con.Open();
         SqlDataReader Dr = cmd.ExecuteReader();
        while(Dr.Read())
        {
            Session["UserID"] = Dr["UserID"].ToString();
            Session["EmailID"] = Dr["EmailD"].ToString();
        }

        Dr.Close();

        int i = cmd.ExecuteNonQuery();
        con.Close();

        if (dt.Rows.Count > 0)
        {
            Response.Redirect("EmailForm.aspx");
        }
        else
        {

            LBLText.Text = "Your username and word is incorrect";
            LBLText.ForeColor = System.Drawing.Color.Red;

        }  
    }

   
}