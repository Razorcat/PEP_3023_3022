<%@ Page Title="Prijavite se" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="eProdaja_WebUI.Account.Login" %>
<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
    </hgroup>
    <section id="loginForm">
        <h2></h2>
         <asp:Login runat="server" ViewStateMode="Disabled" ID="LoginBox" DestinationPageUrl="~/Default.aspx" OnAuthenticate="LoginBox_Authenticate" RenderOuterTable="false">
            <LayoutTemplate>
                <p class="validation-summary-errors">
                    <asp:Literal runat="server" ID="FailureText" />

                </p>
                <fieldset>
                    <legend></legend>
                    <ol>
                        <li>
                            <asp:Label runat="server" AssociatedControlID="UserName">Korisničko ime</asp:Label>
                            <asp:TextBox runat="server" ID="UserName" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName" CssClass="field-validation-error" ErrorMessage="Korisničko ime je obavezno." />
                        </li>
                        <li>
                            <asp:Label runat="server" AssociatedControlID="Password">Lozinka</asp:Label>
                            <asp:TextBox runat="server" ID="Password" TextMode="Password" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" CssClass="field-validation-error" ErrorMessage="Lozinka je obavezna." />
                        </li>
                    </ol>
                    <asp:Button runat="server" ID="prijavaSubmit" Text="Prijavi se" CommandName="Login" />
                </fieldset>
            </LayoutTemplate>
        </asp:Login>
        <p>
            <asp:HyperLink runat="server" ID="RegisterHyperLink" ViewStateMode="Disabled">Registrujte se</asp:HyperLink>
            ako nemate račun.
        </p>
    </section>

    <%--<section id="socialLoginForm">
        <h2>Use another service to log in.</h2>
        <uc:OpenAuthProviders runat="server" ID="OpenAuthLogin" />
    </section>--%>
</asp:Content>
