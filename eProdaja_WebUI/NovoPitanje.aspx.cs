using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using eProdaja_Service.Data;

namespace eProdaja_WebUI
{
    public partial class NovoPitanje : System.Web.UI.Page
    {

        public Kupci kupac
        {
            get { return (Kupci)Session["kupac"]; }
            set { Session["kupac"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSpremi_Click(object sender, EventArgs e)
        {
            if (kupac != null)
            {
                DAPitanjaOdgovori.InsertPitanje(kupac.KupacID, txtbPitanje.Text);
                Response.Redirect("Pitanja.aspx");
            }
        }
    }
}