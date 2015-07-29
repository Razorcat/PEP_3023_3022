using eProdaja_Service.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eProdaja_WebUI.Order
{
    public partial class MojeNarudzbe : System.Web.UI.Page
    {
        public Kupci kupac
        {
            get { return (Kupci)Session["kupac"]; }
            set { Session["kupac"] = value; }
        }
        protected List<esp_Narudzbe_SelectAktivneByKupacID_Result> mojeNarudzbe;

        protected void Page_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            if (kupac != null)
            {
                dgNarudzbe.DataSource = null;
                mojeNarudzbe = new List<esp_Narudzbe_SelectAktivneByKupacID_Result>();
                mojeNarudzbe = DANarudzbe.GetAktivneNarudzbeByKupacID(kupac.KupacID);
                dgNarudzbe.DataSource = mojeNarudzbe;
                dgNarudzbe.DataBind();
            }
        }

        protected void dgNarudzbe_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {

        }

        protected void dgNarudzbe_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            if (e.CommandName == "cmdOtkaziNarudzbu")
            {
                int narudzbaId = Convert.ToInt32(dgNarudzbe.DataKeys[e.Item.ItemIndex]);
                if (narudzbaId > 0)
                {
                    DANarudzbe.OtkaziNarudzbu(narudzbaId, true);
                    BindGrid();
                }
            }
        }
    }
}