using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProjesi.Entity;
namespace DiziYorumProjesi.Pages
{
    public partial class Hakkımda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BlogDiziDbEntities db = new BlogDiziDbEntities();
            Repeater1.DataSource = db.TblHakkımızda.ToList();
            Repeater1.DataBind();
        }
    }
}