namespace eProdaja_AdminUI.NabavkaProizvoda
{
    partial class AdministracijaDobavljaca
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
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtbDobavljacNaziv = new System.Windows.Forms.TextBox();
            this.btnPromjeniStatus = new System.Windows.Forms.Button();
            this.dgvDobavljaci = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDobavljaci)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(12, 12);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(95, 13);
            this.lblNaziv.TabIndex = 7;
            this.lblNaziv.Text = "Naziv dobavljača :";
            // 
            // txtbDobavljacNaziv
            // 
            this.txtbDobavljacNaziv.Location = new System.Drawing.Point(12, 28);
            this.txtbDobavljacNaziv.Name = "txtbDobavljacNaziv";
            this.txtbDobavljacNaziv.Size = new System.Drawing.Size(215, 20);
            this.txtbDobavljacNaziv.TabIndex = 6;
            // 
            // btnPromjeniStatus
            // 
            this.btnPromjeniStatus.Location = new System.Drawing.Point(233, 12);
            this.btnPromjeniStatus.Name = "btnPromjeniStatus";
            this.btnPromjeniStatus.Size = new System.Drawing.Size(75, 36);
            this.btnPromjeniStatus.TabIndex = 5;
            this.btnPromjeniStatus.Text = "Promjeni status";
            this.btnPromjeniStatus.UseVisualStyleBackColor = true;
            // 
            // dgvDobavljaci
            // 
            this.dgvDobavljaci.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDobavljaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDobavljaci.Location = new System.Drawing.Point(12, 54);
            this.dgvDobavljaci.Name = "dgvDobavljaci";
            this.dgvDobavljaci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDobavljaci.Size = new System.Drawing.Size(337, 195);
            this.dgvDobavljaci.TabIndex = 4;
            // 
            // AdministracijaDobavljaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 261);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txtbDobavljacNaziv);
            this.Controls.Add(this.btnPromjeniStatus);
            this.Controls.Add(this.dgvDobavljaci);
            this.Name = "AdministracijaDobavljaca";
            this.Text = "AdministracijaDobavljaca";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDobavljaci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtbDobavljacNaziv;
        private System.Windows.Forms.Button btnPromjeniStatus;
        private System.Windows.Forms.DataGridView dgvDobavljaci;
    }
}