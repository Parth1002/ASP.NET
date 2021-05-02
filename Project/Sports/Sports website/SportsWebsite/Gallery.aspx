<%@ Page Title="Gallery" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Gallery.aspx.cs" Inherits="Gallery" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/head_Gray_Gallery.jpg" />
    <asp:Panel ID="Panel1" BackColor="#999999" runat="server">
        <asp:DataList ID="dlstPhotos" runat="server" EnableTheming="False" RepeatColumns="4"
            Width="100%" Height="549px" DataSourceID="LinqDataSource1" ClientIDMode="Static"
            RepeatDirection="Horizontal">
            <ItemTemplate>
                <table cellpadding="6" style="width: 100%">
                    <tr>
                        <td style="width: 1px">
                            <asp:ImageButton runat="server" ImageAlign="Middle" Height="100px" Width="150px"
                                ID="img" ImageUrl='<%# "~/Images/Gallery/" + Eval("ImageUrl") %>' PostBackUrl='<%# Eval("ImageUrl", "Gallery_Photo.aspx?ImageUrl={0}") %>'
                                Tootltip='<%# Eval("ImageUrl") %>'></asp:ImageButton>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:HyperLink ID="hlTitle" NavigateUrl='<%# Eval("ImageUrl", "Gallery_Photo.aspx?ImageUrl={0}")%>'
                                runat="server"><%#Eval("ImageUrl") %></asp:HyperLink>
                        </td>
                    </tr>
                </table>
                <br />
            </ItemTemplate>
        </asp:DataList>
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" 
            ContextTypeName="DataClassesDataContext" EntityTypeName="" TableName="Photos">
        </asp:LinqDataSource>
    </asp:Panel>
    <cc1:RoundedCornersExtender ID="RoundedCornersExtender1" runat="server" TargetControlID="Panel1"
        Radius="10">
    </cc1:RoundedCornersExtender>
    <br />
</asp:Content>
