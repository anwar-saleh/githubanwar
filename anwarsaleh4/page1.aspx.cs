using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace anwarsaleh4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != TextBox2.Text)
            {
                TextBox2.Text = TextBox1.Text;
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("page2.aspx?text=" + TextBox2.Text);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ViewState["TEXT1"] = TextBox1.Text;
            ViewState["TEXT2"] = TextBox2.Text;
            TextBox1.Text = TextBox2.Text = "";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox1.Text = ViewState["TEXT1"].ToString();
            TextBox2.Text = ViewState["TEXT2"].ToString();
        }
    }
}