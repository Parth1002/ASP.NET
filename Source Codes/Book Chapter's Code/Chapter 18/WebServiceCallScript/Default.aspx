﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" 
 	Inherits="_Default"  %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
 	"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
   
    <script language="javascript" type="text/javascript" >
        function onclick_GetTime() {
            TimeService.ServerTime(form1.txtName.value, OnSuccess);
        }
        function OnSuccess(msg) {
            alert(msg);
        }
</script> 
</head>
<body>
    <form id="form1" runat="server"> 
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="False">
			<Services>
				<asp:ServiceReference Path="~/TimeService.asmx" />
			</Services>
		</asp:ScriptManager>
		<div>
			Enter the name in the textbox:<input type="text" value="" id="txtName" />
            <br />
            <br />
 		&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
 		&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
		<input type="button" value="Get the ServerTime" id="GetTime" 
 		onclick="return onclick_GetTime()" />
    </div>
    </form>
</body>
</html>
