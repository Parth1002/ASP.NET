<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs"
Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>LINQ to XML</title>
	</head>
<body>
	<form id="Form" runat="server">
		<div id="header">
			<h1>
				C# 2010 Black Book
			</h1>
		</div>
		<div id="content">
			<div class ="itemContent">
				<asp:ListBox ID="ListBox1" runat="server" Height="236px" 
				style="margin-left: 97px; margin-top: 53px" 
 				  Width="398px"></asp:ListBox>
				<br />
				<asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
				style="margin-left: 126px" Text="Display" Width="136px" />
			</div>
		</div>
	</form>
</body>
</html>
