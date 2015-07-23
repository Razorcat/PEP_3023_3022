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
    public partial class NoviDobavljacForm : Form
    {
        public NoviDobavljacForm()
        {
            this.AutoValidate = AutoValidate.Disable;
            InitializeComponent();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                Dobavljaci dobavljac = new Dobavljaci();

                dobavljac.Adresa = txtbAdresa.Text;
                dobavljac.Email = txtbEmail.Text.Trim();
                dobavljac.Fax = mtxtbFax.Text;
                dobavljac.KontaktOsoba = txtbKontaktOsoba.Text;
                dobavljac.Napomena = txtbNapomena.Text;
                dobavljac.Naziv = txtbNaziv.Text;
                dobavljac.Telefon = mtxtbTelefon.Text;
                dobavljac.Web = txtbWeb.Text;
                dobavljac.ZiroRacuni = txtbZiroRacun.Text;
                dobavljac.Status = true;

                try
                {
                    DADobavljaci.InsertDobavljaca(dobavljac);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Global.GetString(ex.Message), "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Uspješno ste dodali novog dobavljača!", "Unos novog dobavljača", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OcistiPolja();
            }
        }

        private void OcistiPolja()
        {
            txtbAdresa.Text="";
            txtbEmail.Text = "";
            mtxtbFax.Text = "";
            txtbKontaktOsoba.Text = "";
            txtbNapomena.Text = "";
            txtbNaziv.Text = "";
            mtxtbTelefon.Text = "";
            txtbWeb.Text = "";
            txtbZiroRacun.Text = "";
        }

        private void txtbNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (txtbNaziv.Text.Trim() == "") {
                e.Cancel = true;
                errorProvider.SetError(txtbNaziv, "Naziv dobavljača ne može biti prazno polje!");
            }
        }

        private void txtbAdresa_Validating(object sender, CancelEventArgs e)
        {
            if (txtbAdresa.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider.SetError(txtbAdresa, "Adresa dobavljača ne može biti prazno polje!");
            }
        }

        private void mtxtbTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (mtxtbTelefon.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider.SetError(mtxtbTelefon, "Telefon dobavljača ne može biti prazno polje!");
            }
        }
    
    }
}
