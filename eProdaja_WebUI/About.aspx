<%@ Page Title="O nama" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"  CodeBehind="About.aspx.cs" Inherits="eProdaja_WebUI.About" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %></h1>
        <h2></h2>
    </hgroup>

    <article>
        <h4>Naša vizija</h4>
        <p>                 
            Avon je kompanija koja zadovoljava potrebe žena širom svijeta kroz kvalitet svojih proizvoda, 
            profesionalnost usluge i mogućnost poslovne afirmacije.
        </p>

        <h4>Kupovina proizvoda</h4>
        <p>        
           Naša brošura je naša prodavaonica! Brošura izlazi svake 3 sedmice.
           U brošuri ćete uvijek pronaći moderne proizvode visoke kvalitete, po povoljnim cijenama. 
           Svaka brošura donosi nove neodoljive ponude i najnovije proizvode.
           Avon Članovi Kluba predaju narudžbu putem interneta, a Avon je dostavlja direktno na željenu adresu.
        </p>

        <p>        
            Avon teži savršenstvu. Svaki proizvod s Avonovim potpisom izrađen je po najvišim standardima sigurnosti i cjelovitosti.
            Avonove proizvode upotrebljavaju milioni žena diljem svijeta, što je dokaz kvalitete i zadovoljstva Avonovim proizvodima.
            Avon je jedina kozmetička kompanija koja pruža 100% povrat novca. Takva garancija vrijedi od samog početka rada kompanije 
            prije 128 godina.Avon je među najvećim svjetskim i domaćim kompanijama u direktnoj prodaji kozmetike i srodnih proizvoda.
        </p>
    </article>

    <%--<aside>
        <h3>Aside Title</h3>
        <p>        
            Use this area to provide additional information.
        </p>
        <ul>
            <li><a runat="server" href="~/">Home</a></li>
            <li><a runat="server" href="~/About">About</a></li>
            <li><a runat="server" href="~/Contact">Contact</a></li>
        </ul>
    </aside>--%>
</asp:Content>