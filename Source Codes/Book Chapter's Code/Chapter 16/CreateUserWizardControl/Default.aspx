<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  	<title>Untitled Page</title>
</head>
<body>
	<form id="form1" runat="server">
	<h1 >C# 2010 Black Book</h1>
		<br /><br />
	<asp:CreateUserWizard ID="CreateUserWizard1" runat="server" BackColor="#EFF3FB" 
		BorderColor="#B5C7DE" BorderStyle="Solid" BorderWidth="1px" 
		Font-Names="Verdana" Font-Size="0.8em">
		<SideBarStyle BackColor="#507CD1" Font-Size="0.9em" VerticalAlign="Top" />
		<SideBarButtonStyle BackColor="#507CD1" Font-Names="Verdana" 
			ForeColor="White" />
		<ContinueButtonStyle BackColor="White" BorderColor="#507CD1" 
			BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
			ForeColor="#284E98" />
		<NavigationButtonStyle BackColor="White" BorderColor="#507CD1" 
			BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
			ForeColor="#284E98" />
		<HeaderStyle BackColor="#284E98" BorderColor="#EFF3FB" BorderStyle="Solid" 
			BorderWidth="2px" Font-Bold="True" Font-Size="0.9em" ForeColor="White" 
			HorizontalAlign="Center" />
		<CreateUserButtonStyle BackColor="White" BorderColor="#507CD1" 
			BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
			ForeColor="#284E98" />
		<TitleTextStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
		<StepStyle Font-Size="0.8em" />
		<WizardSteps>
		<asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server" />
		<asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server" />
		</WizardSteps>
	</asp:CreateUserWizard>
	</form>
</body>
</html>

