<%@ Page Title="Gallery" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Gallery_Photo.aspx.cs" Inherits="Gallery_Photo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/head_Gray_Gallery.jpg" />
    <br />
    <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Center">
        <asp:Button ID="btnDownload" runat="server" onclick="btnDownload_Click" 
        Text="Download" ToolTip="Click to download the picture." />
        <br />
        <asp:Image ID="Img" runat="server" />
    </asp:Panel>
    <br />
    <br />
    <br />
    </asp:Content>
