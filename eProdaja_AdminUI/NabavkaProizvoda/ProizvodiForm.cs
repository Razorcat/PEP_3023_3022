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
    public partial class ProizvodiForm : Form
    {
        public ProizvodiForm()
        {
            InitializeComponent();
        }

        private void ProizvodiForm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            proizvodiGrid.ClearSelection();
            proizvodiGrid.DataSource = DAProizvodi.SelectBySifraNaziv(sifraInput.Text, nazivInput.Text);
            proizvodiGrid.Columns[0].Visible = false;
            proizvodiGrid.ClearSelection();
        }

        private void sifraInput_TextChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void nazivInput_TextChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

    }
}
