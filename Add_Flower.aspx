<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Add_Flower.aspx.cs" Inherits="Final_Project.Add_Flower" %>
<asp:Content ID="add_flower" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div><h2>Add new flower</h2></div>
        <div class="addFlower">
            <asp:TextBox ID="add_flower_name" placeholder="Enter flower Name" runat="server"></asp:TextBox>
            
        </div>
        <div class="addFlower">
            <asp:TextBox ID="add_flower_description" placeholder="Enter flower description" runat="server"></asp:TextBox>
            
        </div>
        <div>
            <asp:Button OnClick="add_flower" runat="server" Text="Submit" />
        </div>
    </div>
</asp:Content>
