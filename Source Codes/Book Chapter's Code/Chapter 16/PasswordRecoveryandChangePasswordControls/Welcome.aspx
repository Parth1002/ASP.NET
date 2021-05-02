<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Welcome.aspx.cs" Inherits="Welcome" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Welcome Page</title>
</head>
<body>
	<form id="form1" runat="server">
		<h1>  C# 2010 Black Book
		</h1><br /><br />
		<font color ="navy" > Welcome <asp:LoginName ID="LoginName1" 
		 runat="server"/>!!!
		You have successfully logged in.</font>
		<asp:LoginStatus ID="LoginStatus1" runat="server" Style="z-index: 100;
		 left: 571px; position: absolute; top: 23px"
		 LogoutAction="RedirectToLoginPage" />
		<asp:LinkButton ID="LinkButton1" runat="server" Style="z-index: 101; 
		 left: 24px; position: absolute; top: 185px" onclick="LinkButton1_Click">Change 
		 Password</asp:LinkButton>
		&nbsp;
		<asp:ChangePassword ID="ChangePassword1" runat="server" 
		 BackColor="#FFE0C0" BorderColor="ControlText" BorderPadding="4"
		 BorderStyle="Solid" BorderWidth="1px" Font-Names="Garamond"
		 ForeColor="#333333"
		 Visible="False" style="z-index: 103; left: 17px; position: 
		 absolute;
		 top: 264px">
		<TitleTextStyle BackColor="Maroon" Font-Bold="True" Font-Size="0.9em" 
		 ForeColor="White" />
		<ChangePasswordButtonStyle BackColor="White" 
		 BorderColor="#0000C0" 
		 BorderStyle="Solid" BorderWidth="1px"
		 Font-Names="Verdana" ForeColor="#284E98" />
		<CancelButtonStyle BackColor="White" BorderColor="#0000C0" 
		 BorderStyle="Solid" BorderWidth="1px"
		Font-Names="Verdana" ForeColor="#284E98" />            
		</asp:ChangePassword>
	</form>
</body>
</html>

