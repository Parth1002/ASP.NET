<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style2
        {
        }
        .style3
        {
            width: 565px;
            height: 476px;
        }
        .style4
        {
            height: 476px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <table style="width: 100%;">
        <tr>
            <td class="style3">
                <asp:Panel ID="Panel3" runat="server" BackColor="#999999" Height="436px" HorizontalAlign="Center"
                    Width="591px">
                    <br />
                    <object id="Silverlight1" type="application/x-silverlight" style="height: 401px;
                        width: 563px; background-color: #999999; background: #999999">
                        <param name="Source" value="ClientBin/Sports.xap" />
                        <param name="EnableGPUAcceleration" value="true" />
                    </object>
                </asp:Panel>
                <cc1:RoundedCornersExtender ID="RoundedCornersExtender1" TargetControlID="Panel3"
                    Radius="10" runat="server">
                </cc1:RoundedCornersExtender>
            </td>
            <td valign="top" align="center" class="style4">
                <asp:Panel ID="Panel5" runat="server" BackColor="#999999" HorizontalAlign="Center">
                    <asp:Panel ID="Panel7" runat="server" BackImageUrl="~/Images/Label_Red_long.jpg"
                        Height="34px" Width="331px">
                        <asp:Label ID="Label11" runat="server" Font-Italic="False" Font-Names="Arial" Font-Overline="False"
                            Font-Size="Large" ForeColor="White" Text="ITEMS"></asp:Label>
                    </asp:Panel>
                    <asp:DataList ID="dlstItems" runat="server" DataSourceID="SqlDataSource2" EnableTheming="False"
                        Height="411px" RepeatColumns="2" Width="98%">
                        <ItemTemplate>
                            <table style="width: 100%">
                                <tr>
                                    <td>                                        
                                        <asp:ImageButton ID="img" runat="server" Height="80px" ImageUrl='<%# "~/Images/Items/" + Eval("ImageUrl") %>'
                                            PostBackUrl='<%# Eval("ItemsID", "ItemsDetails.aspx?ItemsID={0}") %>' Width="100px" />
                                        <br />
                                        <asp:Label ID="lblName" runat="server" Font-Bold="True" ForeColor="White" Font-Names="Verdana"><%#Eval("Name") %></asp:Label>
                                        <br />
                                        <asp:HyperLink ID="hlbuythis" runat="server" Font-Bold="True" Font-Names="Verdana"
                                            NavigateUrl='<%# Eval("ItemsID", "ItemsDetails.aspx?ItemsID={0}") %>'>Buy this</asp:HyperLink>
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:DataList>
                    <div align="right">
                    <asp:HyperLink ID="hlMoreItems" runat="server" Font-Bold="True" 
                        Font-Names="Verdana" NavigateUrl="~/ItemsCategory.aspx">More Items.</asp:HyperLink>
                    </div>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Data Source=UMAR-PC;Initial Catalog=Sports;Persist Security Info=True;User ID=sa;Password=1234"
                        ProviderName="System.Data.SqlClient" SelectCommand="SELECT TOP 6 * FROM [Items] Order By NewID()">
                    </asp:SqlDataSource>
                </asp:Panel>
                <cc1:RoundedCornersExtender ID="RoundedCornersExtender4" runat="server" Radius="10"
                    TargetControlID="Panel5">
                </cc1:RoundedCornersExtender>
            </td>
            <td class="style4">
            </td>
        </tr>
        <tr>
            <td class="style2" valign="top" colspan="2">
                <asp:Panel ID="Panel1" runat="server" BackColor="#999999" Style="margin-right: 0px">
                    <asp:Panel ID="Panel2" runat="server" Height="34px" BackImageUrl="~/Images/Label_Red_long.jpg"
                        HorizontalAlign="Center">
                        <asp:Label ID="Label10" runat="server" Font-Names="Arial" Font-Size="Large" ForeColor="White"
                            Text="ARTICLES" Font-Italic="False" Font-Overline="False"></asp:Label>
                    </asp:Panel>
                    <div>
                        <asp:DataList ID="dlstCategories" runat="server" EnableTheming="False" RepeatColumns="3"
                            Width="98%" DataSourceID="SqlDataSource1">
                            <ItemTemplate>
                                <table cellpadding="6" style="width: 100%">
                                    <tr>
                                        <td valign="top" style="width: 1px">                                            
                                            <asp:ImageButton runat="server" Height="80px" Width="100px" ID="img" ImageUrl='<%# Eval("ImageUrl") %>'
                                                PostBackUrl='<%# Eval("ArticleID", "Articles.aspx?ArticleID={0}") %>'></asp:ImageButton>
                                        </td>
                                        <td>
                                            <div>
                                                <asp:Label ID="lblTitle" runat="server" ForeColor="#003399" Font-Bold="True"><%#Eval("Title") %></asp:Label>
                                                <br />
                                                <asp:Label ID="lblAbstract" ForeColor="White" runat="server"><%#Eval("Abstract") %></asp:Label>
                                                <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# Eval("ArticleID", "Articles.aspx?ArticleID={0}") %>'
                                                    runat="server">Read more</asp:HyperLink>
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:DataList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=UMAR-PC;Initial Catalog=Sports;Persist Security Info=True;User ID=sa;Password=1234"
                            ProviderName="System.Data.SqlClient" SelectCommand="SELECT top 3 * FROM [Articles]">
                        </asp:SqlDataSource>
                        <cc1:RoundedCornersExtender ID="RoundedCornersExtender3" runat="server" TargetControlID="Panel1"
                            Radius="10">
                        </cc1:RoundedCornersExtender>                        
                    </div>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td class="style2">
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
    <br />
</asp:Content>
