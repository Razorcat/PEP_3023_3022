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
    public partial class PrikazBrosuraForm : Form
    {
        public PrikazBrosuraForm()
        {
            InitializeComponent();
        }

        private void PrikazBrosuraForm_Load(object sender, EventArgs e)
        {
            BindBrosure();
        }

        private void BindBrosure()
        {
            brosuraList.DataSource = DABrosure.SelectAll();
            brosuraList.DisplayMember = "NazivBrosure";
            brosuraList.ValueMember = "BrosuraID";
        }

        private void brosuraList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (brosuraList.SelectedIndex != 0)
            {
                int brosuraId = Convert.ToInt32(brosuraList.SelectedValue);
                proizvodiGrid.DataSource = DABrosure.GetBrosureProizvodi(brosuraId);
                proizvodiGrid.Columns[0].Visible = false;
                proizvodiGrid.ClearSelection();
            }

            else
                proizvodiGrid.DataSource = null;
        }

    }
}
