namespace eProdaja_AdminUI.Izvjestaji
{
    partial class ProdajaForm
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.datumOdPicker = new System.Windows.Forms.DateTimePicker();
            this.datumDoPicker = new System.Windows.Forms.DateTimePicker();
            this.prikaziButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.Location = new System.Drawing.Point(0, 48);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(614, 506);
            this.reportViewer1.TabIndex = 0;
            // 
            // datumOdPicker
            // 
            this.datumOdPicker.Location = new System.Drawing.Point(24, 15);
            this.datumOdPicker.Name = "datumOdPicker";
            this.datumOdPicker.Size = new System.Drawing.Size(200, 20);
            this.datumOdPicker.TabIndex = 1;
            // 
            // datumDoPicker
            // 
            this.datumDoPicker.Location = new System.Drawing.Point(247, 15);
            this.datumDoPicker.Name = "datumDoPicker";
            this.datumDoPicker.Size = new System.Drawing.Size(200, 20);
            this.datumDoPicker.TabIndex = 2;
            // 
            // prikaziButton
            // 
            this.prikaziButton.Location = new System.Drawing.Point(475, 12);
            this.prikaziButton.Name = "prikaziButton";
            this.prikaziButton.Size = new System.Drawing.Size(75, 23);
            this.prikaziButton.TabIndex = 3;
            this.prikaziButton.Text = "Prikaži";
            this.prikaziButton.UseVisualStyleBackColor = true;
            this.prikaziButton.Click += new System.EventHandler(this.prikaziButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(230, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "-";
            // 
            // ProdajaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prikaziButton);
            this.Controls.Add(this.datumDoPicker);
            this.Controls.Add(this.datumOdPicker);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProdajaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prodaja";
            this.Load += new System.EventHandler(this.ProdajaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker datumOdPicker;
        private System.Windows.Forms.DateTimePicker datumDoPicker;
        private System.Windows.Forms.Button prikaziButton;
        private System.Windows.Forms.Label label1;
    }
}