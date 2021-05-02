<%@ Page Title="Items" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Items.aspx.cs" Inherits="Items" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
    <style type="text/css">
        .style1
        {
            width: 107px;
        }
        .style2
        {
            width: 207px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/head_Items.jpg" />
    <table style="width: 100%;">
        <tr>
            <td valign="top" class="style1">
                <asp:Panel ID="Panel2" BackColor="#999999" runat="server" Width="135px" HorizontalAlign="Justify"
                    Height="600px">
                    <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource2">
                        <ItemTemplate>
                            <asp:Image ID="Image1" Height="30px" Width="30px" runat="server" ImageUrl='<%# "~/Images/Items/" + Eval("ImageUrl") %>'>
                            </asp:Image>
                            &nbsp<asp:HyperLink ID="HyperLink1" NavigateUrl='<%# Eval("CategoryID", "Items.aspx?CategoryID={0}") %>'
                                runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="11pt" ForeColor="White"><%# Eval("Name") %></asp:HyperLink>
                            <br />
                        </ItemTemplate>
                        <ItemSeparatorTemplate>
                            <hr />
                        </ItemSeparatorTemplate>
                        <SelectedItemTemplate>
                            <div style="background-image: url('http://localhost:4639/SportsWebsite/Images/Label_Red.jpg');">
                                <asp:Image ID="Image1" Height="30px" Width="30px" runat="server" ImageUrl='<%# "~/Images/Items/" + Eval("ImageUrl") %>'>
                                </asp:Image>
                                &nbsp<asp:HyperLink ID="HyperLink1" NavigateUrl='<%# Eval("CategoryID", "Items.aspx?CategoryID={0}") %>'
                                    runat="server" Font-Bold="True" Font-Names="Verdana" Font-Size="13pt" ForeColor="White"><%# Eval("Name") %></asp:HyperLink>
                            </div>
                        </SelectedItemTemplate>
                        <LayoutTemplate>
                            <asp:PlaceHolder ID="itemPlaceholder" runat="server"></asp:PlaceHolder>
                        </LayoutTemplate>
                    </asp:ListView>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Data Source=.;Initial Catalog=Sports;Integrated Security=True"
                        ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Items_Categories]">
                    </asp:SqlDataSource>
                </asp:Panel>
                <cc1:RoundedCornersExtender ID="RoundedCornersExtender2" runat="server" TargetControlID="Panel2"
                    Radius="10">
                </cc1:RoundedCornersExtender>
            </td>
            <td valign="top">
                <asp:Panel ID="Panel1" runat="server" BackColor="#999999" Style="margin-right: 0px"
                    Width="612px">
                    <br />
                    <asp:DataList ID="dlstItems" runat="server" DataSourceID="SqlDataSource1" EnableTheming="False"
                        Height="549px" RepeatColumns="1" Width="98%">                       
                        <ItemTemplate>
                            <table cellpadding="6" style="width: 100%">
                                <tr>
                                    <td style="width: 1px">                                        
                                        <asp:ImageButton ID="img" runat="server" Height="180px" ImageUrl='<%# "~/Images/Items/" + Eval("ImageUrl") %>'
                                            PostBackUrl='<%# Eval("ItemsID", "ItemsDetails.aspx?ItemsID={0}") %>' Width="200px" />
                                    </td>
                                    <td>
                                        <div>                                           
                                            <asp:Label ID="lblName" runat="server" Font-Bold="True" Font-Names="Verdana" ForeColor="White"><%#Eval("Name") %></asp:Label>
                                            <br />
                                            <asp:Label ID="lblPrice" runat="server" Font-Bold="True" Font-Names="Verdana" ForeColor="White">Price: $<%#Eval("Price") %></asp:Label>
                                            <br />
                                            <asp:Label ID="lblStatus" runat="server" Font-Bold="True" Font-Names="Verdana" ForeColor="White"><%#Eval("Status") %></asp:Label>
                                            <br />
                                            <asp:HyperLink ID="hlbuythis" runat="server" Font-Bold="True" Font-Names="Verdana"
                                                NavigateUrl='<%# Eval("ItemsID", "ItemsDetails.aspx?ItemsID={0}") %>'> Buy this </asp:HyperLink>
                                        </div>
                                        <br />
                                    </td>
                                </tr>
                            </table>
                            <br />
                        </ItemTemplate>
                        <AlternatingItemTemplate>
                            <table cellpadding="6" style="width: 100%">
                                <tr>
                                    <td class="style2">
                                        <div>
                                            <asp:Label ID="lblName" runat="server" Font-Bold="True" Font-Names="Verdana" ForeColor="White"><%#Eval("Name") %></asp:Label>
                                            <br />
                                            <asp:Label ID="lblPrice" runat="server" Font-Bold="True" Font-Names="Verdana" ForeColor="White">Price: $<%#Eval("Price") %></asp:Label>
                                            <br />
                                            <asp:Label ID="lblStatus" runat="server" Font-Bold="True" Font-Names="Verdana" ForeColor="White"><%#Eval("Status") %></asp:Label>
                                            <br />
                                            <asp:HyperLink ID="hlbuythis" runat="server" Font-Bold="True" Font-Names="Verdana"
                                                NavigateUrl='<%# Eval("ItemsID", "ItemsDetails.aspx?ItemsID={0}") %>'> Buy this </asp:HyperLink>
                                        </div>
                                        <br />
                                    </td>
                                    <td>
                                        <asp:ImageButton ID="img" runat="server" Height="180px" ImageUrl='<%# "~/Images/Items/" + Eval("ImageUrl") %>'
                                            PostBackUrl='<%# Eval("ItemsID", "ItemsDetails.aspx?ItemsID={0}") %>' Width="200px" />
                                    </td>
                                </tr>
                            </table>
                        </AlternatingItemTemplate>
                    </asp:DataList>               
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=.;Initial Catalog=Sports;Integrated Security=True"
                        ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Items] WHERE ([CategoryID] = @CategoryID)">
                        <SelectParameters>
                            <asp:QueryStringParameter Name="CategoryID" QueryStringField="CategoryID" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </asp:Panel>
                <cc1:RoundedCornersExtender ID="RoundedCornersExtender1" runat="server" TargetControlID="Panel1"
                    Radius="10">
                </cc1:RoundedCornersExtender>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
