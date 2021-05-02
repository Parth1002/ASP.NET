<%@ Page Title="Items" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="ItemsCategory.aspx.cs" Inherits="Items" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/head_ItemCategories.jpg" />
    <table style="width: 100%;">
        <tr>
            <td>
                <asp:Panel ID="Panel1" runat="server" BackColor="#999999" Style="margin-right: 0px"
                    Width="931px">
                    <asp:DataList ID="dlstItemCategories" runat="server" EnableTheming="False" RepeatColumns="3"
                        Width="100%" DataSourceID="SqlDataSource1" Height="549px">
                        <ItemTemplate>
                            <table cellpadding="6" style="width: 100%">
                                <tr>
                                    <td style="width: 1px">
                                        <asp:ImageButton runat="server" Height="130px" Width="150px" ID="img" ImageUrl='<%# "~/Images/Items/" + Eval("ImageUrl") %>'
                                            PostBackUrl='<%# Eval("CategoryID", "Items.aspx?CategoryID={0}") %>'></asp:ImageButton>
                                    </td>
                                    <td>
                                        <div>
                                            <asp:HyperLink ID="hlName" Font-Bold="True" Font-Names="Verdana" NavigateUrl='<%# Eval("CategoryID", "Items.aspx?CategoryID={0}") %>'
                                                runat="server"><%#Eval("Name") %></asp:HyperLink>
                                            <br />
                                            <asp:Label ID="lblDescription" runat="server" Font-Bold="True" Font-Names="Verdana"
                                                ForeColor="White"><%#Eval("Description") %></asp:Label>
                                        </div>
                                        <br />
                                    </td>
                                </tr>
                            </table>
                            <br />
                        </ItemTemplate>
                    </asp:DataList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=.;Initial Catalog=Sports;Integrated Security=True"
                        ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Items_Categories]">
                    </asp:SqlDataSource>
                </asp:Panel>
                <cc1:RoundedCornersExtender ID="RoundedCornersExtender1" runat="server" TargetControlID="Panel1"
                    Radius="10">
                </cc1:RoundedCornersExtender>
            </td>            
        </tr>
    </table>
</asp:Content>
