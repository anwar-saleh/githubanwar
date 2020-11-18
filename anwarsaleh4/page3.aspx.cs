using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace anwarsaleh4
{
    public partial class page3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("user info");
            cookie["NAME"] = TextBox1.Text;
            cookie["EMAIL"] = TextBox2.Text;
            Response.Cookies.Add(cookie);
            Response.Redirect("page2.aspx");
        }
    }
}