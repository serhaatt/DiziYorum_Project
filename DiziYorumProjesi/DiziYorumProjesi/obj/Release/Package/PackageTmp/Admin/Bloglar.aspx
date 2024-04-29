<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Bloglar.aspx.cs" Inherits="DiziYorumProjesi.Admin.Bloglar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="" style="border-radius:3px;border-style:initial"></asp:Label>
    </div>
    <table class="table table-bordered">
        <tr>
            <th>ID</th>
            <th>Başlık</th>
            <th>Tarih</th>
            <th>Tür</th>
            <th>Kategori</th>
            <th>Sil</th>
            <th>Güncelle</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("BlogId") %></td>
                    <td><%# Eval("BlogBaslik") %></td>
                    <td><%# Eval("BlogTarih") %></td>
                    <td><%# Eval("BlogTur") %></td>
                    <td><%# Eval("BlogKategori") %></td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "BlogSil.aspx?BlogId=" +Eval("BlogId") %>' CssClass="btn btn-danger">Sil</asp:HyperLink></td>
                    <td><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# "BlogGuncelle.aspx?BlogId=" +Eval("BlogId") %>' CssClass="btn btn-warning">Güncelle</asp:HyperLink></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <a href="YeniBlog.aspx" class="btn btn-primary">Yeni Blog</a>
</asp:Content>
