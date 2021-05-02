<%@ Page Title="Articles" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Articles_List.aspx.cs" Inherits="Articles_List" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <table style="width: 100%;">
        <tr>
            <td>
                <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/head_Gray_Articles.jpg" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Panel ID="Panel1" runat="server" BackColor="#999999" Style="margin-right: 0px"
                    Width="931px">
                    <asp:DataList ID="dlstCategories" runat="server" EnableTheming="False" RepeatColumns="2"
                        Width="100%" DataSourceID="SqlDataSource1" Height="549px">
                        <ItemTemplate>
                            <table cellpadding="6" style="width: 100%">
                                <tr>
                                    <td style="width: 1px">
                                        <asp:ImageButton runat="server" Height="145px" Width="268px" ID="img" ImageUrl='<%# Eval("ImageUrl") %>'
                                            PostBackUrl='<%# Eval("ArticleID", "Articles.aspx?ArticleID={0}") %>'></asp:ImageButton>
                                    </td>
                                    <td>
                                        <div>
                                            <asp:Label ID="lblTitle" runat="server" ForeColor="#003399" Font-Bold="True"><%#Eval("Title") %></asp:Label>
                                            <br />
                                            <asp:Label ID="lblAbstract" runat="server" ForeColor="White"><%#Eval("Abstract") %></asp:Label>
                                            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# Eval("ArticleID", "Articles.aspx?ArticleID={0}") %>'
                                                runat="server"> Read more</asp:HyperLink>
                                        </div>
                                        <br />
                                    </td>
                                </tr>
                            </table>
                            <br />
                        </ItemTemplate>
                    </asp:DataList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=.;Initial Catalog=Sports;Integrated Security=True"
                        ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Articles]">
                    </asp:SqlDataSource>
                </asp:Panel>
                <cc1:RoundedCornersExtender ID="RoundedCornersExtender1" runat="server" TargetControlID="Panel1"
                    Radius="10">
                </cc1:RoundedCornersExtender>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
        </tr>
    </table>
</asp:Content>
