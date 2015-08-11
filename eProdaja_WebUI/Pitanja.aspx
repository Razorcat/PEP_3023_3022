<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pitanja.aspx.cs" Inherits="eProdaja_WebUI.Pitanja" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
   
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

     <hgroup class="title">
        <h1><%: Title %></h1>
        <h2></h2>
    </hgroup>

    <article>
        <h4>Najčešća pitanja kupaca:</h4>

        <h6>Pitanje 1: Odabir odgovarajućeg parfema</h6>
        <p>     
                        
           Uvijek upoznajte miris prije nego ga kupite. Našpricajte malu količinu na kožu te ostavite neko vrijeme –
           ovako ćete znati sve faze razvijanja tog parfema te ćete moći odabrati onaj koji Vam najviše odgovara.
           U svakoj Avon brošuri naći ćete mirisne stranice, koje će Vam dati prvi dojam parfema. Većina parfema je dostupna 
           u malim testnim pakovanjima, tako da ukoliko neki miris želite bolje upoznati zamolite člana kluba da vam ga nabavi.
        </p>

        <h6>Pitanje 2: Da li za parfeme postoje uputstva za upotrebu? </h6>
        
        <p>Priroda parfema se najbolje otkriva kada ga nanesete na kožu na ona mjesta na kojima možete napipati puls – vrat, iza ušiju i zapešća.
         Ne koristite parfeme dok se sunčate, jer oni sadrže alkohol i u kombinaciji sa suncem mogu biti opasne. Dio pafrema je napravljen posebno 
         za ljeto i sadrži malu količinu alkohola – oni su sigurniji za korištenje ljeti.
         Ako želite da Vaš miris okružuje duže, koristite dezodorans, sprej za tijelo ili mirisni losion za tijelo u kombinaciji sa parfemom. 
         Predlažemo da kombinujete proizvode iz iste linije da biste izbjegli previše različitih mirisa istovremeno.</p>
    </article>
    <br />
   
    <asp:LinkButton ID="lbNovoPitanje" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Franklin Gothic Medium" Font-Size="Large" Width="600px" OnClick="lbNovoPitanje_Click">Novo pitanje</asp:LinkButton>
    
     <asp:GridView ID="gvPitanja" runat="server" AutoGenerateColumns="false" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" Width="600px">
         <AlternatingRowStyle BackColor="White" />
         <EditRowStyle BackColor="#2461BF" />
         <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
         <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
         <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
         <RowStyle BackColor="#EFF3FB" />
         <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
         <SortedAscendingCellStyle BackColor="#F5F7FB" />
         <SortedAscendingHeaderStyle BackColor="#6D95E1" />
         <SortedDescendingCellStyle BackColor="#E9EBEF" />
         <SortedDescendingHeaderStyle BackColor="#4870BE" />

         <Columns>
             <asp:BoundField DataField="Kupac" HeaderText="Kupac" />
             <asp:BoundField DataField="Pitanje" HeaderText="Pitanje" />
             <asp:BoundField DataField="Odgovor" HeaderText="Odgovor" />
             <asp:BoundField DataField="Administrator" HeaderText="Administrator" />
             <asp:BoundField DataField="Datum" HeaderText="Datum" />
        </Columns>

    </asp:GridView>
</asp:Content>
