<%@ Page Title="Pitanja" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"  CodeBehind="Questions.aspx.cs" Inherits="eProdaja_WebUI.About" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
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
    
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>