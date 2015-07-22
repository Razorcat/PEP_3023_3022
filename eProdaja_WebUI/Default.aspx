<%@ Page Title="Avon" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="eProdaja_WebUI._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %></h1>
                <h3> </h3>
            </hgroup>
            <p>
              The company for women
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3></h3>
    <table>
        <tr>
            <td>Vrsta:</td>
            <td>Naziv:</td>

        </tr>
         <tr>
            <td>
                <asp:DropDownList ID="vrsteList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="vrsteList_SelectedIndexChanged"></asp:DropDownList></td>
            <td>
                <asp:TextBox ID="nazivInput" runat="server" OnTextChanged="nazivInput_TextChanged"></asp:TextBox></td>
             <td>
                <asp:Button ID="traziButton" runat="server" Text="Traži" OnClick="traziButton_Click" /></td>
        </tr>
    </table>
    <br />
    <asp:GridView ID="proizvodiGrid" runat="server" AutoGenerateColumns="false" DataSource="<%# proizvodi %>"
        AllowPaging="true" AllowCustomPaging="true" PageSize="3" OnPageIndexChanging="proizvodiGrid_PageIndexChanging" OnRowCommand="proizvodiGrid_RowCommand">
        <PagerSettings Mode="NextPreviousFirstLast" FirstPageText="First" LastPageText="Last" NextPageText="Next" PreviousPageText="Previous" />
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Image ImageUrl='<%# string.Format("/ImageHandler.ashx?id={0}", Eval("ProizvodID")) %>'  runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Sifra" HeaderText="Šifra" />
            <asp:BoundField DataField="Naziv" HeaderText="Naziv" />
            <asp:BoundField DataField="Cijena" HeaderText="Cijena" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:TextBox ID="kolicinaInput" runat="server" Text="1" Width="20px"></asp:TextBox>
                    <asp:LinkButton ID="LinkButton1" runat="server" CommandName="AddCommand" CommandArgument='<%# Eval("ProizvodID") %>'>Dodaj u korpu</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
