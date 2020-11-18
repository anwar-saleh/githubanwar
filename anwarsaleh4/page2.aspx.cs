using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace anwarsaleh4
{
    public partial class page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string text = Request.QueryString.Get("text");
            Response.Write("welcome" + "  " + text);
            HttpCookie cookie = Request.Cookies["user info"];
            if (cookie != null)
            {
                Label1.Text = cookie["NAME"];
                Label2.Text = cookie["EMAIL"];
            }
            if (!IsPostBack)
            {
                TextBox0.Text = 0.ToString();
                Session["counter"] = 0;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Session["counter"]);
            Session["counter"] = x + 1;
            TextBox0.Text = Session["counter"].ToString();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}