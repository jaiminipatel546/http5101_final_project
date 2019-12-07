<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListFlowers.aspx.cs" Inherits="Final_Project.ListFlowers" %>

<asp:Content ID="Flower_List" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Flowers</h1>
    <div>
        <asp:label for="flower_search" runat="server">Search:</asp:label>
        <asp:TextBox ID="flower_search" runat="server"></asp:TextBox>
            
        <asp:Button runat="server" text="Search"/>
        <div id="sql_debugger" runat="server"></div>
    </div>
    <div>
        <a href="Add_Flower.aspx"><b>Add new flower</b></a>
    </div>
    <div class="table" runat="server" >
        <%--<div class="listitem" id="flowers_header">
            <div>FLOWER ID</div>
            <div>NAME</div>
            <div>DESCRIPTION</div>
        </div> --%>
    <div id="flowers_result" runat="server"></div>
    </div>
   
</asp:Content>
