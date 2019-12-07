<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShowFlower.aspx.cs" Inherits="Final_Project.ShowFlower" %>

<asp:Content ID="flower_view" ContentPlaceHolderID="MainContent" runat="server">
    <div id="flower" runat="server">
        <h2>Details for <span id="flower_title" runat="server"></span></h2>
        Flower Name: <span id="flower_name" runat="server"></span><br/>
        Flower Description: <span id="flower_description" runat="server"></span><br/>
    </div>
    <div>
        <a href="ListFlowers.aspx">Go back to the list</a>
    </div>
</asp:Content>
