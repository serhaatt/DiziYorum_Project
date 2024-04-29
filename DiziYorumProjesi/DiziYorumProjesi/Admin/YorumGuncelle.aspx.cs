using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProjesi.Entity;
namespace DiziYorumProjesi.Admin
{
    public partial class YorumGuncelle : System.Web.UI.Page
    {
        BlogDiziDbEntities db = new BlogDiziDbEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["YorumId"]);
            if (Page.IsPostBack == false)
            {
                var deger = db.TblYorum.Find(y);
                TxtBaslik.Text = deger.TblBlog.BlogBaslik;
                TxtKullanici.Text = deger.Kullanici;
                TxtYorum.Text = deger.YorumIcerik;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["YorumId"]);
            var yorum = db.TblYorum.Find(y);
            yorum.Kullanici = TxtKullanici.Text;
            yorum.YorumIcerik = TxtYorum.Text;
            db.SaveChanges();
            Response.Redirect("Yorumlar.aspx");
        }
    }
}