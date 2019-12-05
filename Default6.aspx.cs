using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default6 : System.Web.UI.Page
{
    SqlConnection cnn;
    SqlDataAdapter dataAdapter = new SqlDataAdapter();
    SqlDataReader dataReader;
    SqlCommand command;
    String FirstName;
    String LastName;
    String PhoneNumber;
    String Email;
    String CardNumber;
    HttpCookie myCookie;

    protected void Page_Load(object sender, EventArgs e)
    {
        myCookie = Request.Cookies["FullInfo"];
        Label1.Text = myCookie["Movie"];
        Label2.Text = myCookie["Time"];
        Label3.Text = myCookie["Seats"];
        Label4.Text = myCookie["Amount"];
        
        cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= C:\Users\JD\source\repos\App_Data\Database.mdf;Integrated Security=True");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        FirstName = TextBox1.Text;
        LastName = TextBox2.Text;
        PhoneNumber = TextBox3.Text;
        Email = TextBox4.Text;
        CardNumber = TextBox5.Text.Substring(12, 4);
        String str1 = "";
        str1 = "INSERT INTO CustomerInfo VALUES('" + FirstName + "','" + LastName + "','" + PhoneNumber + "','" + Email + "','" + CardNumber + "','" + myCookie["Movie"] + "','" + myCookie["Time"] + "','" + myCookie["Seats"] + "','" + myCookie["Amount"] + "')";

        cnn.Open();
        command = new SqlCommand(str1, cnn);
        dataAdapter.InsertCommand = new SqlCommand(str1, cnn);
        dataAdapter.InsertCommand.ExecuteNonQuery();
        command.Dispose();
        cnn.Close();

        Response.Redirect("~/Default.aspx");
    }
}