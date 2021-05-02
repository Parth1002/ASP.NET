<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs"
Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>TypeFiltering Example</title>
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
			&nbsp;Retrives data after filtering type of data<asp:ListBox
			ID="ListBox1" runat="server" Height="125px" 
			style="margin-left: 98px; margin-top: 73px" Width="145px"></asp:ListBox>
			<br />
			<br />
			&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
	&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
	&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
	&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
	&nbsp;&nbsp;&nbsp;&nbsp;
			<asp:Button ID="Button1" runat="server" style="margin-left: 102px" 
			 Text="Type Filtering" Width="143px" onclick="Button1_Click1" />
			</div>
					</div>
	</form>
</body>
</html>   
