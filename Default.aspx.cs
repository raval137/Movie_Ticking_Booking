using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void war1_Click(object sender, EventArgs e)
    {
        HttpCookie war1cookie = new HttpCookie("ExtraInfo");
        war1cookie["Time"] = war1.Text;
        war1cookie["ID"] = "1";
        Response.Cookies.Add(war1cookie);
        Response.Redirect("~/Default2.aspx");
    }

    protected void war2_Click(object sender, EventArgs e)
    {
        HttpCookie war2cookie = new HttpCookie("ExtraInfo");
        war2cookie["Time"] = war2.Text;
        war2cookie["ID"] = "2";
        Response.Cookies.Add(war2cookie);
        Response.Redirect("~/Default2.aspx");
    }

    protected void joker1_Click(object sender, EventArgs e)
    {
        HttpCookie joker1cookie = new HttpCookie("ExtraInfo");
        joker1cookie["Time"] = joker1.Text;
        joker1cookie["ID"] = "1";
        Response.Cookies.Add(joker1cookie);
        Response.Redirect("~/Default4.aspx");
    }

    protected void joker2_Click(object sender, EventArgs e)
    {
        HttpCookie joker2cookie = new HttpCookie("ExtraInfo");
        joker2cookie["Time"] = joker2.Text;
        joker2cookie["ID"] = "2";
        Response.Cookies.Add(joker2cookie);
        Response.Redirect("~/Default4.aspx");
    }
}