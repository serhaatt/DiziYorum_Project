using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProjesi.Entity;
namespace DiziYorumProjesi.Pages
{
    public partial class BlogDetay : System.Web.UI.Page
    {
        BlogDiziDbEntities db = new BlogDiziDbEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["BlogId"]);
            var blog = db.TblBlog.Where(x=>x.BlogId==id).ToList();
            Repeater1.DataSource = blog;
            Repeater1.DataBind();

            var yorumlar = db.TblYorum.Where(x=>x.YorumBlog == id).ToList();
            Repeater2.DataSource = yorumlar;
            Repeater2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["BlogId"]);
            TblYorum t = new TblYorum();
            t.Kullanici=TxtKullanici.Text;
            t.YorumIcerik=TxtYorum.Text;
            t.Mail=TxtMail.Text;
            t.YorumBlog = id;
            db.TblYorum.Add(t);
            db.SaveChanges();
            Response.Redirect("BlogDetay.Aspx?BlogId="+id);
        }
    }
}