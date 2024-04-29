<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Kullanıcı.Master" AutoEventWireup="true" CodeBehind="Hakkımda.aspx.cs" Inherits="DiziYorumProjesi.Pages.Hakkımda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="about-section">
            <div class="about-grid">
                <h1>Hakkımızda</h1>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <p><%# Eval("Aciklama") %></p>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>

</asp:Content>
