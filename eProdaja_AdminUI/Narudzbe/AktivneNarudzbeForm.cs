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

namespace eProdaja_AdminUI.Narudzbe
{
    public partial class AktivneNarudzbeForm : Form
    {
        List<Proizvodi> proizvodi;
        List<NarudzbaStavke> ns;
        int narudzbaID = 0;
        public AktivneNarudzbeForm()
        {
            InitializeComponent();
            BindNarudzbe();
        }

        private void AktivneNarudzbeForm_Load(object sender, EventArgs e)
        {            
           
        }
        private void BindNarudzbe() {
            narudzbeGrid.ClearSelection();
            narudzbeGrid.DataSource = DANarudzbe.SelectAktivne();
            narudzbeGrid.Columns[0].Visible = false;
            narudzbeGrid.Columns[2].Visible = false;
        }
        private void BindProizvode(int NarudzbaID) {
            proizvodi = new List<Proizvodi>();
            ns = new List<NarudzbaStavke>();
            foreach(esp_Narudzbe_GetProizvodeByNarudzbaId_Result pn in DANarudzbe.GetProizvodeNarudzbaByID(NarudzbaID))
                proizvodi.Add(DAProizvodi.SelectById(pn.ProizvodID));
            foreach (Proizvodi p in proizvodi) {
                ns.Add(DANarudzbe.NarudzbeStavkaGetByProizvodId(p.ProizvodID));
            }
                
            narudzbeGrid.ClearSelection();
            proizvodiGrid.DataSource = DANarudzbe.GetProizvodeNarudzbaByID(NarudzbaID);
            narudzbeGrid.Columns[0].Visible = false;
            narudzbeGrid.Columns[1].Visible = false;
            narudzbeGrid.Columns[2].Visible = false;            
        }

        private void narudzbeGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            narudzbaID = Convert.ToInt32(narudzbeGrid.SelectedRows[0].Cells[0].Value);
            if (narudzbaID >= 1)
                BindProizvode(narudzbaID);
        }

        private void btnOtkaziNarudzbu_Click(object sender, EventArgs e)
        {
            if (narudzbaID >= 1)
            {
                DANarudzbe.OtkaziNarudzbu(narudzbaID, true);
                BindNarudzbe();
                MessageBox.Show("Odabrana narudžba otkazana!", "Narudžba info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnZakljuciNarudzbu_Click(object sender, EventArgs e)
        {
            Narudzbe.ProdajaForm pf = new ProdajaForm(ns);
            pf.ShowDialog();
        }
    }
}
