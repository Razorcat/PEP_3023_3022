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
    <asp:Label ID="lblPreporuka" runat="server" Text="Preporuka"></asp:Label>
    <h4>Preporuka</h4>
                 <asp:DataGrid ID="gdPreporuka" runat="server"  AutoGenerateColumns="False" PageSize="5"  OnItemDataBound="dgProizvodi_ItemDataBoundPreporuka" DataKeyField="ProizvodID" OnItemCommand="dgProizvodi_ItemCommandPreporuka" BackColor="#FFFFCC" BorderColor="Black" BorderStyle="Groove" BorderWidth="2px" ForeColor="#FF5050">                        
                        <Columns>
                            <asp:TemplateColumn>
                                <ItemTemplate>
                                    <asp:Image ID="imgSlikaThumb" runat="server" BackColor="#FF9999" BorderStyle="Solid" />
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
                     </asp:DataGrid>
    <br />    
    <asp:Label ID="lblBrosura" runat="server" Text="Brošura"></asp:Label>
   
    <asp:ListView ID="lvBrosura" runat="server" DataSourceID="odsLvBrosura">
        <AlternatingItemTemplate>
            <tr style="background-color:#FFF8DC;">
                <td>
                    <asp:Label ID="BrosuraIDLabel" runat="server" Text='<%# Eval("BrosuraID") %>' />
                </td>
                <td>
                    <asp:Label ID="NazivBrosureLabel" runat="server" Text='<%# Eval("NazivBrosure") %>' />
                </td>
                <td>
                    <asp:Label ID="DatumPocetkaLabel" runat="server" Text='<%# Eval("DatumPocetka") %>' />
                </td>
                <td>
                    <asp:Label ID="DatumIstekaLabel" runat="server" Text='<%# Eval("DatumIsteka") %>' />
                </td>
                <td>
                    <asp:Label ID="BrosureProizvodiLabel" runat="server" Text='<%# Eval("BrosureProizvodi") %>' />
                </td>
            </tr>
        </AlternatingItemTemplate>
        <EditItemTemplate>
            <tr style="background-color:#008A8C;color: #FFFFFF;">
                <td>
                    <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                </td>
                <td>
                    <asp:TextBox ID="BrosuraIDTextBox" runat="server" Text='<%# Bind("BrosuraID") %>' />
                </td>
                <td>
                    <asp:TextBox ID="NazivBrosureTextBox" runat="server" Text='<%# Bind("NazivBrosure") %>' />
                </td>
                <td>
                    <asp:TextBox ID="DatumPocetkaTextBox" runat="server" Text='<%# Bind("DatumPocetka") %>' />
                </td>
                <td>
                    <asp:TextBox ID="DatumIstekaTextBox" runat="server" Text='<%# Bind("DatumIsteka") %>' />
                </td>
                <td>
                    <asp:TextBox ID="BrosureProizvodiTextBox" runat="server" Text='<%# Bind("BrosureProizvodi") %>' />
                </td>
            </tr>
        </EditItemTemplate>
        <EmptyDataTemplate>
            <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                <tr>
                    <td>No data was returned.</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <tr style="">
                <td>
                    <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                </td>
                <td>
                    <asp:TextBox ID="BrosuraIDTextBox" runat="server" Text='<%# Bind("BrosuraID") %>' />
                </td>
                <td>
                    <asp:TextBox ID="NazivBrosureTextBox" runat="server" Text='<%# Bind("NazivBrosure") %>' />
                </td>
                <td>
                    <asp:TextBox ID="DatumPocetkaTextBox" runat="server" Text='<%# Bind("DatumPocetka") %>' />
                </td>
                <td>
                    <asp:TextBox ID="DatumIstekaTextBox" runat="server" Text='<%# Bind("DatumIsteka") %>' />
                </td>
                <td>
                    <asp:TextBox ID="BrosureProizvodiTextBox" runat="server" Text='<%# Bind("BrosureProizvodi") %>' />
                </td>
            </tr>
        </InsertItemTemplate>
        <ItemTemplate>
            <tr style="background-color:#DCDCDC;color: #000000;">
                <td>
                    <asp:Label ID="BrosuraIDLabel" runat="server" Text='<%# Eval("BrosuraID") %>' />
                </td>
                <td>
                    <asp:Label ID="NazivBrosureLabel" runat="server" Text='<%# Eval("NazivBrosure") %>' />
                </td>
                <td>
                    <asp:Label ID="DatumPocetkaLabel" runat="server" Text='<%# Eval("DatumPocetka") %>' />
                </td>
                <td>
                    <asp:Label ID="DatumIstekaLabel" runat="server" Text='<%# Eval("DatumIsteka") %>' />
                </td>
                <td>
                    <asp:Label ID="BrosureProizvodiLabel" runat="server" Text='<%# Eval("BrosureProizvodi") %>' />
                </td>
            </tr>
        </ItemTemplate>
        <LayoutTemplate>
            <table runat="server">
                <tr runat="server">
                    <td runat="server">
                        <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                            <tr runat="server" style="background-color:#DCDCDC;color: #000000;">
                                <th runat="server">BrosuraID</th>
                                <th runat="server">NazivBrosure</th>
                                <th runat="server">DatumPocetka</th>
                                <th runat="server">DatumIsteka</th>
                                <th runat="server">BrosureProizvodi</th>
                            </tr>
                            <tr id="itemPlaceholder" runat="server">
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server" style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;"></td>
                </tr>
            </table>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <tr style="background-color:#008A8C;font-weight: bold;color: #FFFFFF;">
                <td>
                    <asp:Label ID="BrosuraIDLabel" runat="server" Text='<%# Eval("BrosuraID") %>' />
                </td>
                <td>
                    <asp:Label ID="NazivBrosureLabel" runat="server" Text='<%# Eval("NazivBrosure") %>' />
                </td>
                <td>
                    <asp:Label ID="DatumPocetkaLabel" runat="server" Text='<%# Eval("DatumPocetka") %>' />
                </td>
                <td>
                    <asp:Label ID="DatumIstekaLabel" runat="server" Text='<%# Eval("DatumIsteka") %>' />
                </td>
                <td>
                    <asp:Label ID="BrosureProizvodiLabel" runat="server" Text='<%# Eval("BrosureProizvodi") %>' />
                </td>
            </tr>
        </SelectedItemTemplate>
    </asp:ListView>
   
    <asp:ObjectDataSource ID="odsLvBrosura" runat="server" SelectMethod="SelectAll" TypeName="eProdaja_Service.Data.DABrosure"></asp:ObjectDataSource>
   
    <asp:GridView ID="gvBrosure" runat="server" AutoGenerateColumns="False" DataSourceID="odsLvBrosura">
        <Columns>
            <asp:BoundField DataField="BrosuraID" HeaderText="BrosuraID" SortExpression="BrosuraID" />
            <asp:BoundField DataField="NazivBrosure" HeaderText="NazivBrosure" SortExpression="NazivBrosure" />
            <asp:BoundField DataField="DatumPocetka" HeaderText="DatumPocetka" SortExpression="DatumPocetka" />
            <asp:BoundField DataField="DatumIsteka" HeaderText="DatumIsteka" SortExpression="DatumIsteka" />
        </Columns>
    </asp:GridView>
    <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False" DataSourceID="odsLvBrosura" Height="50px" Width="125px">
        <Fields>
            <asp:BoundField DataField="BrosuraID" HeaderText="BrosuraID" SortExpression="BrosuraID" />
            <asp:BoundField DataField="NazivBrosure" HeaderText="NazivBrosure" SortExpression="NazivBrosure" />
            <asp:BoundField DataField="DatumPocetka" HeaderText="DatumPocetka" SortExpression="DatumPocetka" />
            <asp:BoundField DataField="DatumIsteka" HeaderText="DatumIsteka" SortExpression="DatumIsteka" />
        </Fields>
    </asp:DetailsView>
</asp:Content>
