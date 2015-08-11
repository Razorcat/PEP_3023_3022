using eProdaja_Service.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eProdaja_WebUI
{
    public partial class Pitanja : System.Web.UI.Page
    {

        public Kupci kupac
        {
            get { return (Kupci)Session["kupac"]; }
            set { Session["kupac"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindPitanja();
            }
        }
        void BindPitanja() {
            gvPitanja.DataSource = DAPitanjaOdgovori.GetPitanja();           
            gvPitanja.DataBind();
        }

        protected void lbNovoPitanje_Click(object sender, EventArgs e)
        {
            Response.Redirect("NovoPitanje.aspx");
        }
    }
}