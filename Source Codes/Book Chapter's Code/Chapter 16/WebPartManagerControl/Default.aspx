<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>WebPartManager Control</title>
</head>
<body>
	<form id="form1" runat="server">
		<h1> C# 2010 Black Book</h1>
		<br />
		<asp:Label ID="Label3" runat="server" Font-Bold="True" Font-
		 Underline="True" ForeColor="#0000C0"
		 Text="WebPart Manager:" style="z-index: 100; left: 12px; position: 
		 absolute; top: 90px"></asp:Label>
		<br />
		&nbsp;
		<br />
		<br />
		<asp:Panel ID="Panel1" runat="server" BackColor="Silver" 
		 BorderColor="#804040" BorderStyle="Double"
		 Height="137px" Width="320px">
		&nbsp; &nbsp; &nbsp;<br />
		&nbsp;&nbsp; &nbsp;<asp:Label ID="Label1" runat="server" Font-
		Bold="True" ForeColor="#000040"
		Text="WEBPARTMANAGER CREATED!!!!" 
		Visible="False"></asp:Label><br />
		<br />
		&nbsp; &nbsp; &nbsp;
		<asp:Button ID="Button2" runat="server" BackColor="Maroon" Font-
		 Bold="True" ForeColor="White"
		 OnClick="Button2_Click" Text="Display Mode" Width="213px" style="z-
		 index: 102; left: 50px; position: absolute; top: 205px" />
		<br />
		&nbsp; &nbsp; &nbsp;
		<asp:Label ID="Label2" runat="server" Font-Bold="True" 
		 ForeColor="#0000C0" Visible="False" style="z-index: 101; left: 
		 124px; position: absolute; top: 256px"></asp:Label></asp:Panel>   
	</form>
</body>
</html>

