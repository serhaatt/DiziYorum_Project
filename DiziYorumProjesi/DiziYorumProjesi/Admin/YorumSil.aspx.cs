using DiziYorumProjesi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiziYorumProjesi.Admin
{
    public partial class YorumSil : System.Web.UI.Page
    {
        BlogDiziDbEntities db = new BlogDiziDbEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["YorumId"]);
            var yorum = db.TblYorum.Find(x);
            db.TblYorum.Remove(yorum);
            db.SaveChanges();
            Response.Redirect("Yorumlar.aspx");
        }
    }
}