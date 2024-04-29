using DiziYorumProjesi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiziYorumProjesi.Admin
{
    public partial class YeniBlog : System.Web.UI.Page
    {
        BlogDiziDbEntities db = new BlogDiziDbEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
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
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TblBlog t = new TblBlog();
            t.BlogBaslik = TxtBaslik.Text;
            t.BlogGorsel = TxtGorsel.Text;
            t.BlogIcerik = TxtIcerik.Text;
            t.BlogTarih = DateTime.Parse(TxtTarih.Text);
            t.BlogTur = byte.Parse(DropDownList1.SelectedValue);
            t.BlogKategori = byte.Parse(DropDownList2.SelectedValue);
            db.TblBlog.Add(t);
            db.SaveChanges();
            Response.Redirect("Bloglar.aspx");
        }
    }
}