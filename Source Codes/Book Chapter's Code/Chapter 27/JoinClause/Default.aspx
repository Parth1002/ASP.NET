<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs"
Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Join Clause Example</title>
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
				<asp:ListBox ID="ListBox1" runat="server" Height="135px" 
				style="margin-left: 189px; margin-top: 104px" 
 				Width="229px"></asp:ListBox>
				</br>
				<asp:Button ID="Button1" runat="server" Text="Button" 
 				onclick="Button1_Click" 
				style="height: 26px; margin-left: 263px; margin-top: 38px" 
 				Width="56px" />
			</div>
					</div>
	</form>
</body>
</html>
