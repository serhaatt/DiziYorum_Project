<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="İstatistik.aspx.cs" Inherits="DiziYorumProjesi.Admin.İstatistik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="table table-bordered">
        <tr>
            <td>Toplam Blog Sayısı:
                <asp:Label ID="TplmBlog" runat="server" Text="Label"></asp:Label>
            </td>
            <td>Toplam Yorum Sayısı:
                <asp:Label ID="TplmYorum" runat="server" Text="Label"></asp:Label>
            </td>
            <td>Toplam Film Sayısı:
                    <asp:Label ID="TplmFilm" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        
        <tr>
            <td>Toplam Dizi Sayısı:
        <asp:Label ID="TplmDizi" runat="server" Text="Label"></asp:Label>
            </td>
            <td>Toplam Animasyon Sayısı:
        <asp:Label ID="TplmAnimasyon" runat="server" Text="Label"></asp:Label>
            </td>
            <td>En Fazla Yorumlu Blog:
            <asp:Label ID="EnFazlaYorum" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
