<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Handling Client Events</title>
      
	<script type="text/javascript" >

	    function button1_onclick() {
	        document.getElementById("TextBox1").value = "Handling client events";
	    }
          
    </script>

</head>
<body>
	<form id="form1" runat="server">
<div>
    
</div>
<asp:Button ID="Button1" runat="server"   
style="top: 153px; left: 216px; position: absolute; height: 26px; width: 97px; right: 976px;" 
Text="Click Me" OnClientClick = "button1_onclick()"/>
<asp:TextBox ID="TextBox1" runat="server" 
style="top: 156px; left: 385px; position: absolute; 
      height: 22px; "></asp:TextBox>
	</form>
</body>
</html>

