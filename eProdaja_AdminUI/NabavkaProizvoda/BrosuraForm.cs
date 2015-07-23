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
        List<BrosureProizvodi> bpList=new List<BrosureProizvodi>(); 
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
            cmbBrosura.DataSource  = DABrosure.SelectAll();
            cmbBrosura.DisplayMember = "NazivBrosure";
            cmbBrosura.ValueMember = "BrosuraID";
        }

        private void BindGrid()
        {
            proizvodiSGrid.ClearSelection();            
            proizvodiSGrid.DataSource = null;   
            proizvodiSGrid.AutoGenerateColumns = true;
            proizvodiSGrid.DataSource = DAProizvodi.SelectBrosure();
            proizvodiSGrid.DataSource = bpList;
          //  proizvodiSGrid.Columns[0].Visible = true;
            proizvodiSGrid.ClearSelection();   
        }

        private void BrosuraForm_Load(object sender, EventArgs e)
        {
            BindGridByBrosura();
            BindBrosure();
        }

        private void BindGridByBrosura()
        {
            List<esp_BrosureProizvodiGetByBrosuraID_Result> bpList2 =new List<esp_BrosureProizvodiGetByBrosuraID_Result>();
            bpList2 = DABrosure.GetBrosureProizvodi(Convert.ToInt32(cmbBrosura.SelectedValue));
            proizvodiSGrid.DataSource = null;
            proizvodiSGrid.AutoGenerateColumns = true;
            // proizvodiSGrid.DataSource = DAProizvodi.SelectBrosure();
            proizvodiSGrid.DataSource = bpList2;
            //  proizvodiSGrid.Columns[0].Visible = true;
            proizvodiSGrid.ClearSelection();   
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
            if (Convert.ToInt32(cmbBrosura.SelectedValue) != 0)
            {
                if (proizvod != null)
                {
                    BrosureProizvodi bp = new BrosureProizvodi();
                    Brosure b=new Brosure();
                    bp.BrosuraID = Convert.ToInt32(cmbBrosura.SelectedValue);
                    bp.ProizvodID = proizvod.ProizvodID;
                    bp.AkcijskaCijena = Convert.ToDecimal(mtxtAkcijskaCijena.Text);
                    bp.Brosure = b;
                    bp.Proizvodi = proizvod;

                    bpList.Add(bp);

                    BindGrid();
                }
                else MessageBox.Show("Niste odabrali proizvod!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Niste odabrali brošuru!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnZakljuci_Click(object sender, EventArgs e)
        {
            if(bpList.Count>0)
                foreach(BrosureProizvodi bp in bpList)
                    DABrosure.insertBrosureProizvodi(bp);
        }

        private void cmbBrosura_SelectedIndexChanged(object sender, EventArgs e)
        {
            bpList = new List<BrosureProizvodi>();
            if (cmbBrosura.SelectedIndex != 0)
                BindGridByBrosura();   
        }

    }
}
