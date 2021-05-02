<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="DeploymentTestWebApplication._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
  <div>
        <asp:Label ID="Label1" runat="server" Text="Enter Name: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    
    <p>
        <asp:Label ID="Label2" runat="server" Text="Enter Emp ID: "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" />
    </p>
    </div>
</asp:Content>
