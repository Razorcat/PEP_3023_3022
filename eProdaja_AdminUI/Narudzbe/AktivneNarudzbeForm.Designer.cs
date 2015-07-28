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
            this.btnZakljuciNarudzbu = new System.Windows.Forms.Button();
            this.btnOtkaziNarudzbu = new System.Windows.Forms.Button();
            this.proizvodiGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // narudzbeGrid
            // 
            this.narudzbeGrid.AllowUserToAddRows = false;
            this.narudzbeGrid.AllowUserToDeleteRows = false;
            this.narudzbeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.narudzbeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.narudzbeGrid.BackgroundColor = System.Drawing.Color.Pink;
            this.narudzbeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.narudzbeGrid.Location = new System.Drawing.Point(0, 0);
            this.narudzbeGrid.Name = "narudzbeGrid";
            this.narudzbeGrid.ReadOnly = true;
            this.narudzbeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.narudzbeGrid.Size = new System.Drawing.Size(431, 328);
            this.narudzbeGrid.TabIndex = 1;
            this.narudzbeGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.narudzbeGrid_CellClick);
            // 
            // btnZakljuciNarudzbu
            // 
            this.btnZakljuciNarudzbu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZakljuciNarudzbu.BackgroundImage = global::eProdaja_AdminUI.Properties.Resources.linedpapercheck32;
            this.btnZakljuciNarudzbu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnZakljuciNarudzbu.Location = new System.Drawing.Point(666, 334);
            this.btnZakljuciNarudzbu.Name = "btnZakljuciNarudzbu";
            this.btnZakljuciNarudzbu.Size = new System.Drawing.Size(162, 53);
            this.btnZakljuciNarudzbu.TabIndex = 2;
            this.btnZakljuciNarudzbu.Text = "Zaključi narudžbu";
            this.btnZakljuciNarudzbu.UseVisualStyleBackColor = true;
            this.btnZakljuciNarudzbu.Click += new System.EventHandler(this.btnZakljuciNarudzbu_Click);
            // 
            // btnOtkaziNarudzbu
            // 
            this.btnOtkaziNarudzbu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOtkaziNarudzbu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOtkaziNarudzbu.Image = global::eProdaja_AdminUI.Properties.Resources.block32;
            this.btnOtkaziNarudzbu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOtkaziNarudzbu.Location = new System.Drawing.Point(12, 334);
            this.btnOtkaziNarudzbu.Name = "btnOtkaziNarudzbu";
            this.btnOtkaziNarudzbu.Size = new System.Drawing.Size(157, 53);
            this.btnOtkaziNarudzbu.TabIndex = 3;
            this.btnOtkaziNarudzbu.Text = "Otkaži narudžbu";
            this.btnOtkaziNarudzbu.UseVisualStyleBackColor = true;
            this.btnOtkaziNarudzbu.Click += new System.EventHandler(this.btnOtkaziNarudzbu_Click);
            // 
            // proizvodiGrid
            // 
            this.proizvodiGrid.AllowUserToAddRows = false;
            this.proizvodiGrid.AllowUserToDeleteRows = false;
            this.proizvodiGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proizvodiGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.proizvodiGrid.BackgroundColor = System.Drawing.Color.Pink;
            this.proizvodiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proizvodiGrid.Location = new System.Drawing.Point(433, 0);
            this.proizvodiGrid.Name = "proizvodiGrid";
            this.proizvodiGrid.ReadOnly = true;
            this.proizvodiGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.proizvodiGrid.Size = new System.Drawing.Size(407, 328);
            this.proizvodiGrid.TabIndex = 4;
            // 
            // AktivneNarudzbeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(840, 399);
            this.Controls.Add(this.proizvodiGrid);
            this.Controls.Add(this.btnOtkaziNarudzbu);
            this.Controls.Add(this.btnZakljuciNarudzbu);
            this.Controls.Add(this.narudzbeGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AktivneNarudzbeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aktivne narudžbe";
            this.Load += new System.EventHandler(this.AktivneNarudzbeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.narudzbeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView narudzbeGrid;
        private System.Windows.Forms.Button btnZakljuciNarudzbu;
        private System.Windows.Forms.Button btnOtkaziNarudzbu;
        private System.Windows.Forms.DataGridView proizvodiGrid;
    }
}