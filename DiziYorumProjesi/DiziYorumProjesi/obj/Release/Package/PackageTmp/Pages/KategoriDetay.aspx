<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Kullanıcı.Master" AutoEventWireup="true" CodeBehind="KategoriDetay.aspx.cs" Inherits="DiziYorumProjesi.Pages.KategoriDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
    <div class="content-grids">
        <div class="col-md-8 content-main">
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <div class="content-grid">
                        <div class="content-grid-info">
                            <img src="<%# Eval("BlogGorsel") %>" alt="" style="height: 350px; width: 600px" />
                            <div class="post-info">
                                <h4><a href="BlogDetay.aspx?BlogId=<%# Eval("BlogId") %>"><%# Eval("BlogBaslik") %></a>  <%# Eval("BlogTarih") %></h4>
                                <p><%# Eval("BlogIcerik").ToString().Substring(0,250) %>...</p>
                                <a href="BlogDetay.aspx?BlogId=<%# Eval("BlogId") %>"><span></span>Devamını Oku</a>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>

        <div class="col-md-4 content-right">

            <div class="recent">
                <h3>En Son Bloglar</h3>
                <ul>
                    <asp:Repeater ID="Repeater3" runat="server">
                        <ItemTemplate>
                            <li><a href="#"><%# Eval("BlogBaslik") %></a></li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </div>
            <div class="comments">
                <h3>Son Yorumlar</h3>
                <ul>
                    <li><a href="#">Amada Doe </a>on <a href="#">Hello World!</a></li>
                    <li><a href="#">Peter Doe </a>on <a href="#">Photography</a></li>
                    <li><a href="#">Steve Roberts  </a>on <a href="#">HTML5/CSS3</a></li>
                </ul>
            </div>
            <div class="clearfix"></div>
            <div class="archives">
                <h3>Arşivler</h3>
                <ul>
                    <li><a href="#">Nisan 2023</a></li>
                    <li><a href="#">Mayıs 2023</a></li>
                    <li><a href="#">Haziran 2023</a></li>
                </ul>
            </div>
            <div class="categories">
                <h3>Kategoriler</h3>
                <ul>
                    <asp:Repeater ID="Repeater2" runat="server">
                        <ItemTemplate>
                            <li><a href="KategoriDetay.aspx?KategoriId=<%# Eval("KategoriId") %>"><%# Eval("KategoriAd") %></a></li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </div>
            <div class="clearfix"></div>
        </div>
        <div class="clearfix"></div>
    </div>
</div>

</asp:Content>
