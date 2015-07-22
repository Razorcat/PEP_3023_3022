<%@ Page Title="Registracija" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="eProdaja_WebUI.Account.Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %></h1>
        <h2></h2>
    </hgroup>

    <fieldset>
        <legend></legend>
        <ol>
            <li>
                <asp:Label ID="Label1" runat="server" AssociatedControlID="imeInput">Ime</asp:Label>
                <asp:TextBox runat="server" ID="imeInput" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="imeInput"
                    CssClass="field-validation-error" ErrorMessage="Ime je obavezno." />
            </li>
            <li>
                <asp:Label ID="Label2" runat="server" AssociatedControlID="prezimeInput">Prezime</asp:Label>
                <asp:TextBox runat="server" ID="prezimeInput" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="prezimeInput"
                    CssClass="field-validation-error" ErrorMessage="Prezime je obavezno." />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="korisnickoImeInput">Korisničko ime</asp:Label>
                <asp:TextBox runat="server" ID="korisnickoImeInput" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="korisnickoImeInput"
                    CssClass="field-validation-error" ErrorMessage="Korisničko ime je obavezno." />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="emailInput">Email</asp:Label>
                <asp:TextBox runat="server" ID="emailInput" TextMode="Email" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="emailInput"
                    CssClass="field-validation-error" ErrorMessage="E-mail adresa je obavezna." />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="lozinkaInput">Lozinka</asp:Label>
                <asp:TextBox runat="server" ID="lozinkaInput" TextMode="Password" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="lozinkaInput"
                    CssClass="field-validation-error" ErrorMessage="Lozinka je obavezna." />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="potvrdaLozinkeInput">Potvrda lozinke</asp:Label>
                <asp:TextBox runat="server" ID="potvrdaLozinkeInput" TextMode="Password" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="potvrdaLozinkeInput"
                    CssClass="field-validation-error" Display="Dynamic" ErrorMessage="Potvrda lozinke je obavezna." />
                <asp:CompareValidator runat="server" ControlToCompare="lozinkaInput" ControlToValidate="potvrdaLozinkeInput"
                    CssClass="field-validation-error" Display="Dynamic" ErrorMessage="Neispravna potvrda lozinke." />
            </li>
        </ol>
        <asp:Button runat="server" ID="registracijaSubmit" Text="Registruj se" OnClick="registracijaSubmit_Click" />
    </fieldset>
</asp:Content>
