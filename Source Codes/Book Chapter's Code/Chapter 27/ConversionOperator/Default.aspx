<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs"
Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head id="Head1" runat="server">
    <title>Using Conversion Operator</title>
		</head>

<body>
	<form id="form1" runat="server">
		<div id="header">
			<h1>
			C# 2010 Black Book
			</h1>
		</div>
				<div id="content">
		<div class ="itemContent">&nbsp;Displays data by using OfType operator 
			<asp:ListBox ID="ListBox1" runat="server" 
 			Height="144px" 
		style="margin-left: 314px; margin-top: 75px" Width="232px"></asp:ListBox>
			<br />
			<br />
			&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
			<asp:Button ID="Button1" runat="server" 
			style="margin-left: 85px" Text="For String " Width="94px"
			onclick="Button1_Click1" />
			<asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
			style="margin-left: 40px; margin-top: 28px" Text="For Numeric" 
 			Width="111px" />
			</div>
				</div>
	</form>
</body>
</html>
