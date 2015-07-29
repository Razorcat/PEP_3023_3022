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
    <h4>Preporuka</h4>
                 <asp:DataGrid ID="gdPreporuka" runat="server"  AutoGenerateColumns="False" PageSize="5" DataKeyField="ProizvodID" OnItemCommand="dgProizvodi_ItemCommandPreporuka" BackColor="#66FFFF" BorderColor="Black" BorderStyle="Groove" BorderWidth="1px" ForeColor="#000066" Font-Bold="False" Font-Italic="True" Font-Overline="False" Font-Size="Small" Font-Strikeout="False" Font-Underline="False">                        
                        <Columns>
                            <asp:TemplateColumn>
                                <ItemTemplate>
                                    <asp:Image ImageUrl='<%# string.Format("/ImageHandler.ashx?id={0}", Eval("ProizvodID")) %>'  runat="server" />
                                    <%--<asp:Image ID="imgSlikaThumb" runat="server" BackColor="#FF9999" BorderStyle="Solid" />--%>
                                 </ItemTemplate>
                             </asp:TemplateColumn>
                                    <asp:BoundColumn DataField="Naziv" HeaderText="Naziv "> </asp:BoundColumn>
                                    <asp:BoundColumn DataField="Sifra" HeaderText="Šifra "> </asp:BoundColumn>
                                    <asp:BoundColumn DataField="Cijena" HeaderText="Cijena "> </asp:BoundColumn>
                            <asp:TemplateColumn>
                                <ItemTemplate>              
                                    <asp:TextBox ID="txtbKolicina" runat="server" Width="25px" Text="1"></asp:TextBox>
                                    <asp:LinkButton ID="lbtnDodajUKosaricu" runat="server" CommandName="DodajUKopruCmd">Dodaj u košarici</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            </Columns>
                        <HeaderStyle Font-Bold="True" Font-Italic="True" Font-Overline="False" Font-Size="Small" Font-Strikeout="False" Font-Underline="False" />
                     </asp:DataGrid>
    <br />    
    <asp:Label ID="lblBrosura" runat="server" Text="Brošura"></asp:Label>
   
    <asp:ObjectDataSource ID="odsLvBrosura" runat="server" SelectMethod="SelectAll" TypeName="eProdaja_Service.Data.DABrosure"></asp:ObjectDataSource>
   
    <asp:GridView ID="gvBrosure" runat="server" AutoGenerateColumns="False" PageSize="3" DataSourceID="odsLvBrosura" AllowPaging="True">
        <Columns>
            <asp:CommandField ShowSelectButton="True" SelectText="Odaberi" />
            <asp:BoundField DataField="BrosuraID" HeaderText="BrosuraID" SortExpression="BrosuraID" Visible="False" />
            <asp:BoundField DataField="NazivBrosure" HeaderText="NazivBrosure" SortExpression="NazivBrosure" >
            <HeaderStyle Width="155px" />
            <ItemStyle Width="155px" />
            </asp:BoundField>
            <asp:BoundField DataField="DatumPocetka" HeaderText="DatumPocetka" SortExpression="DatumPocetka" >
            <HeaderStyle Width="125px" />
            </asp:BoundField>
            <asp:BoundField DataField="DatumIsteka" HeaderText="DatumIsteka" SortExpression="DatumIsteka" />
        </Columns>
    </asp:GridView>
    </asp:Content>
