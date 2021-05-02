<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ForgotPassword.aspx.cs" Inherits="ForgotPassword" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    	<title>Forgot Password Page</title>
</head>
<body>
	<form id="form1" runat="server">
		<h1>  C# 2010 Black Book </h1>
		<br />
		<br />
		<asp:PasswordRecovery ID="PasswordRecovery1" runat="server" 
		 BackColor="#FFE0C0" BorderColor="ControlText" BorderPadding="4"
		 BorderStyle="Solid" BorderWidth="1px" Font-Names="Garamond" 
		 ForeColor="#333333" >
		<TitleTextStyle BackColor="Maroon" Font-Bold="True" Font-Size="0.9em" 
		 ForeColor="White" />
		<SubmitButtonStyle BackColor="White" BorderColor="#0000C0" 
		 BorderStyle="Solid" BorderWidth="1px"
		 Font-Names="Verdana" ForeColor="#284E98"/>
		</asp:PasswordRecovery>
		&nbsp;
		<br />
		<br />
		<asp:LinkButton ID="LinkButton1" runat="server" 
		 PostBackUrl="~/Login.aspx" Style="z-index: 100;
		 left: 51px; position: absolute; top: 269px">Click here to go 
		 back</asp:LinkButton>
	</form>
</body>
</html>

