	<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Welcome Page</title>
</head>
<body background="nature.jpg" bgcolor="#99ff66">
    <form id="form1" runat="server">
    <div style="border-style: ridge; font-weight: 800; font-family: 'Bookman Old Style'; font-size: xx-large; font-style: normal;">
    
        Welcome to C# 2010 Black Book
        </div>
    <p style="margin-left: 840px">
        <asp:Button ID="Button2" runat="server" Font-Bold="True" 
            Font-Names="Arial Rounded MT Bold" Font-Size="Small" onclick="Button2_Click" 
            Text="Show Marks" Width="130px" PostBackUrl ="~/Marks.aspx" />
    </p>
    <p>
        &nbsp;</p>
    <p style="margin-left: 400px">
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Roll Number" 
            Font-Names="Bookman Old Style" Font-Size="Small"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Font-Names="Bookman Old Style" 
            Font-Size="Small" TabIndex="1"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <div style="margin-left: 400px">
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Name" 
            Font-Names="Bookman Old Style" Font-Size="Small"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Font-Names="Bookman Old Style" 
            Font-Size="Small" TabIndex="2"></asp:TextBox>
    </div>
    <p style="margin-left: 480px">
        <asp:Button ID="Button1" runat="server" Font-Bold="True" Text="Welcome" 
            Width="121px" AccessKey="W" Font-Names="Bookman Old Style" 
            Font-Size="Medium" onclick="Button1_Click" TabIndex="3" ToolTip="Click" />
    </p>
    <div style="margin-left: 120px">
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Font-Names="Bookman Old Style" 
            Font-Size="Small" Text="Label" Visible="False"></asp:Label>
    </div>
    </form>
</body>
</html>
