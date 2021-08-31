using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string Mail = Application["Mail"].ToString();
        string res = Application["res"].ToString();
        Label6.Text = Request.QueryString["id"];
        Label2.Text = (Mail + "?");
        Label5.Text = ("Количество правильных ответов: " + res + "/10 ");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string res = Application["res"].ToString();
        string result = (res + "/10 правильных ответов. Поздравляем!");
        string Mail = Application["Mail"].ToString();
        string Name = Application["Name"].ToString();
        MailMessage o = new MailMessage("asp-net-obolkin@hotmail.com", Mail, "Прохождение теста по \"ASP.NET\"", Name + ", Вы прошли тест по дисциплине \"ASP.NET\"! Ваш результат: " + result);
        NetworkCredential netCred = new NetworkCredential("asp-net-obolkin@hotmail.com", "Obolkin123");
        SmtpClient smtpobj = new SmtpClient("smtp-mail.outlook.com", 587);
        smtpobj.EnableSsl = true;
        smtpobj.Credentials = netCred;
        smtpobj.Send(o);
    }
}