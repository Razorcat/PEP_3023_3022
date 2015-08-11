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
using eProdaja_Service.Util;

namespace eProdaja_AdminUI.Korisnici
{
    public partial class NoviKorisnikForm : Form
    {
        public eProdaja_Service.Data.Korisnici korisnikIzmjene { get; set; }

        public NoviKorisnikForm(eProdaja_Service.Data.Korisnici k)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

            if (k != null)
            {
                korisnikIzmjene = k;
                ucitajPodatke();
            }
        }

        private void ucitajPodatke()
        {
            dodajButton.Location = new Point(dodajButton.Location.X, dodajButton.Location.Y - pristupPanel.Height);
            this.Height -= pristupPanel.Height;
            dodajButton.Text = "Sačuvaj";
            this.Text = "Izmjene korisnika";
            pristupPanel.Visible = false;
            imeInput.Text = korisnikIzmjene.Ime;
            prezimeInput.Text = korisnikIzmjene.Prezime;
            emailInput.Text = korisnikIzmjene.Email;
            telefonInput.Text = korisnikIzmjene.Telefon;

            korisnickoImeInput.Text = korisnikIzmjene.KorisnickoIme;
           
        }

        private void NoviKorisnikForm_Load(object sender, EventArgs e)
        {
            ((ListBox)ulogeList).DataSource = DAKorisnici.UlogeSelect();
            ((ListBox)ulogeList).DisplayMember = "Naziv";
            ulogeList.ClearSelected();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                eProdaja_Service.Data.Korisnici korisnik = new eProdaja_Service.Data.Korisnici();

               
                if (korisnikIzmjene != null)
                    korisnik.KorisnikID = korisnikIzmjene.KorisnikID;

                korisnik.Ime = imeInput.Text.Trim();
                korisnik.Prezime = prezimeInput.Text.Trim();
                korisnik.Email = emailInput.Text.Trim();
                korisnik.Telefon = telefonInput.Text.Trim();

                
                if (korisnik.KorisnikID > 0)
                {
                    DAKorisnici.Update(korisnik);
                    MessageBox.Show(Global.GetString("update_succ"), "Izmjene korisničkih podataka",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }


                korisnik.KorisnickoIme = korisnickoImeInput.Text;
                korisnik.LozinkaSalt = UIHelper.GenerateSalt();
                korisnik.LozinkaHash = UIHelper.GenerateHash(lozinkaInput.Text, korisnik.LozinkaSalt);

                korisnik.Uloge = ulogeList.CheckedItems.Cast<Uloge>().ToList();

                try
                {
                    DAKorisnici.Insert(korisnik);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Global.GetString(ex.Message), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Omogućiti dodavanje novog korisnika prije zatvaranja forme
                if (MessageBox.Show(Global.GetString("user_succ") + "\n" + Global.GetString("user_add_q"), "Korisnik",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    clear();
                else
                    this.Close();
            }
        }

        private void clear()
        {
            imeInput.Text = "";
            prezimeInput.Text = "";
            emailInput.Text = "";
            telefonInput.Text = "";
            korisnickoImeInput.Text = "";
            lozinkaInput.Text = "";

            ulogeList.ClearSelected(); 
            foreach (int item in ulogeList.CheckedIndices)
            {
              
                ulogeList.SetItemCheckState(item, CheckState.Unchecked);
            }
        }

        #region Validacija
        private void imeInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(imeInput.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(imeInput, Global.GetString("name_req"));
            }
            else
                errorProvider.SetError(imeInput, "");
        }

        private void prezimeInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(prezimeInput.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(prezimeInput, Global.GetString("lname_req"));
            }
            else
                errorProvider.SetError(prezimeInput, "");
        }

        private void emailInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(emailInput.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(emailInput, Global.GetString("email_req"));
            }
            else
            {
                try
                {
                    System.Net.Mail.MailAddress mail = new System.Net.Mail.MailAddress(emailInput.Text.Trim());
                    errorProvider.SetError(emailInput, "");
                }
                catch (FormatException)
                {
                    e.Cancel = true;
                    errorProvider.SetError(emailInput, Global.GetString("email_err"));
                }
            }
        }

        private void korisnickoImeInput_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(korisnickoImeInput.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(korisnickoImeInput, Global.GetString("username_req"));
            }
            else if (korisnickoImeInput.Text.Length < 3)
            {
                e.Cancel = true;
                errorProvider.SetError(korisnickoImeInput, Global.GetString("username_err"));
            }
            else
                errorProvider.SetError(korisnickoImeInput, "");
        }

        private void lozinkaInput_Validating(object sender, CancelEventArgs e)
        {
            if (korisnikIzmjene == null)
            {
                if (String.IsNullOrEmpty(lozinkaInput.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider.SetError(lozinkaInput, Global.GetString("pass_req"));
                }
                else if (lozinkaInput.Text.Length < 4)
                {
                    e.Cancel = true;
                    errorProvider.SetError(lozinkaInput, Global.GetString("pass_err"));
                }
                else
                    errorProvider.SetError(lozinkaInput, "");
            }
        }

        private void ulogeList_Validating(object sender, CancelEventArgs e)
        {
            if (ulogeList.CheckedItems.Count == 0 && korisnikIzmjene==null)
            {
                e.Cancel = true;
                errorProvider.SetError(ulogeList, Global.GetString("roles_req"));
            }
            else
                errorProvider.SetError(ulogeList, "");
        }

        #endregion

    }
}
