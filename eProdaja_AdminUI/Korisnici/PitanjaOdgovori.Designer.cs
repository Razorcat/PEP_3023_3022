namespace eProdaja_AdminUI.Korisnici
{
    partial class PitanjaOdgovori
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
            this.dgvPitanja = new System.Windows.Forms.DataGridView();
            this.btnOdgovori = new System.Windows.Forms.Button();
            this.rtxtbOdgovor = new System.Windows.Forms.RichTextBox();
            this.lblOdgovor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPitanja)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPitanja
            // 
            this.dgvPitanja.AllowUserToAddRows = false;
            this.dgvPitanja.AllowUserToDeleteRows = false;
            this.dgvPitanja.AllowUserToOrderColumns = true;
            this.dgvPitanja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPitanja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPitanja.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPitanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPitanja.Location = new System.Drawing.Point(0, 0);
            this.dgvPitanja.Name = "dgvPitanja";
            this.dgvPitanja.ReadOnly = true;
            this.dgvPitanja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPitanja.Size = new System.Drawing.Size(746, 284);
            this.dgvPitanja.TabIndex = 0;
            this.dgvPitanja.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPitanja_CellClick);
            // 
            // btnOdgovori
            // 
            this.btnOdgovori.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOdgovori.Location = new System.Drawing.Point(0, 374);
            this.btnOdgovori.Name = "btnOdgovori";
            this.btnOdgovori.Size = new System.Drawing.Size(746, 49);
            this.btnOdgovori.TabIndex = 2;
            this.btnOdgovori.Text = "Odgovori";
            this.btnOdgovori.UseVisualStyleBackColor = true;
            this.btnOdgovori.Click += new System.EventHandler(this.btnOdgovori_Click);
            // 
            // rtxtbOdgovor
            // 
            this.rtxtbOdgovor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxtbOdgovor.Location = new System.Drawing.Point(0, 303);
            this.rtxtbOdgovor.MaxLength = 255;
            this.rtxtbOdgovor.Name = "rtxtbOdgovor";
            this.rtxtbOdgovor.Size = new System.Drawing.Size(746, 71);
            this.rtxtbOdgovor.TabIndex = 1;
            this.rtxtbOdgovor.Text = "";
            // 
            // lblOdgovor
            // 
            this.lblOdgovor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOdgovor.AutoSize = true;
            this.lblOdgovor.Location = new System.Drawing.Point(12, 287);
            this.lblOdgovor.Name = "lblOdgovor";
            this.lblOdgovor.Size = new System.Drawing.Size(51, 13);
            this.lblOdgovor.TabIndex = 3;
            this.lblOdgovor.Text = "Odgovor:";
            // 
            // PitanjaOdgovori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(746, 423);
            this.Controls.Add(this.lblOdgovor);
            this.Controls.Add(this.rtxtbOdgovor);
            this.Controls.Add(this.btnOdgovori);
            this.Controls.Add(this.dgvPitanja);
            this.MinimizeBox = false;
            this.Name = "PitanjaOdgovori";
            this.ShowIcon = false;
            this.Text = "Pitanja i odgovori";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPitanja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPitanja;
        private System.Windows.Forms.Button btnOdgovori;
        private System.Windows.Forms.RichTextBox rtxtbOdgovor;
        private System.Windows.Forms.Label lblOdgovor;
    }
}