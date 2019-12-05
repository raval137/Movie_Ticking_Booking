using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{

    HttpCookie warcookie;
    string ConnectionString;
    SqlConnection cnn;
    SqlDataAdapter dataAdapter = new SqlDataAdapter();
    SqlDataReader dataReader;
    SqlCommand command;
    String sql, Output = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        warcookie = Request.Cookies["ExtraInfo"];
        Label3.Text = warcookie["Time"];

        cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= C:\Users\JD\source\repos\App_Data\Database.mdf;Integrated Security=True");
        cnn.Open();
        if (warcookie["ID"] == "1")
        {
            sql = "SELECT seatnumber FROM SeatData WHERE movieid='war1'";
        }
        else if(warcookie["ID"] == "2")
        {
            sql = "SELECT seatnumber FROM SeatData WHERE movieid='war2'";
        }
        command = new SqlCommand(sql, cnn);
        dataReader = command.ExecuteReader();
        while (dataReader.Read())
        {
            Output = Output + dataReader.GetValue(0);
        }
        command.Dispose();
        cnn.Close();

        String s = Output;
        int n = s.Length;
        for (int o = 0; o < n; o++)
        {
            switch (s[o])
            {
                case '1': ImageButton1.Enabled = false; ImageButton1.BackColor = System.Drawing.Color.Red; break;
                case '2': ImageButton2.Enabled = false; ImageButton2.BackColor = System.Drawing.Color.Red; break;
                case '3': ImageButton3.Enabled = false; ImageButton3.BackColor = System.Drawing.Color.Red; break;

                case '4': ImageButton4.Enabled = false; ImageButton4.BackColor = System.Drawing.Color.Red; break;
                case '5': ImageButton5.Enabled = false; ImageButton5.BackColor = System.Drawing.Color.Red; break;
                case '6': ImageButton6.Enabled = false; ImageButton6.BackColor = System.Drawing.Color.Red; break;

                case '7': ImageButton7.Enabled = false; ImageButton7.BackColor = System.Drawing.Color.Red; break;
                case '8': ImageButton8.Enabled = false; ImageButton8.BackColor = System.Drawing.Color.Red; break;
                case '9': ImageButton9.Enabled = false; ImageButton9.BackColor = System.Drawing.Color.Red; break;
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
        String str1 = "";
        if (warcookie["ID"] == "1")
        {
            str1 = "UPDATE SeatData SET seatnumber='"+Label1.Text.Replace(" ","")+"' WHERE movieid='war1'";
        }
        else if (warcookie["ID"] == "2")
        {
            str1 = "UPDATE SeatData SET seatnumber='" + Label1.Text.Replace(" ", "") + "' WHERE movieid='war2'";
        }
        cnn.Open();
        command = new SqlCommand(str1, cnn);
        dataAdapter.UpdateCommand = new SqlCommand(str1, cnn);
        dataAdapter.UpdateCommand.ExecuteNonQuery();
        command.Dispose();
        

        HttpCookie detail = new HttpCookie("FullInfo");
        detail["Movie"] = "WAR";
        detail["Time"] = warcookie["Time"];
        detail["Seats"] = Label1.Text.Replace(" ",", ").Substring(0, (Label1.Text).Length + 1);
        detail["Amount"] = Label2.Text;
        Response.Cookies.Add(detail);
        Response.Redirect("~/Default6.aspx");
        cnn.Close();
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Boolean result = Label1.Text.Contains("1 ");

        if(result)
        {
            Label1.Text = Label1.Text.Replace("1 ","");
            Label2.Text = (Convert.ToInt32(Label2.Text) - 150).ToString();
            ImageButton1.BackColor = System.Drawing.Color.Green;
        }
        else
        {
            Label1.Text = Label1.Text + "1 ";
            Label2.Text = (Convert.ToInt32(Label2.Text) + 150).ToString();
            ImageButton1.BackColor = System.Drawing.Color.Yellow;
        }

    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Boolean result = Label1.Text.Contains("2 ");

        if (result)
        {
            Label1.Text = Label1.Text.Replace("2 ", "");
            Label2.Text = (Convert.ToInt32(Label2.Text) - 150).ToString();
            ImageButton2.BackColor = System.Drawing.Color.Green;
        }
        else
        {
            Label1.Text = Label1.Text + "2 ";
            Label2.Text = (Convert.ToInt32(Label2.Text) + 150).ToString();
            ImageButton2.BackColor = System.Drawing.Color.Yellow;
        }
    }

    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        Boolean result = Label1.Text.Contains("3 ");

        if (result)
        {
            Label1.Text = Label1.Text.Replace("3 ", "");
            Label2.Text = (Convert.ToInt32(Label2.Text) - 150).ToString();
            ImageButton3.BackColor = System.Drawing.Color.Green;
        }
        else
        {
            Label1.Text = Label1.Text + "3 ";
            Label2.Text = (Convert.ToInt32(Label2.Text) + 150).ToString();
            ImageButton3.BackColor = System.Drawing.Color.Yellow;
        }
    }

    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        Boolean result = Label1.Text.Contains("4 ");

        if (result)
        {
            Label1.Text = Label1.Text.Replace("4 ", "");
            Label2.Text = (Convert.ToInt32(Label2.Text) - 150).ToString();
            ImageButton4.BackColor = System.Drawing.Color.Green;
        }
        else
        {
            Label1.Text = Label1.Text + "4 ";
            Label2.Text = (Convert.ToInt32(Label2.Text) + 150).ToString();
            ImageButton4.BackColor = System.Drawing.Color.Yellow;
        }
    }

    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {
        Boolean result = Label1.Text.Contains("5 ");

        if (result)
        {
            Label1.Text = Label1.Text.Replace("5 ", "");
            Label2.Text = (Convert.ToInt32(Label2.Text) - 150).ToString();
            ImageButton5.BackColor = System.Drawing.Color.Green;
        }
        else
        {
            Label1.Text = Label1.Text + "5 ";
            Label2.Text = (Convert.ToInt32(Label2.Text) + 150).ToString();
            ImageButton5.BackColor = System.Drawing.Color.Yellow;
        }
    }

    protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
    {
        Boolean result = Label1.Text.Contains("6 ");

        if (result)
        {
            Label1.Text = Label1.Text.Replace("6 ", "");
            Label2.Text = (Convert.ToInt32(Label2.Text) - 150).ToString();
            ImageButton6.BackColor = System.Drawing.Color.Green;
        }
        else
        {
            Label1.Text = Label1.Text + "6 ";
            Label2.Text = (Convert.ToInt32(Label2.Text) + 150).ToString();
            ImageButton6.BackColor = System.Drawing.Color.Yellow;
        }
    }

    protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
    {
        Boolean result = Label1.Text.Contains("7 ");

        if (result)
        {
            Label1.Text = Label1.Text.Replace("7 ", "");
            Label2.Text = (Convert.ToInt32(Label2.Text) - 150).ToString();
            ImageButton7.BackColor = System.Drawing.Color.Green;
        }
        else
        {
            Label1.Text = Label1.Text + "7 ";
            Label2.Text = (Convert.ToInt32(Label2.Text) + 150).ToString();
            ImageButton7.BackColor = System.Drawing.Color.Yellow;
        }
    }

    protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
    {
        Boolean result = Label1.Text.Contains("8 ");

        if (result)
        {
            Label1.Text = Label1.Text.Replace("8 ", "");
            Label2.Text = (Convert.ToInt32(Label2.Text) - 150).ToString();
            ImageButton8.BackColor = System.Drawing.Color.Green;
        }
        else
        {
            Label1.Text = Label1.Text + "8 ";
            Label2.Text = (Convert.ToInt32(Label2.Text) + 150).ToString();
            ImageButton8.BackColor = System.Drawing.Color.Yellow;
        }
    }

    protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
    {
        Boolean result = Label1.Text.Contains("9 ");

        if (result)
        {
            Label1.Text = Label1.Text.Replace("9 ", "");
            Label2.Text = (Convert.ToInt32(Label2.Text) - 150).ToString();
            ImageButton9.BackColor = System.Drawing.Color.Green;
        }
        else
        {
            Label1.Text = Label1.Text + "9 ";
            Label2.Text = (Convert.ToInt32(Label2.Text) + 150).ToString();
            ImageButton9.BackColor = System.Drawing.Color.Yellow;
        }
    }
}