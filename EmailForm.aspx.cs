using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

public partial class EmailForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string UserID = Session["UserID"].ToString();
        string EmailID = Session["EmailID"].ToString();
        txtFrom.Text = EmailID;
        txtFrom.Enabled = false;
    }
    protected void BtnSend_Click(object sender, EventArgs e)
    {

        string to = txtTo.Text;
        string from = txtFrom.Text;
        MailMessage message = new MailMessage(from, to);

        string mailbody = TxtBody.Text;
        message.Subject = TxtSubject.Text;
        message.Body = mailbody;
        //message.BodyEncoding = Encoding.UTF8;
        message.IsBodyHtml = true;

        using(SmtpClient client = new SmtpClient()) //Gmail smtp)
        {
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("akshay24314@gmail.com", "-------");
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
       
            

            client.Send(message);
        }
        
       
        
        
        try
        {
            
        }

        catch (Exception ex)
        {
            throw ex;
        }
    }

    public void SaveData()
    {
        string CONSTR = ConfigurationManager.ConnectionStrings["CONSTR"].ConnectionString;
        SqlConnection con = new SqlConnection(CONSTR);
        SqlCommand cmd = new SqlCommand("",con);


    }
}