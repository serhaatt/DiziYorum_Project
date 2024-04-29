<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Yorumlar.aspx.cs" Inherits="DiziYorumProjesi.Admin.Yorumlar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <table class="table table-bordered">
     <tr>
         <th>ID</th>
         <th>Kullanıcı</th>
         <th>Blog</th>
         <th>Sil</th>
         <th>Güncelle</th>
     </tr>
     <asp:Repeater ID="Repeater1" runat="server">
         <ItemTemplate>
             <tr>
                 <td><%# Eval("YorumId") %></td>
                 <td><%# Eval("Kullanici") %></td>
                 <td><%# Eval("BlogBaslik") %></td>
                 <td>
                     <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "YorumSil.aspx?YorumId=" +Eval("YorumId") %>' CssClass="btn btn-danger">Sil</asp:HyperLink></td>
                 <td><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# "YorumGuncelle.aspx?YorumId=" +Eval("YorumId") %>' CssClass="btn btn-warning">Güncelle</asp:HyperLink></td>
             </tr>
         </ItemTemplate>
     </asp:Repeater>
 </table>

</asp:Content>
