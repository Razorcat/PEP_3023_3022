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
using Microsoft.Reporting.WinForms;

namespace eProdaja_AdminUI.Izvjestaji
{
    public partial class ProdajaForm : Form
    {
        public ProdajaForm()
        {
            InitializeComponent();
        }

        private void ProdajaForm_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "eProdaja_AdminUI.Izvjestaji.ProdajaReport.rdlc";
        }

        private void prikaziButton_Click(object sender, EventArgs e)
        {
            List<esp_Izlaz_SelectByDatum_Result> ds = DAProizvodi.SelectProdajaByDatum(datumOdPicker.Value, datumDoPicker.Value);
            ReportDataSource rds = new ReportDataSource("DataSet1", ds);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(new ReportParameter("DatumOd", datumOdPicker.Value.ToShortDateString()));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("DatumDo", datumDoPicker.Value.ToShortDateString()));

            reportViewer1.RefreshReport();
        }
    }
}
