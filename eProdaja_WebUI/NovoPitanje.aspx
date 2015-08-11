<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NovoPitanje.aspx.cs" Inherits="eProdaja_WebUI.NovoPitanje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lblPitanje" runat="server" Text="Novo pitanje:" Font-Bold="True" Font-Size="Large"></asp:Label>
    <br />
    <asp:TextBox ID="txtbPitanje" runat="server" Height="200px" Width="600px" BackColor="#99FFCC" MaxLength="255" Rows="10" TextMode="MultiLine"></asp:TextBox>
    <br />
    <asp:Button ID="btnSpremi" runat="server" Text="Postavi pitanje" OnClick="btnSpremi_Click" />
</asp:Content>
