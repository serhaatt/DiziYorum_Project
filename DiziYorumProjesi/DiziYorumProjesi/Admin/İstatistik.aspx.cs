using DiziYorumProjesi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiziYorumProjesi.Admin
{
    public partial class İstatistik : System.Web.UI.Page
    {
        BlogDiziDbEntities db= new BlogDiziDbEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            TplmBlog.Text = db.TblBlog.Count().ToString();
            TplmYorum.Text = db.TblYorum.Count().ToString();
            TplmFilm.Text = db.TblBlog.Where(x=>x.BlogTur==2).Count().ToString();
            TplmDizi.Text = db.TblBlog.Where(x=>x.TblTur.TurAd=="Dizi").Count().ToString();
            TplmAnimasyon.Text = db.TblBlog.Where(x=>x.TblTur.TurAd=="Animasyon").Count().ToString();
            int key = Int32.Parse(db.TblYorum.GroupBy(x => x.YorumBlog).OrderByDescending(x => x.Count()).Select(y => y.Key).FirstOrDefault().ToString());
            EnFazlaYorum.Text= (from x in db.TblBlog where x.BlogId==key select x.BlogBaslik).FirstOrDefault().ToString();
        }
    }
}