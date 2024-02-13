using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EsercizioW32
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = $"Ciao {Request.Cookies["infoCookie"]["nomeUtente"]}";
        }

        protected void LogOut_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("infoCookie");
            cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cookie);
            Response.Redirect("~/Login.aspx");
        }
    }
}