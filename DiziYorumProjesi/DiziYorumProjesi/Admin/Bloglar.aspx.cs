using DiziYorumProjesi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiziYorumProjesi.Admin
{
    public partial class Bloglar : System.Web.UI.Page
    {
        BlogDiziDbEntities db = new BlogDiziDbEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Kullanıcı"]==null)
            {
                Response.Redirect("~/Login.aspx");
            }
            else
            {
                Label1.Text = "Giriş Yapan: " + Session["Kullanıcı"].ToString();
            }
            Repeater1.DataSource = db.TblBlog.ToList();
            Repeater1.DataBind();
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}