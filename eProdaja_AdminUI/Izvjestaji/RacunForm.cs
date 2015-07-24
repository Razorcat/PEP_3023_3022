using eProdaja_Service.Data;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eProdaja_AdminUI.Izvjestaji
{
    public partial class RacunForm : Form
    {
        int IzlazID;
        public RacunForm(int IzlazId)
        {
            InitializeComponent();
            IzlazID = IzlazId;
        }

        private void RacunForm_Load(object sender, EventArgs e)
        {

            this.reportViewer.LocalReport.ReportEmbeddedResource = "eProdaja_AdminUI.Izvjestaji.RacunReport.rdlc";
            BindReport(IzlazID);
        }
        private void BindReport(int IzlazId)
        {
            List<eProdaja_Service.Data.esp_GetRacunByIzlazID_Result1> ds = DAProdaja.GetRacun(IzlazId);
            ReportDataSource rds = new ReportDataSource("DataSetRacun", ds);
            reportViewer.LocalReport.DataSources.Add(rds);
            reportViewer.LocalReport.SetParameters(new ReportParameter("IzlazID_parameter", IzlazId.ToString()));
            this.reportViewer.RefreshReport();
        }
    }
}
