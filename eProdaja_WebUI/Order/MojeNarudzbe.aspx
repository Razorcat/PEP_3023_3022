<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MojeNarudzbe.aspx.cs" Inherits="eProdaja_WebUI.Order.MojeNarudzbe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>
                <asp:DataGrid ID="dgNarudzbe" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanged="dgNarudzbe_PageIndexChanged" DataKeyField="NarudzbaID" OnItemCommand="dgNarudzbe_ItemCommand" BackColor="Yellow" BorderColor="Fuchsia" BorderWidth="1px" Font-Bold="False" Font-Italic="True" Font-Names="Bell MT" Font-Overline="False" Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" ForeColor="Black">
        <PagerStyle Mode="NumericPages" />
        <Columns>            
            <asp:BoundColumn DataField="BrojNarudzbe" HeaderText="Broj narudžbe "> </asp:BoundColumn>
            <asp:BoundColumn DataField="Datum" HeaderText="Datum "> </asp:BoundColumn>
            <asp:BoundColumn DataField="Status" HeaderText="Isporučeno "> </asp:BoundColumn>
            <asp:BoundColumn DataField="Iznos" HeaderText="Iznos "> </asp:BoundColumn>
            <asp:TemplateColumn>
                <ItemTemplate>                                       
                    <asp:LinkButton ID="lbtnOtkaziNarudzbu" runat="server" CommandName="cmdOtkaziNarudzbu">Otkaži narudžbu</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateColumn>
        </Columns>
    </asp:DataGrid> 
            </td>
            <td>               
            </td>
        </tr>
    </table>
</asp:Content>
