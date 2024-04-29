<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="BlogGuncelle.aspx.cs" Inherits="DiziYorumProjesi.Admin.BlogGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" class="form-group">
        <asp:TextBox ID="TxtBaslik" runat="server" CssClass="form-control" placeholder="Blog Başlığı"></asp:TextBox>
        <br />
        <asp:TextBox ID="TxtTarih" runat="server" CssClass="form-control" placeholder="Blog Tarihi"></asp:TextBox>
        <br />
        <asp:TextBox ID="TxtGorsel" runat="server" CssClass="form-control" placeholder="Blog Görseli"></asp:TextBox>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" DataValueField="TurId" DataTextField="TurAd"></asp:DropDownList>
        <br />
        <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control" DataValueField="KategoriId" DataTextField="KategoriAd"></asp:DropDownList>
        <br />
        <asp:TextBox ID="TxtIcerik" runat="server" CssClass="form-control" placeholder="Blog İçerik" Height="100px"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-warning" OnClick="Button1_Click" />
    </form>
</asp:Content>
