<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>
    <%@import Namespace="System.ServiceModel" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

  <style type="text/css">
	.style1
	{
		width: 95%;
	}
	.style5
	{
		width: 115px;
	}
	#Button1
	{
		width: 56px;
	}
	.style7
	{
		width: 449px;
	}
</style>
<div>
	<h1>AJAX-Enable WCF Service </h1>
		<table class="style1">
		<tr>
			<td class="style5">
				First Number:</td>
			<td class="style7">
				<input type="text" id="Number1" /></td>
		</tr>
		<tr>
			<td class="style5">
				Second Number:</td>
			<td class="style7">
				<input type="text" id="Number2" /></td>
		</tr>
		<tr>
			<td class="style5">
				Result:</td>
			<td class="style7">
				<input type="text" id="result" /></td>
		</tr>
		<tr>
			<td class="style5">
			<input id="Button1" type="button" value="Add" onclick="return callAdd()"  />
			</td>
			<td class="style7">
			<input id="Button2" type="button" value="Subtract" onclick="return callSub()" /></td>
		</tr>
		<tr>
			<td class="style5">
			<input id="Button3" type="button" value="Multiply" onclick="return callMul()" /></td>
			<td class="style7">
			<input id="Button4" type="button" value="Divide" onclick="return callDiv()" /></td>
		</tr>
	</table>
	&nbsp;   
	</div>
	<asp:ScriptManager ID="ScriptManager1" runat="server">
		<services>
			<asp:servicereference Path="OperationService.svc" />
		</services>
	</asp:ScriptManager>
    <script language="javascript" type="text/javascript">

        function callAdd() {
            var Number1 = document.getElementById("Number1").value;
            var Number2 = document.getElementById("Number2").value;
            var service = new tempuri.org.OperationService();
            service.Add(parseFloat(Number1), parseFloat(Number2), onSuccess, null, null);
        }
        function callSub() {
            var Number1 = document.getElementById("Number1").value;
            var Number2 = document.getElementById("Number2").value;
            var service = new tempuri.org.OperationService();
            service.Subtract(parseFloat(Number1), parseFloat(Number2), onSuccess, null, null);
        }
        function callMul() {
            var Number1 = document.getElementById("Number1").value;
            var Number2 = document.getElementById("Number2").value;
            var service = new tempuri.org.OperationService();
            service.Multiply(parseFloat(Number1), parseFloat(Number2), onSuccess, null, null);
        }
        function callDiv() {
            var Number1 = document.getElementById("Number1").value;
            var Number2 = document.getElementById("Number2").value;
            var service = new tempuri.org.OperationService();
            service.Divide(parseFloat(Number1), parseFloat(Number2), onSuccess, null, null);
        }
        function onSuccess(result) {
            document.getElementById("result").value = result;
        }
</script>

</asp:Content>
