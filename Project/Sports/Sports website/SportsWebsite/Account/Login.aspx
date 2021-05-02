<%@ Page Title="Log In" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Login.aspx.cs" Inherits="Account_Login" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            width: 456px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <table style="width: 100%;">
        <tr>
            <td class="style1" style="width: 465px">
                <asp:Panel ID="Panel1" BackColor="#BBBBBB" runat="server" Width="557px">
                    <h2>
                        Log In
                    </h2>
                    <p style="color: #FFFFFF">
                        Please enter your username and password.
                        <asp:HyperLink ID="RegisterHyperLink" runat="server" EnableViewState="false">Register</asp:HyperLink>
                        if you don't have an account.
                    </p>
                    <asp:Login ID="LoginUser" runat="server" EnableViewState="false" RenderOuterTable="false">
                        <LayoutTemplate>
                            <span class="failureNotification">
                                <asp:Literal ID="FailureText" runat="server"></asp:Literal>
                            </span>
                            <asp:ValidationSummary ID="LoginUserValidationSummary" runat="server" CssClass="failureNotification"
                                ValidationGroup="LoginUserValidationGroup" />
                            <div class="accountInfo">
                                <fieldset class="login">
                                    <legend>Account Information</legend>
                                    <p>
                                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Username:</asp:Label>
                                        <asp:TextBox ID="UserName" runat="server" CssClass="textEntry" Width="200px"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName"
                                            CssClass="failureNotification" ErrorMessage="User Name is required." ToolTip="User Name is required."
                                            ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                                    </p>
                                    <p>
                                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label>
                                        <asp:TextBox ID="Password" runat="server" CssClass="passwordEntry" TextMode="Password"
                                            Width="200px"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password"
                                            CssClass="failureNotification" ErrorMessage="Password is required." ToolTip="Password is required."
                                            ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                                    </p>
                                    <p>
                                        <asp:CheckBox ID="RememberMe" runat="server" />
                                        <asp:Label ID="RememberMeLabel" runat="server" AssociatedControlID="RememberMe" CssClass="inline">Keep me logged in</asp:Label>
                                    </p>
                                </fieldset>
                                <p>
                                   <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Log In" ValidationGroup="LoginUserValidationGroup" /> &nbsp;</p>
                                
                            </div>
                        </LayoutTemplate>
                    </asp:Login>
                </asp:Panel>
                <cc1:RoundedCornersExtender ID="RoundedCornersExtender1" runat="server" TargetControlID="Panel1"
                    Radius="10">
                </cc1:RoundedCornersExtender>
            </td>
            <td>
                <asp:Panel ID="Panel2" runat="server" BackColor="#BBBBBB" Height="163px" Width="267px">
                    <table style="width: 100%;">
                        <tr>
                            <td>
                                <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/MySports.jpg" />
                            </td>
                        </tr>
                        <tr>
                            <td align="center" style="color: #FFFFFF">
                                <br />
                                New to MY Sports?
                            </td>
                        </tr>
                        <tr>
                            <td align="center">
                                <br />
                                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/CreateAccount.jpg"
                                    PostBackUrl="~/Account/Register.aspx" CausesValidation="False" />
                            </td>
                        </tr>
                    </table>
                    <br />
                </asp:Panel>
                <cc1:RoundedCornersExtender ID="Panel2_RoundedCornersExtender" runat="server" BehaviorID="RoundedCornersExtender2"
                    Enabled="True" Radius="10" TargetControlID="Panel2">
                </cc1:RoundedCornersExtender>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
    </table>
</asp:Content>
