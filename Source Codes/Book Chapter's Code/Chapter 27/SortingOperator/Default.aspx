﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs"
	Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
 	"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Using Sorting Operator</title>
	</head>
<body>
	<form id="form1" runat="server">
		<div id="header">
			<h1>
				C# 2010 Black Book
			</h1>
		</div>
				<div id="content">
			<div class ="itemContent">
			<asp:ListBox ID="ListBox1" runat="server" Height="126px" 
			style="margin-left: 157px; margin-top: 82px" 
 			Width="225px"></asp:ListBox>
			<br />
			<br />
			<br />
			<asp:Button ID="Button1" runat="server" onclick="Button1_Click1" 
			style="margin-left: 199px" Text="Ascending" Width="97px" />
			<asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
			style="margin-left: 35px; margin-top: 0px" Text="Descending" />
			</div>
					</div>
	</form>
</body>
</html>
