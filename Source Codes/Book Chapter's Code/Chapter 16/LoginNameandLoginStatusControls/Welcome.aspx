<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Welcome.aspx.cs" Inherits="Welcome" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Welcome Page</title>
</head>
<body>
	<form id="form1" runat="server">
		<h1>C# 2010 Black Book</h1>
		<br />
		<font color ="navy" > Welcome <asp:LoginName ID="LoginName1" 
		 runat="server"  />!!! You have successfully logged in.</font>
		<asp:LoginStatus ID="LoginStatus1" runat="server" Style="z-index: 102; 
		 left: 31px;position: absolute; top: 177px" 
		 LogoutAction="RedirectToLoginPage" />
	</form>
</body>
</html>
