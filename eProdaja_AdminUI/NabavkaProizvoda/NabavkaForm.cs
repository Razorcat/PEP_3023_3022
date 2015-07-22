using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using eProdaja_Service.Data;

namespace eProdaja_AdminUI.NabavkaProizvoda
{
    public partial class NabavkaForm : Form
    {
        private Dobavljaci dobavljac;
        private List<UlazStavke> stavke = new List<UlazStavke>();
        private decimal iznos = 0;
        private decimal pdv = 0;

        public NabavkaForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void NabavkaForm_Load(object sender, EventArgs e)
        {
            BindSkladista();
        }

        private void pretragaDButton_Click(object sender, EventArgs e)
        {
            DobavljaciForm form = new DobavljaciForm();
            form.ShowDialog();

            if (form.dobavljac != null)
            {
                dobavljac = form.dobavljac;
                nazivDInput.Text = dobavljac.Naziv;
                kontaktDInput.Text = dobavljac.KontaktOsoba;
                telefonDInput.Text = dobavljac.Telefon;
            }
        }

        private void BindSkladista()
        {
            skladisteList.DataSource = DASkladista.SelectAll();
            skladisteList.DisplayMember = "Naziv";
            skladisteList.ValueMember = "SkladisteID";
        }

        private void dodajStavkuButton_Click(object sender, EventArgs e)
        {
            
            DodajStavku();
            BindGrid();
        }

        private void DodajStavku()
        {
            try
            {
                UlazStavke s = new UlazStavke();
                s.ProizvodID = DAProizvodi.SelectBySifraNaziv(sifraPInput.Text, "")[0].ProizvodID;               
                s.Proizvodi = DAProizvodi.SelectById(s.ProizvodID);
                s.Kolicina = Convert.ToInt32(kolicinaInput.Text);
                s.Cijena = Convert.ToDecimal(cijenaInput.Text);
                stavke.Add(s);
                iznos += s.Kolicina * s.Cijena;
                
                pdv = (decimal)0.17 * iznos;
               
                iznosRacunaInput.Text = Math.Round(iznos + pdv, 2).ToString();
                pdvInput.Text = Math.Round(pdv, 2).ToString();

                sifraPInput.Text = "";
                kolicinaInput.Text = "000";
                cijenaInput.Text = "000000";
                sifraPInput.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindGrid()
        {
            stavkeGrid.ClearSelection();
            stavkeGrid.AutoGenerateColumns = false;
            stavkeGrid.DataSource = null;
            stavkeGrid.DataSource = stavke;
            stavkeGrid.ClearSelection();
        }

        private void zakljuciButton_Click(object sender, EventArgs e)
        {
            try
            {
                Ulazi ulaz = new Ulazi();
                ulaz.DobavljacID = dobavljac.DobavljacID;
                ulaz.KorisnikID = Global.prijavljeniKorisnik.KorisnikID;
                if (skladisteList.SelectedIndex != 0)
                    ulaz.SkladisteID = Convert.ToInt32(skladisteList.SelectedValue);
                ulaz.BrojFakture = brojFaktureInput.Text;
                ulaz.Datum = datumDatePicker.Value;
                ulaz.Napomena = napomenaInput.Text;
                ulaz.IznosRacuna = iznos + pdv;
                ulaz.PDV = pdv;

                DAProizvodi.InsertNabavka(ulaz, stavke);
                MessageBox.Show(Global.GetString("ulaz_succ"), "Nabavka robe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cijenaInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                DodajStavku();
                BindGrid();
            }
        }

  
    }
}
