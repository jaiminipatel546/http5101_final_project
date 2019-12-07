<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Update_FLower.aspx.cs" Inherits="Final_Project.Update_FLower" %>
<asp:Content ID="update_flower" ContentPlaceHolderID="MainContent" runat="server">
   <div class="updatePanel" id="flower" runat="server">
       <%-- <div class="viewnav">
            <a class="left" href="ShowFlower.aspx?flowerid=<%# Request.QueryString["flowerid"] %>">Cancel</a>
        </div>--%>
        <div><h2>Update for <span runat="server" id="flower_update"></span></h2></div>
        <div class="box">
            <asp:Label ID="flower_name_label"  class="update_flower" Text="Flower name:" runat="server"></asp:Label> 
            <asp:TextBox ID="flower_name_update" runat="server"></asp:TextBox>
        </div>
       <div>
            <asp:Label ID="flower_description_label" Text="Flower Description:" runat="server"></asp:Label> 
            <asp:TextBox ID="flower_description_update" runat="server"></asp:TextBox>
        </div>
    </div>
    <asp:Button OnClick="Update_Flower" Text="Update flower" runat="server" />
   
        <asp:Button runat="server" Text="Cancel" OnClientClick="window.open('ListFlowers.aspx');" />
    
    <%--<div>
        <a href="ListFlowers.aspx">Go back to the list</a>
    </div>--%>
</asp:Content>
