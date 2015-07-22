namespace eProdaja_AdminUI.NabavkaProizvoda
{
    partial class ProizvodiForm
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
            this.nazivInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sifraInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.proizvodiGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // nazivInput
            // 
            this.nazivInput.Location = new System.Drawing.Point(230, 12);
            this.nazivInput.Name = "nazivInput";
            this.nazivInput.Size = new System.Drawing.Size(257, 20);
            this.nazivInput.TabIndex = 9;
            this.nazivInput.TextChanged += new System.EventHandler(this.nazivInput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(176, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Naziv:";
            // 
            // sifraInput
            // 
            this.sifraInput.Location = new System.Drawing.Point(53, 12);
            this.sifraInput.Name = "sifraInput";
            this.sifraInput.Size = new System.Drawing.Size(100, 20);
            this.sifraInput.TabIndex = 7;
            this.sifraInput.TextChanged += new System.EventHandler(this.sifraInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Šifra:";
            // 
            // proizvodiGrid
            // 
            this.proizvodiGrid.AllowUserToAddRows = false;
            this.proizvodiGrid.AllowUserToDeleteRows = false;
            this.proizvodiGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.proizvodiGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.proizvodiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proizvodiGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.proizvodiGrid.GridColor = System.Drawing.SystemColors.Control;
            this.proizvodiGrid.Location = new System.Drawing.Point(0, 51);
            this.proizvodiGrid.MultiSelect = false;
            this.proizvodiGrid.Name = "proizvodiGrid";
            this.proizvodiGrid.ReadOnly = true;
            this.proizvodiGrid.RowTemplate.Height = 21;
            this.proizvodiGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.proizvodiGrid.Size = new System.Drawing.Size(533, 288);
            this.proizvodiGrid.TabIndex = 5;
            // 
            // ProizvodiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(533, 339);
            this.Controls.Add(this.nazivInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sifraInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.proizvodiGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProizvodiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proizvodi";
            this.Load += new System.EventHandler(this.ProizvodiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nazivInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sifraInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView proizvodiGrid;
    }
}