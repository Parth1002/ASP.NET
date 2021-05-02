<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CatalogZone Example</title>
</head>
<body>
	<form id="form1" runat="server">
		<div id="header">
		<h1>C# 2010 Black Book</h1>
		</div>
		<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-					 Underline="True" ForeColor="Navy"
		 Text="CatalogZone:"></asp:Label>
		<br />
		<br />
		<asp:Panel ID="Panel1" runat="server" BackColor="#FFE0C0" 					 BorderColor="#FF8000" BorderStyle="Double"
		 Height="150px" Width="367px">
		<br />
		&nbsp;<asp:Button ID="Button1" runat="server" BackColor="#FFE0C0" 				 BorderStyle="None"
		 Font-Bold="True" Font-Underline="True" ForeColor="Blue" 					 OnClick="Button1_Click"
		 Text="Property Settings : Custom" Width="174px" />
		<br />
		<br />
		<asp:Label ID="Label3" runat="server" Font-Bold="True" Font-			
		 Underline="True" ForeColor="Navy"
		 Text="Selected CatalogPart ID:" Visible="False"></asp:Label>
		&nbsp;&nbsp;
		<asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Label" 				 Visible="False"></asp:Label>
		<br />
		<br />
		<asp:Label ID="Label5" runat="server" Font-Bold="True" Font-			
		 Underline="True" ForeColor="Navy"
		 Text="EmptyZone Text:" Visible="False"></asp:Label>
		 &nbsp;
		<asp:Label ID="Label6" runat="server" Font-Bold="True" Text="Label" 				Visible="False"></asp:Label>
		<br />
		<br />
		<asp:Label ID="Label7" runat="server" Font-Bold="True" Font-			
		 Underline="True" ForeColor="Navy"
		 Text="Page Browse Mode:" Visible="False"></asp:Label>
		&nbsp;
		<asp:Label ID="Label8" runat="server" Font-Bold="True" Text="Label" 				 Visible="False"></asp:Label>
		<br />
		<br />
		</asp:Panel>
	</form>
</body>
</html>
