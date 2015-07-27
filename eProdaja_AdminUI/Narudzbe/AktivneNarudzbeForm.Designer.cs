namespace eProdaja_AdminUI.Narudzbe
{
    partial class AktivneNarudzbeForm
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
            this.narudzbeGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // narudzbeGrid
            // 
            this.narudzbeGrid.AllowUserToAddRows = false;
            this.narudzbeGrid.AllowUserToDeleteRows = false;
            this.narudzbeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.narudzbeGrid.BackgroundColor = System.Drawing.Color.Pink;
            this.narudzbeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.narudzbeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.narudzbeGrid.Location = new System.Drawing.Point(0, 0);
            this.narudzbeGrid.Name = "narudzbeGrid";
            this.narudzbeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.narudzbeGrid.Size = new System.Drawing.Size(563, 393);
            this.narudzbeGrid.TabIndex = 1;
            // 
            // AktivneNarudzbeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(563, 393);
            this.Controls.Add(this.narudzbeGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AktivneNarudzbeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aktivne narudžbe";
            this.Load += new System.EventHandler(this.AktivneNarudzbeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView narudzbeGrid;
    }
}