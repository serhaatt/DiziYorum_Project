using DiziYorumProjesi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiziYorumProjesi.Admin
{
    public partial class BlogGuncelle : System.Web.UI.Page
    {
        BlogDiziDbEntities db = new BlogDiziDbEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["BlogId"]);
            if (Page.IsPostBack == false)
            {
                var turler = (from x in db.TblTur
                              select new
                              {
                                  x.TurAd,
                                  x.TurId
                              }).ToList();
                DropDownList1.DataSource = turler;
                DropDownList1.DataBind();
                var kategoriler = (from x in db.TblKategori
                                   select new
                                   {
                                       x.KategoriId,
                                       x.KategoriAd
                                   }).ToList();
                DropDownList2.DataSource = kategoriler;
                DropDownList2.DataBind();

                var deger = db.TblBlog.Find(y);
                TxtBaslik.Text = deger.BlogBaslik;
                TxtTarih.Text = deger.BlogTarih.ToString();
                TxtGorsel.Text = deger.BlogGorsel;
                TxtIcerik.Text = deger.BlogIcerik;
                DropDownList1.SelectedValue = deger.BlogTur.ToString();
                DropDownList2.SelectedValue = deger.BlogKategori.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["BlogId"]);
            var blog = db.TblBlog.Find(y);
            blog.BlogBaslik = TxtBaslik.Text;
            blog.BlogTarih = DateTime.Parse(TxtTarih.Text);
            blog.BlogGorsel = TxtGorsel.Text;
            blog.BlogIcerik = TxtIcerik.Text;
            blog.BlogTur = byte.Parse(DropDownList1.SelectedValue);
            blog.BlogKategori = byte.Parse(DropDownList2.SelectedValue);
            db.SaveChanges();
            Response.Redirect("Bloglar.aspx");
        }
    }
}