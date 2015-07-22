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
    public partial class DobavljaciForm : Form
    {
        public Dobavljaci dobavljac { get; set; }
        public DobavljaciForm()
        {
            InitializeComponent();
        }

        private void DobavljaciForm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            dobavljaciGrid.AutoGenerateColumns = false;
            dobavljaciGrid.DataSource = DADobavljaci.SelectByNaziv(nazivInput.Text);
            dobavljaciGrid.ClearSelection();
        }

        private void nazivInput_TextChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void dobavljaciGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int dobavljacId = Convert.ToInt32(dobavljaciGrid.SelectedRows[0].Cells[0].Value);
                dobavljac = DADobavljaci.SelectById(dobavljacId);
                this.Close();
            }

        }

    }
}
