namespace eProdaja_AdminUI.NabavkaProizvoda
{
    partial class VrsteProizvodaForm
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
            this.inputNaziv = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaziv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNaziv.Location = new System.Drawing.Point(24, 39);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(43, 13);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv:";
            // 
            // inputNaziv
            // 
            this.inputNaziv.Location = new System.Drawing.Point(77, 36);
            this.inputNaziv.Name = "inputNaziv";
            this.inputNaziv.Size = new System.Drawing.Size(198, 20);
            this.inputNaziv.TabIndex = 1;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Image = global::eProdaja_AdminUI.Properties.Resources.paperplus324;
            this.btnDodaj.Location = new System.Drawing.Point(229, 83);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(46, 45);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // VrsteProizvodaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(326, 151);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.inputNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Name = "VrsteProizvodaForm";
            this.Text = "Unos vrsta proizvoda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox inputNaziv;
        private System.Windows.Forms.Button btnDodaj;
    }
}