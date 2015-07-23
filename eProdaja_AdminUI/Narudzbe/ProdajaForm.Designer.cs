namespace eProdaja_AdminUI.Narudzbe
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
            this.txtbIznosSaPDV = new System.Windows.Forms.TextBox();
            this.mtxtbCijena = new System.Windows.Forms.MaskedTextBox();
            this.lblCijena = new System.Windows.Forms.Label();
            this.ntxtbKolicina = new System.Windows.Forms.NumericUpDown();
            this.lblBrojRacuna = new System.Windows.Forms.Label();
            this.txtbIznosBezPDV = new System.Windows.Forms.TextBox();
            this.lblIznosbezPDV = new System.Windows.Forms.Label();
            this.dgvProdaja = new System.Windows.Forms.DataGridView();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.btnDodajP = new System.Windows.Forms.Button();
            this.txtbNaziv = new System.Windows.Forms.TextBox();
            this.lblIznosSaPDV = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.btnZakljuciProdaju = new System.Windows.Forms.Button();
            this.txtbSifra = new System.Windows.Forms.TextBox();
            this.cmbSkladisteList = new System.Windows.Forms.ComboBox();
            this.lblSkladiste = new System.Windows.Forms.Label();
            this.grbProdaja = new System.Windows.Forms.GroupBox();
            this.txtbBrRacuna = new System.Windows.Forms.TextBox();
            this.btnBrisiStavku = new System.Windows.Forms.Button();
            this.lblSifra = new System.Windows.Forms.Label();
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.grbProizvodi = new System.Windows.Forms.GroupBox();
            this.lblP = new System.Windows.Forms.Label();
            this.ntxtbPopust = new System.Windows.Forms.NumericUpDown();
            this.lblPopust = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtbKolicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdaja)).BeginInit();
            this.grbProdaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            this.grbProizvodi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtbPopust)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbIznosSaPDV
            // 
            this.txtbIznosSaPDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtbIznosSaPDV.Location = new System.Drawing.Point(305, 396);
            this.txtbIznosSaPDV.Name = "txtbIznosSaPDV";
            this.txtbIznosSaPDV.ReadOnly = true;
            this.txtbIznosSaPDV.Size = new System.Drawing.Size(100, 20);
            this.txtbIznosSaPDV.TabIndex = 13;
            // 
            // mtxtbCijena
            // 
            this.mtxtbCijena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mtxtbCijena.Location = new System.Drawing.Point(53, 340);
            this.mtxtbCijena.Mask = "0000.00";
            this.mtxtbCijena.Name = "mtxtbCijena";
            this.mtxtbCijena.Size = new System.Drawing.Size(110, 20);
            this.mtxtbCijena.TabIndex = 18;
            // 
            // lblCijena
            // 
            this.lblCijena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(8, 342);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(39, 13);
            this.lblCijena.TabIndex = 17;
            this.lblCijena.Text = "Cijena:";
            // 
            // ntxtbKolicina
            // 
            this.ntxtbKolicina.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ntxtbKolicina.Location = new System.Drawing.Point(296, 340);
            this.ntxtbKolicina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ntxtbKolicina.Name = "ntxtbKolicina";
            this.ntxtbKolicina.Size = new System.Drawing.Size(47, 20);
            this.ntxtbKolicina.TabIndex = 8;
            this.ntxtbKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblBrojRacuna
            // 
            this.lblBrojRacuna.AutoSize = true;
            this.lblBrojRacuna.Location = new System.Drawing.Point(6, 22);
            this.lblBrojRacuna.Name = "lblBrojRacuna";
            this.lblBrojRacuna.Size = new System.Drawing.Size(64, 13);
            this.lblBrojRacuna.TabIndex = 11;
            this.lblBrojRacuna.Text = "Broj računa:";
            // 
            // txtbIznosBezPDV
            // 
            this.txtbIznosBezPDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtbIznosBezPDV.Location = new System.Drawing.Point(102, 396);
            this.txtbIznosBezPDV.Name = "txtbIznosBezPDV";
            this.txtbIznosBezPDV.ReadOnly = true;
            this.txtbIznosBezPDV.Size = new System.Drawing.Size(100, 20);
            this.txtbIznosBezPDV.TabIndex = 10;
            // 
            // lblIznosbezPDV
            // 
            this.lblIznosbezPDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIznosbezPDV.AutoSize = true;
            this.lblIznosbezPDV.Location = new System.Drawing.Point(7, 399);
            this.lblIznosbezPDV.Name = "lblIznosbezPDV";
            this.lblIznosbezPDV.Size = new System.Drawing.Size(89, 13);
            this.lblIznosbezPDV.TabIndex = 9;
            this.lblIznosbezPDV.Text = "Iznos bez PDV-a:";
            // 
            // dgvProdaja
            // 
            this.dgvProdaja.AllowUserToAddRows = false;
            this.dgvProdaja.AllowUserToDeleteRows = false;
            this.dgvProdaja.AllowUserToOrderColumns = true;
            this.dgvProdaja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdaja.Location = new System.Drawing.Point(7, 45);
            this.dgvProdaja.Name = "dgvProdaja";
            this.dgvProdaja.ReadOnly = true;
            this.dgvProdaja.Size = new System.Drawing.Size(486, 288);
            this.dgvProdaja.TabIndex = 8;
            this.dgvProdaja.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdaja_CellClick);
            // 
            // lblKolicina
            // 
            this.lblKolicina.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(243, 341);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(47, 13);
            this.lblKolicina.TabIndex = 6;
            this.lblKolicina.Text = "Količina:";
            // 
            // btnDodajP
            // 
            this.btnDodajP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDodajP.BackgroundImage = global::eProdaja_AdminUI.Properties.Resources.paperplus325;
            this.btnDodajP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDodajP.Location = new System.Drawing.Point(188, 372);
            this.btnDodajP.Name = "btnDodajP";
            this.btnDodajP.Size = new System.Drawing.Size(155, 46);
            this.btnDodajP.TabIndex = 5;
            this.btnDodajP.Text = "Dodaj proizvod";
            this.btnDodajP.UseVisualStyleBackColor = true;
            this.btnDodajP.Click += new System.EventHandler(this.btnDodajP_Click);
            // 
            // txtbNaziv
            // 
            this.txtbNaziv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbNaziv.Location = new System.Drawing.Point(399, 18);
            this.txtbNaziv.Name = "txtbNaziv";
            this.txtbNaziv.Size = new System.Drawing.Size(94, 20);
            this.txtbNaziv.TabIndex = 4;
            this.txtbNaziv.TextChanged += new System.EventHandler(this.txtbNaziv_TextChanged);
            // 
            // lblIznosSaPDV
            // 
            this.lblIznosSaPDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIznosSaPDV.AutoSize = true;
            this.lblIznosSaPDV.Location = new System.Drawing.Point(208, 399);
            this.lblIznosSaPDV.Name = "lblIznosSaPDV";
            this.lblIznosSaPDV.Size = new System.Drawing.Size(91, 13);
            this.lblIznosSaPDV.TabIndex = 12;
            this.lblIznosSaPDV.Text = "Iznos sa PDV-om:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(357, 21);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(37, 13);
            this.lblNaziv.TabIndex = 3;
            this.lblNaziv.Text = "Naziv:";
            // 
            // btnZakljuciProdaju
            // 
            this.btnZakljuciProdaju.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZakljuciProdaju.Location = new System.Drawing.Point(418, 372);
            this.btnZakljuciProdaju.Name = "btnZakljuciProdaju";
            this.btnZakljuciProdaju.Size = new System.Drawing.Size(75, 46);
            this.btnZakljuciProdaju.TabIndex = 6;
            this.btnZakljuciProdaju.Text = "Zaključi prodaju";
            this.btnZakljuciProdaju.UseVisualStyleBackColor = true;
            this.btnZakljuciProdaju.Click += new System.EventHandler(this.btnZakljuciProdaju_Click);
            // 
            // txtbSifra
            // 
            this.txtbSifra.Location = new System.Drawing.Point(93, 20);
            this.txtbSifra.MaxLength = 55;
            this.txtbSifra.Name = "txtbSifra";
            this.txtbSifra.Size = new System.Drawing.Size(69, 20);
            this.txtbSifra.TabIndex = 2;
            this.txtbSifra.TextChanged += new System.EventHandler(this.txtbSifra_TextChanged);
            // 
            // cmbSkladisteList
            // 
            this.cmbSkladisteList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSkladisteList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSkladisteList.FormattingEnabled = true;
            this.cmbSkladisteList.Location = new System.Drawing.Point(271, 18);
            this.cmbSkladisteList.Name = "cmbSkladisteList";
            this.cmbSkladisteList.Size = new System.Drawing.Size(140, 21);
            this.cmbSkladisteList.TabIndex = 24;
            this.cmbSkladisteList.SelectedIndexChanged += new System.EventHandler(this.cmbSkladisteList_SelectedIndexChanged);
            // 
            // lblSkladiste
            // 
            this.lblSkladiste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSkladiste.AutoSize = true;
            this.lblSkladiste.Location = new System.Drawing.Point(212, 21);
            this.lblSkladiste.Name = "lblSkladiste";
            this.lblSkladiste.Size = new System.Drawing.Size(53, 13);
            this.lblSkladiste.TabIndex = 25;
            this.lblSkladiste.Text = "Skladište:";
            // 
            // grbProdaja
            // 
            this.grbProdaja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbProdaja.Controls.Add(this.cmbSkladisteList);
            this.grbProdaja.Controls.Add(this.lblSkladiste);
            this.grbProdaja.Controls.Add(this.txtbBrRacuna);
            this.grbProdaja.Controls.Add(this.txtbIznosSaPDV);
            this.grbProdaja.Controls.Add(this.lblIznosSaPDV);
            this.grbProdaja.Controls.Add(this.lblBrojRacuna);
            this.grbProdaja.Controls.Add(this.txtbIznosBezPDV);
            this.grbProdaja.Controls.Add(this.lblIznosbezPDV);
            this.grbProdaja.Controls.Add(this.dgvProdaja);
            this.grbProdaja.Controls.Add(this.btnBrisiStavku);
            this.grbProdaja.Controls.Add(this.btnZakljuciProdaju);
            this.grbProdaja.Location = new System.Drawing.Point(518, 12);
            this.grbProdaja.Name = "grbProdaja";
            this.grbProdaja.Size = new System.Drawing.Size(499, 424);
            this.grbProdaja.TabIndex = 4;
            this.grbProdaja.TabStop = false;
            this.grbProdaja.Text = "Prodaja";
            // 
            // txtbBrRacuna
            // 
            this.txtbBrRacuna.Location = new System.Drawing.Point(76, 19);
            this.txtbBrRacuna.MaxLength = 55;
            this.txtbBrRacuna.Name = "txtbBrRacuna";
            this.txtbBrRacuna.ReadOnly = true;
            this.txtbBrRacuna.Size = new System.Drawing.Size(110, 20);
            this.txtbBrRacuna.TabIndex = 14;
            // 
            // btnBrisiStavku
            // 
            this.btnBrisiStavku.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBrisiStavku.BackgroundImage = global::eProdaja_AdminUI.Properties.Resources.paperminus32;
            this.btnBrisiStavku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBrisiStavku.Location = new System.Drawing.Point(7, 339);
            this.btnBrisiStavku.Name = "btnBrisiStavku";
            this.btnBrisiStavku.Size = new System.Drawing.Size(195, 46);
            this.btnBrisiStavku.TabIndex = 7;
            this.btnBrisiStavku.Text = "Briši stavku";
            this.btnBrisiStavku.UseVisualStyleBackColor = true;
            this.btnBrisiStavku.Click += new System.EventHandler(this.btnBrisiStavku_Click);
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.Location = new System.Drawing.Point(7, 22);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(80, 13);
            this.lblSifra.TabIndex = 1;
            this.lblSifra.Text = "Šifra proizvoda:";
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.AllowUserToAddRows = false;
            this.dgvProizvodi.AllowUserToDeleteRows = false;
            this.dgvProizvodi.AllowUserToOrderColumns = true;
            this.dgvProizvodi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Location = new System.Drawing.Point(10, 45);
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.ReadOnly = true;
            this.dgvProizvodi.RowTemplate.Height = 55;
            this.dgvProizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProizvodi.Size = new System.Drawing.Size(486, 288);
            this.dgvProizvodi.TabIndex = 0;
            this.dgvProizvodi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProizvodi_CellClick);
            // 
            // grbProizvodi
            // 
            this.grbProizvodi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbProizvodi.Controls.Add(this.mtxtbCijena);
            this.grbProizvodi.Controls.Add(this.lblCijena);
            this.grbProizvodi.Controls.Add(this.lblP);
            this.grbProizvodi.Controls.Add(this.lblPopust);
            this.grbProizvodi.Controls.Add(this.ntxtbPopust);
            this.grbProizvodi.Controls.Add(this.ntxtbKolicina);
            this.grbProizvodi.Controls.Add(this.lblKolicina);
            this.grbProizvodi.Controls.Add(this.btnDodajP);
            this.grbProizvodi.Controls.Add(this.txtbNaziv);
            this.grbProizvodi.Controls.Add(this.lblNaziv);
            this.grbProizvodi.Controls.Add(this.txtbSifra);
            this.grbProizvodi.Controls.Add(this.lblSifra);
            this.grbProizvodi.Controls.Add(this.dgvProizvodi);
            this.grbProizvodi.Location = new System.Drawing.Point(12, 12);
            this.grbProizvodi.Name = "grbProizvodi";
            this.grbProizvodi.Size = new System.Drawing.Size(499, 424);
            this.grbProizvodi.TabIndex = 3;
            this.grbProizvodi.TabStop = false;
            this.grbProizvodi.Text = "Proizvodi";
            // 
            // lblP
            // 
            this.lblP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(475, 343);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(15, 13);
            this.lblP.TabIndex = 11;
            this.lblP.Text = "%";
            // 
            // ntxtbPopust
            // 
            this.ntxtbPopust.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ntxtbPopust.Location = new System.Drawing.Point(424, 339);
            this.ntxtbPopust.Name = "ntxtbPopust";
            this.ntxtbPopust.Size = new System.Drawing.Size(49, 20);
            this.ntxtbPopust.TabIndex = 9;
            // 
            // lblPopust
            // 
            this.lblPopust.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPopust.AutoSize = true;
            this.lblPopust.Location = new System.Drawing.Point(375, 342);
            this.lblPopust.Name = "lblPopust";
            this.lblPopust.Size = new System.Drawing.Size(43, 13);
            this.lblPopust.TabIndex = 10;
            this.lblPopust.Text = "Popust:";
            // 
            // ProdajaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1029, 440);
            this.Controls.Add(this.grbProdaja);
            this.Controls.Add(this.grbProizvodi);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProdajaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Prodaja";
            ((System.ComponentModel.ISupportInitialize)(this.ntxtbKolicina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdaja)).EndInit();
            this.grbProdaja.ResumeLayout(false);
            this.grbProdaja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            this.grbProizvodi.ResumeLayout(false);
            this.grbProizvodi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtbPopust)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtbIznosSaPDV;
        private System.Windows.Forms.MaskedTextBox mtxtbCijena;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.NumericUpDown ntxtbKolicina;
        private System.Windows.Forms.Label lblBrojRacuna;
        private System.Windows.Forms.TextBox txtbIznosBezPDV;
        private System.Windows.Forms.Label lblIznosbezPDV;
        private System.Windows.Forms.DataGridView dgvProdaja;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Button btnDodajP;
        private System.Windows.Forms.TextBox txtbNaziv;
        private System.Windows.Forms.Label lblIznosSaPDV;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Button btnZakljuciProdaju;
        private System.Windows.Forms.TextBox txtbSifra;
        private System.Windows.Forms.ComboBox cmbSkladisteList;
        private System.Windows.Forms.Label lblSkladiste;
        private System.Windows.Forms.GroupBox grbProdaja;
        private System.Windows.Forms.TextBox txtbBrRacuna;
        private System.Windows.Forms.Button btnBrisiStavku;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.GroupBox grbProizvodi;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblPopust;
        private System.Windows.Forms.NumericUpDown ntxtbPopust;

    }
}