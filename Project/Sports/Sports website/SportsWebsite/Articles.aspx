<%@ Page Title="Articles" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    EnableEventValidation="false" CodeFile="Articles.aspx.cs" Inherits="Articles" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
    <style type="text/css">
        .style1
        {
            width: 174px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/head_Gray_Articles.jpg"
        Width="664px" />
    <table style="width: 100%;">
        <tr>
            <td valign="top" class="style1">
                <asp:Panel ID="Panel1" runat="server" BackColor="#999999" Width="598px">
                    <table style="width: 100%;">
                        <tr>
                            <td>
                                <hr />
                                <br />
                                <asp:Label ID="lblTitle" runat="server" Text="Label" Font-Bold="True" Font-Italic="False"
                                    Font-Names="Verdana" Font-Size="17pt" ForeColor="#003399"></asp:Label>
                                <br />
                                <asp:Label ID="lbladdedBy" runat="server" Text="Label"></asp:Label>
                                <br />
                                <asp:Label ID="lbladdedDate" runat="server" Text="Label"></asp:Label>
                                <br />
                                <hr />
                            </td>
                        </tr>
                        <tr>
                            <td align="center">
                                <asp:Image ID="imgArticle" runat="server" Height="247px" Width="344px" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblBody" runat="server" Font-Names="Verdana" ForeColor="White" Text="Label"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
                <cc1:RoundedCornersExtender ID="RoundedCornersExtender1" runat="server" TargetControlID="Panel1">
                </cc1:RoundedCornersExtender>
                <hr style="width: 595px" />
                <asp:Panel ID="Panel5" runat="server" BackColor="#999999" Width="594px">
                    <asp:Label ID="Label1" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="15pt"
                        ForeColor="#003399" Text="Comments"></asp:Label>
                    <br />
                    <asp:DataList ID="dlComments" runat="server" DataSourceID="SqlDataSource1" Font-Names="Verdana"
                        ForeColor="White">
                        <ItemTemplate>
                            Commented By:
                            <asp:Label ID="AddedByLabel" runat="server" Text='<%# Eval("AddedBy") %>' />
                            <br />
                            <asp:Label ID="AddedDateLabel" runat="server" Text='<%# Eval("AddedDate") %>' />
                            <br />
                            <br />
                            Comment:
                            <asp:Label ID="BodyLabel" runat="server" Text='<%# Eval("Body") %>' />
                            <br />
                            <hr />
                        </ItemTemplate>
                    </asp:DataList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=.;Initial Catalog=Sports;Integrated Security=True"
                        ProviderName="System.Data.SqlClient" SelectCommand="SELECT [AddedBy], [AddedDate], [Body] FROM [Comments] WHERE ([ArticleID] = @ArticleID)">
                        <SelectParameters>
                            <asp:QueryStringParameter Name="ArticleID" QueryStringField="ArticleID" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <asp:HyperLink ID="HyperLink1" runat="server" Font-Size="15pt" ForeColor="#003399">You need Login for making comments</asp:HyperLink>
                </asp:Panel>
                <cc1:RoundedCornersExtender ID="RoundedCornersExtender4" runat="server" TargetControlID="Panel5">
                </cc1:RoundedCornersExtender>
                <br />
                <asp:Panel ID="pnlComments" runat="server" Width="594px" BackColor="#999999" BorderColor="White">
                    <table style="width: 100%;">
                        <tr>
                            <td>
                                <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Size="12pt" ForeColor="White"
                                    Text="Leave a Comment" Font-Underline="True"></asp:Label>
                            </td>
                            <td>
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:TextBox ID="txtComments" runat="server" Height="71px" Width="573px" TextMode="MultiLine"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" colspan="2">
                                <asp:Button ID="btnSubmit" runat="server" Height="27px" OnClick="btnSubmit_Click"
                                    Text="Submit" Width="81px" />
                            </td>
                        </tr>
                    </table>
                    <br />
                    <br />
                </asp:Panel>
                <cc1:RoundedCornersExtender ID="RoundedCornersExtender2" runat="server" TargetControlID="pnlComments">
                </cc1:RoundedCornersExtender>
            </td>
            <td valign="top">
                <asp:Panel ID="Panel2" runat="server" BackColor="#999999" HorizontalAlign="Center">
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="245px" ImageUrl="~/Images/ad.gif"
                        Width="255px" PostBackUrl="http://www.australianopen.com/en_AU/index.html" />
                </asp:Panel>
                <hr />
                <asp:Panel ID="Panel3" runat="server" BackColor="#999999" HorizontalAlign="Center"
                    Style="margin-right: 0px" Width="320px">
                    <asp:Panel ID="Panel4" runat="server" Height="34px" Width="316px" BackImageUrl="~/Images/Label_Red.jpg"
                        HorizontalAlign="Center">
                        <asp:Label ID="Label10" runat="server" BackImageUrl="~/Images/Label_Red.jpg" Font-Names="Arial"
                            Font-Size="Large" ForeColor="White" Text="OTHER ARTICLES" Font-Italic="False"
                            Font-Overline="False"></asp:Label>
                    </asp:Panel>
                    <div>
                        <asp:ListView ID="lstArticles" runat="server">
                            <ItemTemplate>
                                <asp:Table runat="server">
                                    <asp:TableRow>
                                        <asp:TableCell>
                                            <asp:ImageButton runat="server" Height="145px" Width="268px" ID="img" ImageUrl='<%# Eval("ImageUrl") %>'
                                                PostBackUrl='<%# Eval("ArticleID", "Articles.aspx?ArticleID={0}") %>'></asp:ImageButton>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                    <asp:TableRow>
                                        <asp:TableCell>
                                            <table>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="lblTitle" runat="server" ForeColor="#003399" Font-Bold="True"><%#Eval("Title") %></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="lblAbstract" runat="server" ForeColor="White"><%#Eval("Abstract") %></asp:Label>
                                                        <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# Eval("ArticleID", "Articles.aspx?ArticleID={0}") %>'
                                                            runat="server"> Read more</asp:HyperLink>
                                                    </td>
                                                </tr>
                                        </asp:TableCell>
                                    </asp:TableRow>
                                </asp:Table>
                                <br />
                            </ItemTemplate>
                        </asp:ListView>
                    </div>
                </asp:Panel>
            </td>
        </tr>
    </table>
</asp:Content>
