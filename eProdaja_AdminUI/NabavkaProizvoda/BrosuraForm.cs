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

namespace eProdaja_AdminUI.NabavkaProizvoda
{
    public partial class BrosuraForm : Form
    {
        private Proizvodi proizvod;
        public BrosuraForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NabavkaProizvoda.OdabirProizvoda frmOdb = new NabavkaProizvoda.OdabirProizvoda();
            frmOdb.ShowDialog();

            if (frmOdb.proizvod != null)
            {
                proizvod = frmOdb.proizvod;
                nazivInput.Text = proizvod.Naziv;
                sifraInput.Text = proizvod.Sifra;
                cijenaInput.Text = proizvod.Cijena.ToString();
            }
        }


        private void BindBrosure()
        {
            cmbBrosura.DataSource = DAProizvodi.SelectBrosuru();
            cmbBrosura.DisplayMember = "NazivBrosure";
            cmbBrosura.ValueMember = "BrosuraID";
        }

        private void BindGrid()
        {
            proizvodiSGrid.AutoGenerateColumns = false;
            proizvodiSGrid.DataSource = DAProizvodi.SelectBrosure();
            proizvodiSGrid.Columns[0].Visible = false;
        }

        private void BrosuraForm_Load(object sender, EventArgs e)
        {
            BindGrid();
            BindBrosure();
        }

        private void nazivInput_TextChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void sifraInput_TextChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NovaBrosuraForm frmNovi = new NovaBrosuraForm();
            frmNovi.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BrosureProizvodi bp = new BrosureProizvodi();
            bp.BrosuraID = Convert.ToInt32(cmbBrosura.SelectedValue);
            bp.ProizvodID = proizvod.ProizvodID;

            DABrosure.insertBrosureProizvodi(bp);

            BindGrid();
        }


    }
}
