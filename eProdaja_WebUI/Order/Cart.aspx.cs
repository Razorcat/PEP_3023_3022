using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using eProdaja_Service.Data;

namespace eProdaja_WebUI.Order
{
    public partial class Cart : System.Web.UI.Page
    {
        private Narudzbe narudzba
        {
            set { Session["narudzba"] = value; }
            get { return (Narudzbe)Session["narudzba"]; }

        }

        private decimal iznosRacuna
        {
            set { Session["iznos"] = value; }
            get { return (decimal)Session["iznos"]; }

        }
        public Kupci kupac
        {
            get { return (Kupci)Session["kupac"]; }
            set { Session["kupac"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        private void BindGrid()
        {
            if (narudzba != null)
            {
                narudzbaGrid.DataSource = narudzba.NarudzbaStavke;
                narudzbaGrid.DataBind();
                iznosLabel.Text = Math.Round(iznosRacuna, 2).ToString() + " KM";
            }
        }

        protected void zakljuciNarudzbuSubmit_Click(object sender, EventArgs e)
        {
            DANarudzbe.Insert(narudzba, User.Identity.Name);
            narudzba = null;
            iznosRacuna = 0;
            narudzbaGrid.DataBind();
            iznosLabel.Text = "0 KM";

            HyperLink cartLink = (HyperLink)this.Master.FindControl("cartLink");
            cartLink.Text = "My Cart";
        }
    }
}