using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Membership.OpenAuth;


using eProdaja_Service.Data;
using eProdaja_Service.Util;

namespace eProdaja_WebUI.Account
{
    public partial class Register : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registracijaSubmit_Click(object sender, EventArgs e)
        {
            Kupci kupac = new Kupci();
            kupac.Ime = imeInput.Text.Trim();
            kupac.Prezime = prezimeInput.Text.Trim();
            kupac.KorisnickoIme = korisnickoImeInput.Text.Trim();
            kupac.Email = emailInput.Text;
            kupac.LozinkaSalt = UIHelper.GenerateSalt();
            kupac.LozinkaHash = UIHelper.GenerateHash(lozinkaInput.Text, kupac.LozinkaSalt);

            DAKupci.Insert(kupac);
        }

    }
}