<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Login and LoginView Controls Example</title>
</head>
<body>
	<form id="form1" runat="server">
		<h1>C# 2010 Black Book</h1>
		<br />
		<asp:LoginView ID="LoginView1" runat="server">
		<LoggedInTemplate>
		<br />
		<font color="navy">Welcome!!! You have successfully logged in.
		</font> 
		</LoggedInTemplate>
		<AnonymousTemplate>
		<strong>You are not logged in. Please Login.<br />
		</strong>
		<br />
		<asp:Login ID="Login1" runat="server" BackColor="#FFE0C0" 
		 BorderColor="ControlText" BorderPadding="4"
		 BorderStyle="Solid" BorderWidth="1px" Font-Names="Garamond" 
		 ForeColor="#333333" >
		<TitleTextStyle BackColor="Maroon" Font-Bold="True" Font-Size="0.9em"  
		 ForeColor="White" />
		<LoginButtonStyle BackColor="White" BorderColor="#0000C0" 
		 BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" ForeColor="#284E98" />
		<InstructionTextStyle Font-Italic="True" ForeColor="Black" />
		</asp:Login>
		</AnonymousTemplate>
		</asp:LoginView>
		<br />&nbsp;
	</form>
</body>
</html>

