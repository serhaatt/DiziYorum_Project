using DiziYorumProjesi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiziYorumProjesi
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BlogDiziDbEntities db = new BlogDiziDbEntities();
            var sorgu = from x in db.TblAdmin where x.Kullanıcı == Username.Text && x.Şifre == Password.Text select x;
            if (sorgu.Any())
            {
                Session.Add("Kullanıcı",Username.Text);
                Response.Redirect("/Admin/Bloglar.aspx");
            }
            else
            {
                Response.Write("Hatalı Kullanıcı Adı veya Şifre");
            }
        }
    }
}