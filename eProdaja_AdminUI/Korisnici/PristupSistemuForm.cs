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
    public partial class PristupSistemuForm : Form
    {
        public eProdaja_Service.Data.Korisnici korisnik { get; set; }
        public PristupSistemuForm(eProdaja_Service.Data.Korisnici k)
        {
            InitializeComponent();

            if (k != null)
            { 
                korisnik = k;
                ucitajPodatke();
            }
        }

        private void ucitajPodatke()
        {
            korisnickoImeInput.Text = korisnik.KorisnickoIme;
            aktivanCheck.Checked = korisnik.Status;

            korisnik.Uloge = DAKorisnici.SelectUloge(korisnik.KorisnikID);

            ((ListBox)ulogeList).DataSource = DAKorisnici.UlogeSelect();
            ((ListBox)ulogeList).DisplayMember = "Naziv";
            ulogeList.ClearSelected(); 

            for (int i = 0; i < ulogeList.Items.Count; i++)
            {
                if(korisnik.Uloge.Contains(ulogeList.Items[i]))
                    ulogeList.SetItemChecked(i, true);
            }
        }

        private void sacuvajButton_Click(object sender, EventArgs e)
        {
            string poruka = "";
            if (lozinkaInput.Text != "")
            {
                korisnik.LozinkaSalt = UIHelper.GenerateSalt();
                korisnik.LozinkaHash = UIHelper.GenerateHash(lozinkaInput.Text, korisnik.LozinkaSalt);
                DAKorisnici.ResetPassword(korisnik);
            }

            if (korisnik.KorisnikID == Global.prijavljeniKorisnik.KorisnikID)
                poruka += "\n" + Global.GetString("status_err");
            else if (korisnik.Status != aktivanCheck.Checked)
            {
                korisnik.Status = aktivanCheck.Checked;
                DAKorisnici.UpdateStatus(korisnik.KorisnikID, korisnik.Status);
            }

            
            DAKorisnici.UpdateUloge(korisnik.KorisnikID, ulogeList.CheckedItems.Cast<Uloge>().ToList());

            MessageBox.Show(poruka + "\n" + Global.GetString("update_succ"), "Promjene", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
