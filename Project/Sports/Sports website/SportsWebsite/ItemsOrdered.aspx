<%@ Page Title="Items" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ItemsOrdered.aspx.cs" Inherits="ItemsOrdered" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Verdana" 
        ForeColor="White" Text="Your order has been received. Your Order ID is: "></asp:Label>
    <asp:Label ID="lblOrderId" runat="server" Font-Bold="True" Font-Italic="True" 
        Font-Names="Verdana" ForeColor="White" Text="Label"></asp:Label>
    <br />
    <asp:Button ID="btnBack" runat="server" PostBackUrl="~/Default.aspx" 
        Text="Back to Home Page" Width="130px" />

</asp:Content>

