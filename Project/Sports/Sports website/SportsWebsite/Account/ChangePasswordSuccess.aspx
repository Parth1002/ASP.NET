<%@ Page Title="Change Password" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="ChangePasswordSuccess.aspx.cs" Inherits="Account_ChangePasswordSuccess" %>
    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>



<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
<asp:Panel ID="Panel1" BackColor="#BBBBBB" runat="server" > 
    <h2>
        Change Password
    </h2>
    <p>
        Your password has been changed successfully.
    </p>
    </asp:Panel>
    <cc1:RoundedCornersExtender ID="RoundedCornersExtender1" runat="server" TargetControlID="Panel1" Radius="10">
    </cc1:RoundedCornersExtender>
</asp:Content>
