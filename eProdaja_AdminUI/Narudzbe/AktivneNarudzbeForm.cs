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
        public AktivneNarudzbeForm()
        {
            InitializeComponent();
        }

        private void AktivneNarudzbeForm_Load(object sender, EventArgs e)
        {
            narudzbeGrid.DataSource = DANarudzbe.SelectAktivne();
            narudzbeGrid.Columns[0].Visible = false;
            narudzbeGrid.Columns[2].Visible = false;
        }
    }
}
