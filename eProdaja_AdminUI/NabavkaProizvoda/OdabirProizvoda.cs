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
    public partial class OdabirProizvoda : Form
    {
        public Proizvodi proizvod { get; set; }
        public OdabirProizvoda()
        {
            InitializeComponent();
        }


        private void BindGrid()
        {
            proizvodiGrid.AutoGenerateColumns = false;
            proizvodiGrid.DataSource = DAProizvodi.SelectByNaziv(nazivInput.Text.Trim());
            proizvodiGrid.ClearSelection();
        }

        private void nazivInput_TextChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void proizvodiGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int proizvodId = Convert.ToInt32(proizvodiGrid.SelectedRows[0].Cells[0].Value);
                proizvod = DAProizvodi.SelectById(proizvodId);
                this.Close();
            }
        }

        private void OdabirProizvoda_Load(object sender, EventArgs e)
        {
            BindGrid();
        }




    }
}
