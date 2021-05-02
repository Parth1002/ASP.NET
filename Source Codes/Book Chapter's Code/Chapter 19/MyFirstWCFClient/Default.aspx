<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
     <style type="text/css">
			.style1	{
				width: 100%;
			}
			.style2
			{
				width: 142px;
			}
			.style3
			{
				width: 75px;
			}
			.style4
			{
				width: 96px;
			}
			.style5
			{
				width: 111px;
			}
		</style>

    </h2>
    <div>
	<table class="style1">
		<tr>
		<td class="style2">
			<asp:Label ID="Label1" runat="server" Text="Enter a Number"></asp:Label>
		</td>
		<td>
			<asp:TextBox ID="txtfirst" runat="server"></asp:TextBox>
		</td>
		</tr>
		<tr>
		<td class="style2">
		<asp:Label ID="Label3" runat="server" Text="Output" Visible="False"></asp:Label>
		</td>
		<td>
			<asp:Label ID="lbloutput" runat="server" Text="Label" 
			 Visible="False"></asp:Label>
		</td>
		</tr>
		<tr>
			<td class="style2">
			&nbsp;</td>
			<td>
			&nbsp;</td>
		</tr>
	</table>
	</div>
	<table class="style1">
		<tr>
		<td class="style3">
			<asp:Button ID="btnsqr" runat="server" onclick="btnsqr_Click" 
			 Text="Square" Width="103px" />
		</td>
		<td class="style4">
			<asp:Button ID="btncube" runat="server" style="margin-left: 0px" 
			 Text="Cube" Width="103px" onclick="btncube_Click" />
		</td>
		<td class="style5">
			&nbsp;</td>
		<td>
			&nbsp;</td>
		</tr>
	</table>

</asp:Content>
