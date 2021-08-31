using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text.Length == 0 || TextBox2.Text.Length == 0)
        {
            Label3.Text = "Пожалуйста, заполните все поля!";
        }
        else
            if (TextBox1.Text.Length >= 5)
            {
            Application["Name"] = TextBox2.Text.ToString();
            Application["Mail"] = TextBox1.Text.ToString();

            Response.Redirect("Default.aspx?TextBox2.Text=" + TextBox2.Text.ToString());
            Server.Transfer("Default.aspx", true);
            }   
        else
            Label3.Text = "Некоректный e-mail!";
    }
}