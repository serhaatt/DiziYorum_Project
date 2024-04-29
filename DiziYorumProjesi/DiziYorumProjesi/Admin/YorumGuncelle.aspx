<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="YorumGuncelle.aspx.cs" Inherits="DiziYorumProjesi.Admin.YorumGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server" class="form-group">
        <asp:TextBox ID="TxtBaslik" runat="server" CssClass="form-control" placeholder="Blog Başlığı" Enabled="false"></asp:TextBox>
        <br />
        <asp:TextBox ID="TxtKullanici" runat="server" CssClass="form-control" placeholder="Kullanıcı Adı"></asp:TextBox>
        <br />
        <asp:TextBox ID="TxtYorum" runat="server" CssClass="form-control" placeholder="Yorum İçerik" Height="100px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-warning" OnClick="Button1_Click" />
    </form>

</asp:Content>
