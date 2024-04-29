using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProjesi.Entity;
namespace DiziYorumProjesi
{
    public partial class Default : System.Web.UI.Page
    {
        BlogDiziDbEntities db = new BlogDiziDbEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var bloglar = db.TblBlog.ToList();
            Repeater1.DataSource = bloglar;
            Repeater1.DataBind();

            var Kategoriler = db.TblKategori.ToList();
            Repeater2.DataSource = Kategoriler;
            Repeater2.DataBind();

            var BlogBaşlıklar = db.TblBlog.ToList();
            BlogBaşlıklar.Reverse();
            Repeater3.DataSource = BlogBaşlıklar.Take(4);
            Repeater3.DataBind();

            var Yorumlar = db.TblYorum.ToList();
            Yorumlar.Reverse();
            Repeater4.DataSource = Yorumlar.Take(5);
            Repeater4.DataBind();
        }
    }
}