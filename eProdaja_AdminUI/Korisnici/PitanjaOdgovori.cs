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

namespace eProdaja_AdminUI.Korisnici
{
    public partial class PitanjaOdgovori : Form
    {
        eProdaja_Service.Data.Korisnici korisnik;
        int pitanjeId = 0;
        public PitanjaOdgovori(eProdaja_Service.Data.Korisnici k)
        {
            InitializeComponent();

            if (k != null)
            {
                korisnik = k;               
            }
            BindGridPitanja();
        }

        private void BindGridPitanja()
        {
            dgvPitanja.ClearSelection();
            dgvPitanja.DataSource = DAPitanjaOdgovori.GetPitanja();
            dgvPitanja.Columns[1].Visible = false;
            dgvPitanja.Columns[2].Visible = false;
            dgvPitanja.Columns[3].Visible = false;
        }

        private void btnOdgovori_Click(object sender, EventArgs e)
        {
            if (korisnik.KorisnikID > 0 && pitanjeId > 0)
            {
                DAPitanjaOdgovori.InsertOdgovor(pitanjeId, korisnik.KorisnikID, rtxtbOdgovor.Text);
                BindGridPitanja();
            }
        }

        private void dgvPitanja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pitanjeId = Convert.ToInt32(dgvPitanja.SelectedRows[0].Cells[1].Value);            
        }
    }
}
