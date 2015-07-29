using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using eProdaja_Service.Data;
using eProdaja_Service.Util;

namespace eProdaja_WebUI
{
    public partial class _Default : Page
    {
        protected List<esp_Proizvodi_SelectByVrstaNaziv_Result> proizvodi;
        public Preporuka preporuka;
        public List<Proizvodi> pList;

        private Narudzbe narudzba {
            get { return (Narudzbe)Session["narudzba"]; }
            set { Session["narudzba"] = value; }
        }

        private decimal iznosRacuna
        {
            get { return (decimal)Session["iznos"]; }
            set { Session["iznos"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindVrste();
                BindGrid();                            
            }
        }

        private void BindGrid()
        {
            int vrstaId=0;
            if(vrsteList.SelectedIndex > 0)
                vrstaId = Convert.ToInt32(vrsteList.SelectedValue);

            int offset = proizvodiGrid.PageIndex * proizvodiGrid.PageSize;
            proizvodi = DAProizvodi.SelectByVrstaNaziv(vrstaId, nazivInput.Text.Trim(), offset, proizvodiGrid.PageSize);
            proizvodiGrid.VirtualItemCount = DAProizvodi.TotalRows;

            proizvodiGrid.DataBind();
        }

        private void BindVrste()
        {
            vrsteList.DataTextField = "Naziv";
            vrsteList.DataValueField = "VrstaID";
            vrsteList.DataSource = DAProizvodi.VrsteSelect();
            vrsteList.DataBind();
           
        }

        protected void proizvodiGrid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            proizvodiGrid.PageIndex = e.NewPageIndex;
            BindGrid();
        }

        protected void vrsteList_SelectedIndexChanged(object sender, EventArgs e)
        {
            proizvodiGrid.PageIndex = 0;
            BindGrid();
        }

        protected void nazivInput_TextChanged(object sender, EventArgs e)
        {
            proizvodiGrid.PageIndex = 0;
            BindGrid();
        }

        protected void proizvodiGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
            if (e.CommandName == "AddCommand")
            {
                int proizvodId = Convert.ToInt32(e.CommandArgument);
                TextBox kolicinaInput = (TextBox)((GridViewRow)((LinkButton)e.CommandSource).NamingContainer).FindControl("kolicinaInput");
                int kolicina = Convert.ToInt32(kolicinaInput.Text);


                if (narudzba == null)
                {
                    narudzba = new Narudzbe();

                    //Broj narudžbe generisati na osnovu godine i aktivnog broja narudžbi
                    //Format broja rbr-godina
                    string maxBr = DANarudzbe.GetMaxBrojNarudzbe();
                    int rbr = Convert.ToInt32(maxBr.Split('-')[0]) + 1;
                    narudzba.BrojNarudzbe = rbr + "-" + DateTime.Now.Year;

                    narudzba.Datum = DateTime.Now;
                    narudzba.Otkazano = false;
                    narudzba.Status = true;

                    iznosRacuna = 0;
                }

                //Provjeriti da li stavka već postoji i povećati samo količinu
                foreach (NarudzbaStavke s in narudzba.NarudzbaStavke)
                {
                    if (s.ProizvodID == proizvodId)
                    {
                        iznosRacuna += s.Proizvodi.Cijena * kolicina;
                        s.Kolicina += kolicina;
                        BindPreporuka(proizvodId);
                        return;
                    }
                }

                NarudzbaStavke stavka = new NarudzbaStavke();
                stavka.ProizvodID = proizvodId;
                stavka.Kolicina = kolicina;
                stavka.Proizvodi = DAProizvodi.SelectById(proizvodId);

                narudzba.NarudzbaStavke.Add(stavka);

                iznosRacuna += kolicina * stavka.Proizvodi.Cijena;

                HyperLink link = (HyperLink)this.Master.FindControl("cartLink");
                link.Text = string.Format("My Cart({0})", narudzba.NarudzbaStavke.Count);

                BindPreporuka(proizvodId);

            }
        }

        protected void traziButton_Click(object sender, EventArgs e)
        {
            //proizvodiGrid.PageIndex = 0;
            //BindGrid();
        }     


        /////////////////////preporuka

        private void BindPreporuka(int ProizvodID)
        {
            preporuka = new Preporuka();
            pList = preporuka.GetSlicneProizvode(ProizvodID);
            if (pList.Count > 0)
            {
                gdPreporuka.DataSource = pList;
                gdPreporuka.DataBind();
            }
        }      

        protected void dgProizvodi_ItemCommandPreporuka(object source, DataGridCommandEventArgs e)
        {
            if (e.CommandName == "DodajUKopruCmd")
            {
                int proizvodId = Convert.ToInt32(gdPreporuka.DataKeys[e.Item.ItemIndex]);
                TextBox kolicinaInput = (TextBox)e.Item.FindControl("txtbKolicina");
                int kolicina = Convert.ToInt32(kolicinaInput.Text);

                if (narudzba == null)
                {
                    narudzba = new Narudzbe();

                    //Broj narudžbe generisati na osnovu godine i aktivnog broja narudžbi
                    //Format broja rbr-godina
                    string maxBr = DANarudzbe.GetMaxBrojNarudzbe();
                    int rbr = Convert.ToInt32(maxBr.Split('-')[0]) + 1;
                    narudzba.BrojNarudzbe = rbr + "-" + DateTime.Now.Year;

                    narudzba.Datum = DateTime.Now;
                    narudzba.Otkazano = false;
                    narudzba.Status = true;

                    iznosRacuna = 0;
                }

                //Provjeriti da li stavka već postoji i povećati samo količinu
                foreach (NarudzbaStavke s in narudzba.NarudzbaStavke)
                {
                    if (s.ProizvodID == proizvodId)
                    {
                        iznosRacuna += s.Proizvodi.Cijena * kolicina;
                        s.Kolicina += kolicina;                       
                        return;
                    }
                }

                NarudzbaStavke stavka = new NarudzbaStavke();
                stavka.ProizvodID = proizvodId;
                stavka.Kolicina = kolicina;
                stavka.Proizvodi = DAProizvodi.SelectById(proizvodId);

                narudzba.NarudzbaStavke.Add(stavka);

                iznosRacuna += kolicina * stavka.Proizvodi.Cijena;

                HyperLink link = (HyperLink)this.Master.FindControl("cartLink");
                link.Text = string.Format("My Cart({0})", narudzba.NarudzbaStavke.Count);
                
            }
        }

        protected void gvBrosure_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "brosuraCommand")
            {
                int brosuraId = Convert.ToInt32(e.CommandArgument);
                BindBP(brosuraId);
            }
        }
        void BindBP(int id) {
            DataGridBP.DataSource = DABrosure.GetBrosureProizvodi(id);
            DataGridBP.DataBind();
        }
    }
}