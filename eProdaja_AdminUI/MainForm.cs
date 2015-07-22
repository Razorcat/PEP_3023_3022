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

namespace eProdaja_AdminUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void noviKorisnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Korisnici.NoviKorisnikForm form = new Korisnici.NoviKorisnikForm(null);
            form.MdiParent = this;
            form.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            korisnikLabel.Text = Global.prijavljeniKorisnik.Ime + " " + Global.prijavljeniKorisnik.Prezime;
            int noveNarudzbe = DANarudzbe.CountAktivne();            

            if (noveNarudzbe > 0)
            {
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(4000, "Nove narudžbe", "Broj narudžbi: " + noveNarudzbe, ToolTipIcon.Info);
            }
        }

        private void administracijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Korisnici.PretragaForm form = new Korisnici.PretragaForm();
            form.MdiParent = this;
            form.Show();
        }

        private void noviProizvodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            NabavkaProizvoda.NoviProizvodForm noviProizvodForm = new NabavkaProizvoda.NoviProizvodForm();
            noviProizvodForm.MdiParent = this;
            noviProizvodForm.Show();
        }

        private void pretragaPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            NabavkaProizvoda.ProizvodiForm pretragaForm = new NabavkaProizvoda.ProizvodiForm();
            pretragaForm.MdiParent = this;
            pretragaForm.Show();
        }

        private void nabavkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            NabavkaProizvoda.NabavkaForm nabavkaForm = new NabavkaProizvoda.NabavkaForm();
            nabavkaForm.MdiParent = this;
            nabavkaForm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            NabavkaProizvoda.StanjeSkladistaForm skladisteForm = new NabavkaProizvoda.StanjeSkladistaForm();
            skladisteForm.MdiParent = this;
            skladisteForm.Show();
        }

        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Narudzbe.AktivneNarudzbeForm aktivneForm = new Narudzbe.AktivneNarudzbeForm();
            aktivneForm.MdiParent = this;
            aktivneForm.Show();
        }

        private void prodajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Izvjestaji.ProdajaForm prodajaForm = new Izvjestaji.ProdajaForm();
            prodajaForm.WindowState = FormWindowState.Maximized;
            prodajaForm.MdiParent = this;
            prodajaForm.Show();
        }

        private void brošureToolStripMenuItem_Click(object sender, EventArgs e)
        {
           


        }

        private void brošureToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            NabavkaProizvoda.PrikazBrosuraForm form = new NabavkaProizvoda.PrikazBrosuraForm();
            form.MdiParent = this;
            form.Show();
        }

        private void prikazBrošuraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            NabavkaProizvoda.PrikazBrosuraForm form = new NabavkaProizvoda.PrikazBrosuraForm();
            form.MdiParent = this;
            form.Show();
        }

        private void dodajProizvodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            NabavkaProizvoda.BrosuraForm form = new NabavkaProizvoda.BrosuraForm();
            form.MdiParent = this;
            form.Show();
        }

        private void novaBrošuraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            NabavkaProizvoda.NovaBrosuraForm form = new NabavkaProizvoda.NovaBrosuraForm();
            form.MdiParent = this;
            form.Show();
        }
    }
}
