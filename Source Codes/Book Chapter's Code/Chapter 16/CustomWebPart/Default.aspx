<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<%@ Register TagPrefix="cc" TagName="customcontrol" Src="customcontrol.ascx" %>
<script runat="server">
	protected void Page_Load(object sender, EventArgs e)
	{
		if (WebPartManager1.Personalization.CanEnterSharedScope &&
		WebPartManager1.Personalization.Scope == PersonalizationScope.User)
		{
			WebPartManager1.Personalization.ToggleScope();
		}
	}
	protected void LinkButton1_Click(object sender, EventArgs e)
	{
		WebPartManager1.DisplayMode = WebPartManager.EditDisplayMode;
	}
		protected void LinkButton2_Click(object sender, EventArgs e)
	{
		WebPartManager1.DisplayMode = WebPartManager.BrowseDisplayMode;
	}
</script>
<html>
<head id="Head1" runat="server">
	<title>custom control</title>
</head>
<body>
	<form id="form1" runat="server">
		<div id="header"><h1>C# 2010 Black Book</h1>
			</div>
			<div id="content">
				<asp:WebPartManager 
				ID="WebPartManager1" runat="server" />
				Custom WebPart &nbsp;<br />
				<asp:LinkButton 
				ID="LinkButton1" runat="server"
				OnClick="LinkButton1_Click">Edit
				Mode</asp:LinkButton>
				<asp:LinkButton 
				ID="LinkButton2" runat="server"
				OnClick="LinkButton2_Click">Browse
				Mode</asp:LinkButton><br /><br />
				<asp:WebPartZone 
				ID="WebPartZone2" runat="server">
				<ZoneTemplate>
				<cc:customcontrol 
				runat="server" id="customcontrol1" />
				</ZoneTemplate></asp:WebPartZone>
				<asp:EditorZone 
				ID="EditorZone1" 
				runat="server" BackColor="#F7F6F3"
				BorderColor="#CCCCCC" BorderWidth="1px" 
				Font-Names="Verdana" Padding="6">
				<LabelStyle 
				Font-Size="0.8em" ForeColor="#333333" />
				<HeaderStyle BackColor="#E2DED6" 
				Font-Bold="True" Font-Size="0.8em"
				ForeColor="#333333" />	<ZoneTemplate>
				<asp:BehaviorEditorPart
				ID="BehaviorEditorPart1" runat="server" />
				<asp:LayoutEditorPart 
				ID="LayoutEditorPart1" runat="server"	/>
				</ZoneTemplate>
				<HeaderVerbStyle Font-Bold="False" 
				Font-Size="0.8em" Font-Underline="False" 
				ForeColor="#333333" />
				<PartChromeStyle 
				BorderColor="#E2DED6" BorderStyle="Solid"
				BorderWidth="1px" />
				<PartStyle 
				BorderColor="#F7F6F3" BorderWidth="5px" />
				<FooterStyle BackColor="#E2DED6" 
				HorizontalAlign="Right" />
				<EditUIStyle Font-Names="Verdana" 
				Font-Size="0.8em" ForeColor="#333333" />
				<InstructionTextStyle 
				Font-Size="0.8em" ForeColor="#333333" />
				<ErrorStyle Font-Size="0.8em" />
				<VerbStyle Font-Names="Verdana" 
				Font-Size="0.8em" ForeColor="#333333" />
				<EmptyZoneTextStyle 
				Font-Size="0.8em" ForeColor="#333333" />
				<PartTitleStyle Font-Bold="True" 
				Font-Size="0.8em" ForeColor="#333333" />
				</asp:EditorZone>
				<br /><br /><br />
				</div>
				
			</form>
</body>
</html>

