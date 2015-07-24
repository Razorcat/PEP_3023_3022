namespace eProdaja_AdminUI.Izvjestaji
{
    partial class RacunForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.esp_GetRacunByIzlazID_Result1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.esp_GetRacunByIzlazID_Result1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer.LocalReport.ReportEmbeddedResource = "eProdaja_AdminUI.Izvjestaji.RacunReport.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(723, 650);
            this.reportViewer.TabIndex = 0;
            // 
            // esp_GetRacunByIzlazID_Result1BindingSource
            // 
            this.esp_GetRacunByIzlazID_Result1BindingSource.DataSource = typeof(eProdaja_Service.Data.esp_GetRacunByIzlazID_Result1);
            // 
            // RacunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 650);
            this.Controls.Add(this.reportViewer);
            this.MinimizeBox = false;
            this.Name = "RacunForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RacunForm";
            this.Load += new System.EventHandler(this.RacunForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.esp_GetRacunByIzlazID_Result1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource esp_GetRacunByIzlazID_Result1BindingSource;
    }
}