using DiziYorumProjesi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiziYorumProjesi.Pages
{
    public partial class KategoriDetay : System.Web.UI.Page
    {
        BlogDiziDbEntities db = new BlogDiziDbEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int key = Int32.Parse(Request.QueryString["KategoriId"]);
            var bloglar = db.TblBlog.Where(x=>x.BlogKategori==key).ToList();
            Repeater1.DataSource = bloglar;
            Repeater1.DataBind();

            var Kategoriler = db.TblKategori.ToList();
            Repeater2.DataSource = Kategoriler;
            Repeater2.DataBind();

            var BlogBaşlıklar = db.TblBlog.ToList();
            Repeater3.DataSource = BlogBaşlıklar;
            Repeater3.DataBind();
        }
    }
}