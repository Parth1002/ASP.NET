<%@ Page Title="Items" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="ItemsDetails.aspx.cs" Inherits="ItemsDetails" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<%@ Register Assembly="GCheckout" Namespace="GCheckout.Checkout" TagPrefix="cc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
    <style type="text/css">
        .style1
        {
            width: 433px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <asp:Panel ID="Panel1" runat="server" BackColor="#999999">
        <table style="width: 100%;">
            <tr>
                <td>
                    &nbsp;
                </td>
                <td class="style1">
                    <asp:Label ID="lblItemName" runat="server" Text="Label" Font-Bold="True" Font-Italic="False"
                        Font-Names="Verdana" Font-Size="17pt" ForeColor="#003399"></asp:Label>
                </td>
                <td align="right">
                    <asp:HyperLink runat="server" NavigateUrl="~/ItemsCategory.aspx" Font-Bold="True"
                        Font-Names="Verdana">More items  &gt;&gt;</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td class="style1">
                    <asp:Image ID="imgItem" runat="server" Height="299px" Width="355px" />
                </td>
                <td>
                    <asp:Label ID="lblDescription" runat="server" Text="Label" Font-Bold="True" Font-Names="Verdana"
                        ForeColor="White"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td class="style1">
                    <table style="width: 100%;">
                        <tr>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="Price (in USD)" Font-Bold="True" Font-Names="Verdana"
                                    ForeColor="White"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblPrice" runat="server" Text="Label" Font-Bold="True" Font-Names="Verdana"
                                    ForeColor="White"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label5" runat="server" Text="Status" Font-Bold="True" Font-Names="Verdana"
                                    ForeColor="White"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblStatus" runat="server" Text="Label" Font-Bold="True" Font-Names="Verdana"
                                    ForeColor="White"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label7" runat="server" Text="Enter the Quantity you want" Font-Bold="True"
                                    Font-Names="Verdana" ForeColor="White"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtQuantity" runat="server" Width="81px"></asp:TextBox>
                                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtQuantity"
                                    ErrorMessage="RequiredFieldValidator" Font-Bold="False" Font-Size="Medium" ForeColor="Red">*</asp:RequiredFieldValidator>
                                <asp:CustomValidator ID="CustomValidator1" runat="server" OnServerValidate="validatequantity"
                                    ErrorMessage="CustomValidator" ControlToValidate="txtQuantity" Font-Size="Medium"
                                    ForeColor="Red">*</asp:CustomValidator>
                            </td>
                        </tr>
                    </table>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td align="center" class="style1">
                    <cc2:GCheckoutButton ID="GCheckoutButton1" runat="server" OnClick="GCheckoutButton1_Click"
                        Currency="USD" />
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
        </table>
    </asp:Panel>
    <cc1:RoundedCornersExtender ID="RoundedCornersExtender1" runat="server" TargetControlID="Panel1"
        Radius="10">
    </cc1:RoundedCornersExtender>
</asp:Content>
