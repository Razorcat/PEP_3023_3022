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
    public partial class NovaBrosuraForm : Form
    {
        public NovaBrosuraForm()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (nazivInput.Text.Trim() == "")
                MessageBox.Show("Naziv brošure ne može biti prazno polje!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                Brosure b = new Brosure();
                b.NazivBrosure = nazivInput.Text;
                b.DatumPocetka = datumPTimePicker.Value;
                b.DatumIsteka = datumITimePicker1.Value;

                DABrosure.Insert(b);
                MessageBox.Show(Global.GetString("insertB_succ"), "Uspješno ste dodali brošuru",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }
    }
}
