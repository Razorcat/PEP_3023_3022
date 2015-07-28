using eProdaja_Service.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eProdaja_AdminUI.Narudzbe
{
    public partial class ProdajaForm : Form
    {
        List<esp_ProizvodiSkladiste_SelectByNazivSifra_Result> psList=new List<esp_ProizvodiSkladiste_SelectByNazivSifra_Result>();
        List<IzlazStavke> izlazStavke = new List<IzlazStavke>();
        decimal iznos = 0;
        decimal iznosPDV = 0;
        int proizvodID = 0;
        int dostupno;
        int skladisteId = 0;
        bool dgPrKlik = false;
        bool dgPKlik = false;        

        public ProdajaForm(List<NarudzbaStavke> ns)
        {
            InitializeComponent();
            BindGridProizvodi();
            BindSkladista();
            txtbBrRacuna.Text = GenerirajRacun(DAProdaja.GetZadnjiRacun());
            if (ns != null)
                foreach (NarudzbaStavke n in ns)
                {
                    IzlazStavke iStavka = new IzlazStavke();
                    iStavka.Proizvodi = n.Proizvodi;
                    iStavka.ProizvodID = n.ProizvodID;
                    iStavka.Cijena = n.Proizvodi.Cijena; // Math.Round(Convert.ToDecimal(mtxtbCijena.Text) * (1 - ntxtbPopust.Value / 100), 2);
                    iStavka.Popust = 0; // Math.Round(Convert.ToDecimal(mtxtbCijena.Text) * (ntxtbPopust.Value / 100), 2);
                    iStavka.Kolicina = n.Kolicina; //narudzbe stavke.kolicina;

                    iznos += iStavka.Cijena * iStavka.Kolicina;
                    iznosPDV = iznos * (decimal)1.17;
                    izlazStavke.Add(iStavka);

                    txtbIznosBezPDV.Text = Math.Round(iznos, 2).ToString() + " KM";
                    txtbIznosSaPDV.Text = Math.Round(iznosPDV, 2).ToString() + " KM";

                    BindGridProdaja();
                }
        }

        private void BindSkladista()
        {
            cmbSkladisteList.DataSource = DASkladista.SelectAll();
            cmbSkladisteList.DisplayMember = "Naziv";
            cmbSkladisteList.ValueMember = "SkladisteID";
        }

        private void BindGridProizvodi()
        {
            psList = new List<esp_ProizvodiSkladiste_SelectByNazivSifra_Result>();
            psList = DAProizvodi.SelectByNazivSifra(txtbNaziv.Text, txtbSifra.Text);
            dgvProizvodi.DataSource = psList;
            dgvProizvodi.Columns[0].Visible = false;           
            dgvProizvodi.ClearSelection();
        }
         private void BindGridProizvodiKolicina(){
            dgvProizvodi.DataSource=null;
            dgvProizvodi.DataSource = psList;
            dgvProizvodi.Columns[0].Visible = false;
            dgvProizvodi.ClearSelection();
        }

        private void txtbSifra_TextChanged(object sender, EventArgs e)
        {
            BindGridProizvodi();           
        }

        private void txtbNaziv_TextChanged(object sender, EventArgs e)
        {
            BindGridProizvodi();
        }

        private void btnDodajP_Click(object sender, EventArgs e)
        {
            if (mtxtbCijena.MaskFull && dgPrKlik == true)
            {
                Proizvodi proizvod = new Proizvodi();
                IzlazStavke iStavka = new IzlazStavke();
                if (DAProizvodi.SelectById(proizvodID) != null)
                {
                    proizvod = DAProizvodi.SelectById(proizvodID);
                    if (ntxtbKolicina.Value <= dostupno)
                    {
                        iStavka.Proizvodi = proizvod;
                        iStavka.ProizvodID = proizvod.ProizvodID;
                        iStavka.Cijena = Math.Round(Convert.ToDecimal(mtxtbCijena.Text) * (1 - ntxtbPopust.Value / 100), 2);
                        iStavka.Popust = Math.Round(Convert.ToDecimal(mtxtbCijena.Text) * (ntxtbPopust.Value / 100), 2);
                        iStavka.Kolicina = Convert.ToInt32(ntxtbKolicina.Value);

                        iznos += iStavka.Cijena * iStavka.Kolicina;
                        iznosPDV = iznos * (decimal)1.17;

                        izlazStavke.Add(iStavka);

                        BindGridProdaja();

                        txtbIznosBezPDV.Text = Math.Round(iznos, 2).ToString() + " KM";
                        txtbIznosSaPDV.Text = Math.Round(iznosPDV, 2).ToString() + " KM";

                        dostupno -= Convert.ToInt32(ntxtbKolicina.Value);
                        psList[dgvProizvodi.CurrentCell.RowIndex].Kolicina = dostupno;
                        
                        BindGridProizvodiKolicina();
                        dgPrKlik = false;
                    }
                }
            }
        }

        private void BindGridProdaja()
        {
            dgvProdaja.DataSource = null;
            dgvProdaja.DataSource = izlazStavke;
            dgvProdaja.Columns[0].Visible = false;
            dgvProdaja.Columns[1].Visible = false;
            dgvProdaja.Columns[2].Visible = false;
            dgvProdaja.Columns[6].Visible = false;
            dgvProdaja.ClearSelection();
        }

        private void dgvProizvodi_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            proizvodID = Convert.ToInt32(dgvProizvodi.SelectedRows[0].Cells[0].Value);            
            dostupno = (int)psList[dgvProizvodi.CurrentCell.RowIndex].Kolicina;
            dgPrKlik = true;
        }

        private void btnBrisiStavku_Click(object sender, EventArgs e)
        {
            if (izlazStavke.Count > 0 && dgPKlik==true)
            {
                iznos -= izlazStavke[dgvProdaja.CurrentCell.RowIndex].Cijena * izlazStavke[dgvProdaja.CurrentCell.RowIndex].Kolicina;

                foreach (esp_ProizvodiSkladiste_SelectByNazivSifra_Result PS in psList)
                    if (PS.ProizvodID == izlazStavke[dgvProdaja.CurrentCell.RowIndex].ProizvodID)                 
                        psList[dgvProdaja.CurrentCell.RowIndex].Kolicina += izlazStavke[dgvProdaja.CurrentCell.RowIndex].Kolicina;
                
                izlazStavke.RemoveAt(dgvProdaja.CurrentCell.RowIndex);
                iznosPDV = iznos * (decimal)1.17;
                BindGridProdaja();
                txtbIznosBezPDV.Text = Math.Round(iznos, 2).ToString() + " KM";
                txtbIznosSaPDV.Text = Math.Round(iznosPDV, 2).ToString() + " KM";
                BindGridProizvodiKolicina();
                dgPKlik = false;
            }
        }

        private void cmbSkladisteList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSkladisteList.SelectedIndex != 0)
                skladisteId = Convert.ToInt32(cmbSkladisteList.SelectedValue);
        }

        private void btnZakljuciProdaju_Click(object sender, EventArgs e)
        {
            if (skladisteId > 0 && txtbBrRacuna.Text != "")
            {
                Izlazi izlaz = new Izlazi();
                izlaz.BrojRacuna = txtbBrRacuna.Text;
                izlaz.KorisnikID = Global.prijavljeniKorisnik.KorisnikID;
                izlaz.Korisnici = Global.prijavljeniKorisnik;
                izlaz.Zakljucen = false;
                izlaz.IznosBezPDV = iznos;
                izlaz.IznosSaPDV = iznosPDV;
                izlaz.SkladisteID = skladisteId;
                //insert izlaz u bazu
                //insert zlaz stavka                

                int IzlazId = DAProdaja.InsertProdaju(izlaz, izlazStavke);               

                MessageBox.Show("Uspješno ste zaključili prodaju", "Prodaja info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                // report za račun                
                if (IzlazId > 0)
                {
                    Izvjestaji.RacunForm rpt = new Izvjestaji.RacunForm(IzlazId);
                    rpt.Show();
                    rpt.WindowState = FormWindowState.Normal;
                }
                 
            }
            else MessageBox.Show("Imate prazna polja", "Prodaja info", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public string GenerirajRacun(string ZadnjiRacun)
        {            
            if (string.IsNullOrEmpty(ZadnjiRacun))
            {
                ZadnjiRacun = "RACUN_0000000001";
            }
            string nextId = string.Empty;
            int len = ZadnjiRacun.Length;
            string splitNo = ZadnjiRacun.Substring(6, len - 6);
            int num = Convert.ToInt32(splitNo);
            num++;
            nextId = ZadnjiRacun.Substring(0, 6) + num.ToString("0000000000");
            return nextId;            
        }

        private void dgvProdaja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgPKlik = true;           
        }

    }
}
