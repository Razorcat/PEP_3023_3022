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

namespace eProdaja_AdminUI.Korisnici
{
    public partial class PretragaForm : Form
    {
        eProdaja_Service.Data.Korisnici korisnik;
        public PretragaForm()
        {
            InitializeComponent();

        }

        private void PretragaForm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void imePrezimeInput_TextChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            korisniciGrid.DataSource = DAKorisnici.SelectByName(imePrezimeInput.Text.Trim());
            korisniciGrid.Columns[0].Visible = false;
            korisniciGrid.ClearSelection();
            korisnik = null;
        }

        private void korisniciGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            korisnik = DAKorisnici.SelectById(Convert.ToInt32(korisniciGrid.SelectedRows[0].Cells[0].Value));
        }

        private void deaktivirajButton_Click(object sender, EventArgs e)
        {
            if (korisnik != null)
            {
                if ((bool)korisniciGrid.SelectedRows[0].Cells[4].Value &&
                    korisnik.KorisnikID != Global.prijavljeniKorisnik.KorisnikID)
                {
                    DAKorisnici.UpdateStatus(korisnik.KorisnikID, false);
                    BindGrid();
                }
                else MessageBox.Show("Ne možete deaktivirati trenutno prijavljenog korisnika!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void pristupMenu_Click(object sender, EventArgs e)
        {
            if (korisnik != null)
            {
                PristupSistemuForm form = new PristupSistemuForm(korisnik);
                form.ShowDialog();
                BindGrid();
            }
        }

        private void updateMenu_Click(object sender, EventArgs e)
        {
            if (korisnik != null)
            {
                NoviKorisnikForm updateForm = new NoviKorisnikForm(korisnik);
                updateForm.ShowDialog();
                BindGrid();
            }
        }
    }
}
