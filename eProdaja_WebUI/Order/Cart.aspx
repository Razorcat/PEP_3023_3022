<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="eProdaja_WebUI.Order.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
      <asp:GridView ID="narudzbaGrid" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="Proizvodi" HeaderText="Proizvod" />
            <asp:BoundField DataField="Kolicina" HeaderText="Količina" />
        </Columns>
    </asp:GridView>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Iznos računa:" Font-Bold="true"></asp:Label>
    &nbsp;<asp:Label ID="iznosLabel" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Button runat="server" ID="zakljuciNarudzbuSubmit" Text="Zaključi" OnClick="zakljuciNarudzbuSubmit_Click" />
</asp:Content>
