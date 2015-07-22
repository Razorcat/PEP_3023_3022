using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

using eProdaja_Service.Data;

namespace eProdaja_WebUI
{
    public partial class SiteMaster : MasterPage
    {
        Narudzbe narudzba
        {
            set { Session["narudzba"] = value; }
            get { return (Narudzbe)Session["narudzba"]; }

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (narudzba != null)
                cartLink.Text = string.Format("My Cart ({0})", narudzba.NarudzbaStavke.Count);
        }
    }
}