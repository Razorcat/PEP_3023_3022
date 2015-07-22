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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBrosura = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.proizvodiSGrid = new System.Windows.Forms.DataGridView();
            this.NazivBrosure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Odaberite proizvod";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Brošura";
            // 
            // cmbBrosura
            // 
            this.cmbBrosura.FormattingEnabled = true;
            this.cmbBrosura.Location = new System.Drawing.Point(328, 51);
            this.cmbBrosura.Name = "cmbBrosura";
            this.cmbBrosura.Size = new System.Drawing.Size(154, 21);
            this.cmbBrosura.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(376, 372);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Dodaj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // proizvodiSGrid
            // 
            this.proizvodiSGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proizvodiSGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazivBrosure,
            this.Naziv,
            this.Sifra,
            this.Cijena});
            this.proizvodiSGrid.Location = new System.Drawing.Point(32, 189);
            this.proizvodiSGrid.Name = "proizvodiSGrid";
            this.proizvodiSGrid.Size = new System.Drawing.Size(496, 160);
            this.proizvodiSGrid.TabIndex = 11;
            // 
            // NazivBrosure
            // 
            this.NazivBrosure.DataPropertyName = "NazivBrosure";
            this.NazivBrosure.HeaderText = "Brošura";
            this.NazivBrosure.Name = "NazivBrosure";
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Proizvod";
            this.Naziv.Name = "Naziv";
            // 
            // Sifra
            // 
            this.Sifra.DataPropertyName = "Sifra";
            this.Sifra.HeaderText = "Šifra";
            this.Sifra.Name = "Sifra";
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
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
            // BrosuraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(551, 407);
            this.Controls.Add(this.proizvodiSGrid);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbBrosura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cijenaInput);
            this.Controls.Add(this.sifraInput);
            this.Controls.Add(this.nazivInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BrosuraForm";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBrosura;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView proizvodiSGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivBrosure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
    }
}