<%@ Page Title="Kontakt" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="eProdaja_WebUI.Contact" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %></h1>
        <h2></h2>
    </hgroup>

    <section class="contact">
        <header>
            <h3>Telefon:</h3>
        </header>
        <p>
            <%--<span class="label">Main:</span>--%>
            <span>033/ 55 66 55</span>
        </p>
         <%--<h3>Fax:</h3>--%>
        <p>
            
            <span>033/ 29 65 91</span>
        </p>
    </section>

    <section class="contact">
        <header>
            <h3>Email:</h3>
        </header>
        <p>
            <span class="label">Podrška:</span>
            <span><a href="mailto:Podrska@avon.com">podrska@avon.com</a></span>
        </p>
        <p>
            <span class="label">Marketing:</span>
            <span><a href="mailto:marketing@avon.com">marketing@avon.com</a></span>
        </p>
        
    </section>

    <section class="contact">
        <header>
            <h3>Adresa:</h3>
        </header>
        <p>
            Džemala Bijedića 25, <br />
            Sarajevo
        </p>
    </section>
</asp:Content>