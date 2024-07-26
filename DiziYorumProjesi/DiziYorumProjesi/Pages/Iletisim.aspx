<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Kullanıcı.Master" AutoEventWireup="true" CodeBehind="Iletisim.aspx.cs" Inherits="DiziYorumProjesi.Pages.Iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="contact-content">
        <div class="container">
            <div class="contact-info">
                <h2>İletişim</h2>
                <p>Blog sayfamızda bulunan film ve dizilere eklemek istedikleriniz için veya yorumlarda yaşayacağınız herhangi bir problem için bu panelden bizlere mesaj gönderebilirsiniz. Mesaj gönderme sırasında mutlaka e-mail adresinizi doğru bir şekilde yazınız. </p>
            </div>
            <div class="contact-details">
                <form runat="server">
                    <asp:TextBox ID="TextBox1" runat="server" placeholder="Ad Soyad" required=""></asp:TextBox>
                    <asp:TextBox ID="TextBox2" runat="server" placeholder="Mail" required=""></asp:TextBox>
                    <asp:TextBox ID="TextBox3" runat="server" placeholder="Telefon" required=""></asp:TextBox>
                    <asp:TextBox ID="TextBox4" runat="server" placeholder="Konu" required=""></asp:TextBox>
                    <asp:TextBox ID="TextBox5" runat="server" placeholder="Mesajınız" required="" TextMode="MultiLine" Height="100px"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="Gönder" OnClick="Button1_Click" />
                </form>
            </div>
            <div class="contact-details">
                <div class="col-md-6 contact-map">
                    <h4>Biz Buradayız</h4>
                    <div style="max-width:100%;list-style:none; transition: none;overflow:hidden;width:500px;height:500px;"><div id="embed-map-display" style="height:100%; width:100%;max-width:100%;"><iframe style="height:100%;width:100%;border:0;" frameborder="0" src="https://www.google.com/maps/embed/v1/place?q=İzmir,+Türkiye&key=key is here"></iframe></div><a class="google-maps-html" href="https://www.bootstrapskins.com/themes" id="enable-map-data">premium bootstrap themes</a><style>#embed-map-display img.text-marker{max-width:none!important;background:none!important;}img{max-width:none}</style></div>
                    </div>
                <div class="clearfix"></div>
            </div>
        </div>
    </div>
</asp:Content>
