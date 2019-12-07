<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete_Flower.aspx.cs" Inherits="Final_Project.Delete_Flower" %>
<asp:Content ID="delete_flower" ContentPlaceHolderID="MainContent" runat="server">
    <div id="flower" runat="server">
        <div>
            <h2>Delete</h2>
        </div>
        <div class="panel-body">
            <h2>Are you sure you want to delete from database ?</h2>
        </div>
        <div>
        <asp:Button OnClick="Delete_flower" Text="Delete" runat="server"/>
      
        <asp:Button runat="server" class="delete_btn" Text="Cancel" OnClientClick="window.open('ListFlowers.aspx');"/>
        </div>
   </div>
</asp:Content>
