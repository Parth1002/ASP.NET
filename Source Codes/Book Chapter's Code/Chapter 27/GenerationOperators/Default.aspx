<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs"
Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Using Generation Operators </title>
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
				Displays data by using Generic Operators
				</br>
				<asp:ListBox ID="ListBox1" runat="server" Height="290px" 
				style="margin-left: 149px; margin-right: 85px; margin-top: 44px" 
 				Width="190px"></asp:ListBox>
				<br />
				<br />
				<asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
				style="margin-left: 185px" Text="Display" Width="131px" />
			</div>
		</div>
	</div>
	</form>
</body>
</html>
