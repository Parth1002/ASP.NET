<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs"
Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>WhereClause Demo</title>
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
			Displays data in the listbox according to the condition 
			specified in the where clause.
			<br />
			<asp:ListBox ID="ListBox1" runat="server" Height="117px" 
			style="margin-left: 36px; margin-top: 35px" Width="135px"></asp:ListBox>
			<br />
			<br />
			<asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
			style="margin-left: 30px" Text="Using Where clause" Width="144px" />
			</div>
			
		</div>
	</form>
</body>
</html>
