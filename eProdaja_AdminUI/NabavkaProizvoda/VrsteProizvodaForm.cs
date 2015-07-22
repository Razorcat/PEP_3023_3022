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
    public partial class VrsteProizvodaForm : Form
    {
        public VrsteProizvodaForm()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            eProdaja_Service.Data.VrsteProizvoda vrste = new eProdaja_Service.Data.VrsteProizvoda();
            vrste.Naziv = inputNaziv.Text.Trim();

            DAProizvodi.VrsteProizvodaInsert(vrste);
            MessageBox.Show(Global.GetString("insert_succ"), "Uspješno ste dodali vrstu proizvoda",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();  
            
        }
    }
}
