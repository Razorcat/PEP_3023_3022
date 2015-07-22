using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using eProdaja_Service.Data;

namespace eProdaja_WebUI.Account
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterHyperLink.NavigateUrl = "Register";
            //OpenAuthLogin.ReturnUrl = Request.QueryString["ReturnUrl"];

            var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            if (!String.IsNullOrEmpty(returnUrl))
            {
                RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            }
        }

        protected void LoginBox_Authenticate(object sender, AuthenticateEventArgs e)
        {
            try
            {
                Kupci k = DAKupci.SelectByKorisnickoIme(LoginBox.UserName, LoginBox.Password);
                if (k == null)
                {
                    LoginBox.FailureText = "Korisnik sa unesenim korisničkim imenom nije pronađen ili je račun neaktivan.";
                    e.Authenticated = false;
                }
                else
                {
                    e.Authenticated = true;
                }

            }
            catch (Exception ex)
            {
                LoginBox.FailureText = ex.Message;
                e.Authenticated = false;
            }
        }
    }
}