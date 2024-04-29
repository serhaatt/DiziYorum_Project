using DiziYorumProjesi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace DiziYorumProjesi.Pages
{
    public partial class Iletisim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        BlogDiziDbEntities db = new BlogDiziDbEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            TblIletisim t = new TblIletisim();
            t.AdSoyad = TextBox1.Text;
            t.Konu = TextBox4.Text;
            t.Mail = TextBox2.Text;
            t.Telefon = TextBox3.Text;
            t.MesajIcerik = TextBox5.Text;
            db.TblIletisim.Add(t);
            db.SaveChanges();
        }
    }
}