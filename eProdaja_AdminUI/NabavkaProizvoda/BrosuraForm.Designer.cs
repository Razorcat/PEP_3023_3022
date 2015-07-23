namespace eProdaja_AdminUI.NabavkaProizvoda
{
    partial class BrosuraForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nazivInput = new System.Windows.Forms.TextBox();
            this.sifraInput = new System.Windows.Forms.TextBox();
            this.cijenaInput = new System.Windows.Forms.TextBox();
            this.btnOdaberiProizvod = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBrosura = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxtAkcijskaCijena = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnZakljuci = new System.Windows.Forms.Button();
            this.proizvodiSGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiSGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Šifra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cijena:";
            // 
            // nazivInput
            // 
            this.nazivInput.Location = new System.Drawing.Point(91, 56);
            this.nazivInput.Name = "nazivInput";
            this.nazivInput.ReadOnly = true;
            this.nazivInput.Size = new System.Drawing.Size(158, 20);
            this.nazivInput.TabIndex = 3;
            this.nazivInput.TextChanged += new System.EventHandler(this.nazivInput_TextChanged);
            // 
            // sifraInput
            // 
            this.sifraInput.Location = new System.Drawing.Point(91, 93);
            this.sifraInput.Name = "sifraInput";
            this.sifraInput.ReadOnly = true;
            this.sifraInput.Size = new System.Drawing.Size(158, 20);
            this.sifraInput.TabIndex = 4;
            this.sifraInput.TextChanged += new System.EventHandler(this.sifraInput_TextChanged);
            // 
            // cijenaInput
            // 
            this.cijenaInput.Location = new System.Drawing.Point(91, 128);
            this.cijenaInput.Name = "cijenaInput";
            this.cijenaInput.ReadOnly = true;
            this.cijenaInput.Size = new System.Drawing.Size(158, 20);
            this.cijenaInput.TabIndex = 5;
            // 
            // btnOdaberiProizvod
            // 
            this.btnOdaberiProizvod.Location = new System.Drawing.Point(32, 12);
            this.btnOdaberiProizvod.Name = "btnOdaberiProizvod";
            this.btnOdaberiProizvod.Size = new System.Drawing.Size(217, 38);
            this.btnOdaberiProizvod.TabIndex = 6;
            this.btnOdaberiProizvod.Text = "Odaberite proizvod";
            this.btnOdaberiProizvod.UseVisualStyleBackColor = true;
            this.btnOdaberiProizvod.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Brošura:";
            // 
            // cmbBrosura
            // 
            this.cmbBrosura.FormattingEnabled = true;
            this.cmbBrosura.Location = new System.Drawing.Point(328, 51);
            this.cmbBrosura.Name = "cmbBrosura";
            this.cmbBrosura.Size = new System.Drawing.Size(154, 21);
            this.cmbBrosura.TabIndex = 8;
            this.cmbBrosura.SelectedIndexChanged += new System.EventHandler(this.cmbBrosura_SelectedIndexChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(32, 202);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(217, 40);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = global::eProdaja_AdminUI.Properties.Resources.paperplus322;
            this.button2.Location = new System.Drawing.Point(497, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 43);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Akcijska cijena:";
            // 
            // mtxtAkcijskaCijena
            // 
            this.mtxtAkcijskaCijena.Location = new System.Drawing.Point(116, 163);
            this.mtxtAkcijskaCijena.Mask = "0000.00";
            this.mtxtAkcijskaCijena.Name = "mtxtAkcijskaCijena";
            this.mtxtAkcijskaCijena.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtAkcijskaCijena.Size = new System.Drawing.Size(104, 20);
            this.mtxtAkcijskaCijena.TabIndex = 13;
            this.mtxtAkcijskaCijena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "KM";
            // 
            // btnZakljuci
            // 
            this.btnZakljuci.Location = new System.Drawing.Point(376, 414);
            this.btnZakljuci.Name = "btnZakljuci";
            this.btnZakljuci.Size = new System.Drawing.Size(152, 40);
            this.btnZakljuci.TabIndex = 15;
            this.btnZakljuci.Text = "Zaključi";
            this.btnZakljuci.UseVisualStyleBackColor = true;
            this.btnZakljuci.Click += new System.EventHandler(this.btnZakljuci_Click);
            // 
            // proizvodiSGrid
            // 
            this.proizvodiSGrid.AllowUserToAddRows = false;
            this.proizvodiSGrid.AllowUserToDeleteRows = false;
            this.proizvodiSGrid.AllowUserToOrderColumns = true;
            this.proizvodiSGrid.Location = new System.Drawing.Point(32, 248);
            this.proizvodiSGrid.MultiSelect = false;
            this.proizvodiSGrid.Name = "proizvodiSGrid";
            this.proizvodiSGrid.ReadOnly = true;
            this.proizvodiSGrid.RowHeadersWidth = 55;
            this.proizvodiSGrid.RowTemplate.ReadOnly = true;
            this.proizvodiSGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.proizvodiSGrid.Size = new System.Drawing.Size(507, 150);
            this.proizvodiSGrid.TabIndex = 16;
            // 
            // BrosuraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(551, 466);
            this.Controls.Add(this.proizvodiSGrid);
            this.Controls.Add(this.btnZakljuci);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mtxtAkcijskaCijena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbBrosura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOdaberiProizvod);
            this.Controls.Add(this.cijenaInput);
            this.Controls.Add(this.sifraInput);
            this.Controls.Add(this.nazivInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BrosuraForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brošure";
            this.Load += new System.EventHandler(this.BrosuraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiSGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nazivInput;
        private System.Windows.Forms.TextBox sifraInput;
        private System.Windows.Forms.TextBox cijenaInput;
        private System.Windows.Forms.Button btnOdaberiProizvod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBrosura;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxtAkcijskaCijena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnZakljuci;
        private System.Windows.Forms.DataGridView proizvodiSGrid;
    }
}