using DiziYorumProjesi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiziYorumProjesi.Admin
{
    public partial class Yorumlar : System.Web.UI.Page
    {
        BlogDiziDbEntities db = new BlogDiziDbEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var yorumlar = (from x in db.TblYorum select new
            {
                x.YorumId,
                x.Kullanici,
                x.TblBlog.BlogBaslik,
            }).ToList();
            Repeater1.DataSource = yorumlar;
            Repeater1.DataBind();
        }
    }
}