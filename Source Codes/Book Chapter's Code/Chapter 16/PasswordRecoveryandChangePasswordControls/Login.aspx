<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    	<title>Login Page</title>
</head>
<body>
	<form id="form1" runat="server">
		<h1> C# 2010 Black Book</h1>
		<br />
		&nbsp;&nbsp;
		<asp:Login ID="Login1" runat="server" BackColor="#FFE0C0"
		 BorderColor="ControlText" BorderPadding="4" BorderStyle="Solid"
		 BorderWidth="1px" Font-Names="Garamond" ForeColor="#333333"
		 DestinationPageUrl="~/Welcome.aspx" style="z-index: 100; left:
		 28px; position: absolute; top: 92px">
		<TitleTextStyle BackColor="Maroon" Font-Bold="True" Font-Size="0.9em"  
		 ForeColor="White" />
		<LoginButtonStyle BackColor="White" BorderColor="#0000C0"
		 BorderStyle="Solid" BorderWidth="1px"
		 Font-Names="Verdana" ForeColor="#284E98" />
		<InstructionTextStyle Font-Italic="True" ForeColor="Black" />
		</asp:Login>
		<br /><br /><br /><br /><br /><br /><br /><br /><br />
		&nbsp; &nbsp; &nbsp;&nbsp;
		<font color ="Maroon"><strong > Forgot Password ?</strong></font>
		<asp:LinkButton ID="LinkButton1" runat="server" Height="15px" Style="z-
		 index: 102;left: 172px; position: absolute; top: 261px"
		 PostBackUrl="~/ForgotPassword.aspx">Click here</asp:LinkButton>
	</form>
</body>
</html>

