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
    public partial class StanjeSkladistaForm : Form
    {
        public StanjeSkladistaForm()
        {
            InitializeComponent();
        }

        private void StanjeSkladistaForm_Load(object sender, EventArgs e)
        {
            BindSkladista();
        }

        private void BindSkladista()
        {
            skladisteList.DataSource = DASkladista.SelectAll();
            skladisteList.DisplayMember = "Naziv";
            skladisteList.ValueMember = "SkladisteID";
        }

        private void skladisteList_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (skladisteList.SelectedIndex != 0)
            {
                int skladisteId = Convert.ToInt32(skladisteList.SelectedValue);
                proizvodiGrid.DataSource = DASkladista.GetStanjeSkladista(skladisteId);
                proizvodiGrid.Columns[0].Visible = false;
                proizvodiGrid.ClearSelection();
            }
            else
                proizvodiGrid.DataSource = null;
        }
    }
}
