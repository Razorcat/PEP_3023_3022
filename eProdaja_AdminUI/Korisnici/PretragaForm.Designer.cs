namespace eProdaja_AdminUI.Korisnici
{
    partial class PretragaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PretragaForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imePrezimeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.administracijaToolStrip = new System.Windows.Forms.ToolStrip();
            this.deaktivirajButton = new System.Windows.Forms.ToolStripButton();
            this.izmjeneMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.pristupMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciGrid = new System.Windows.Forms.DataGridView();
            this.administracijaToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // imePrezimeInput
            // 
            this.imePrezimeInput.Location = new System.Drawing.Point(97, 12);
            this.imePrezimeInput.Name = "imePrezimeInput";
            this.imePrezimeInput.Size = new System.Drawing.Size(296, 20);
            this.imePrezimeInput.TabIndex = 3;
            this.imePrezimeInput.TextChanged += new System.EventHandler(this.imePrezimeInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ime i prezime:";
            // 
            // administracijaToolStrip
            // 
            this.administracijaToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.administracijaToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deaktivirajButton,
            this.izmjeneMenu});
            this.administracijaToolStrip.Location = new System.Drawing.Point(0, 46);
            this.administracijaToolStrip.Name = "administracijaToolStrip";
            this.administracijaToolStrip.Size = new System.Drawing.Size(534, 25);
            this.administracijaToolStrip.TabIndex = 5;
            this.administracijaToolStrip.Text = "toolStrip1";
            // 
            // deaktivirajButton
            // 
            this.deaktivirajButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deaktivirajButton.Image = global::eProdaja_AdminUI.Properties.Resources.minus32;
            this.deaktivirajButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deaktivirajButton.Name = "deaktivirajButton";
            this.deaktivirajButton.Size = new System.Drawing.Size(23, 22);
            this.deaktivirajButton.Text = "Deaktiviraj";
            this.deaktivirajButton.Click += new System.EventHandler(this.deaktivirajButton_Click);
            // 
            // izmjeneMenu
            // 
            this.izmjeneMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.izmjeneMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pristupMenu,
            this.updateMenu});
            this.izmjeneMenu.Image = ((System.Drawing.Image)(resources.GetObject("izmjeneMenu.Image")));
            this.izmjeneMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.izmjeneMenu.Name = "izmjeneMenu";
            this.izmjeneMenu.Size = new System.Drawing.Size(61, 22);
            this.izmjeneMenu.Text = "Izmjene";
            // 
            // pristupMenu
            // 
            this.pristupMenu.Name = "pristupMenu";
            this.pristupMenu.Size = new System.Drawing.Size(175, 22);
            this.pristupMenu.Text = "Statusnih podataka";
            this.pristupMenu.Click += new System.EventHandler(this.pristupMenu_Click);
            // 
            // updateMenu
            // 
            this.updateMenu.Name = "updateMenu";
            this.updateMenu.Size = new System.Drawing.Size(175, 22);
            this.updateMenu.Text = "Ličnih podataka";
            this.updateMenu.Click += new System.EventHandler(this.updateMenu_Click);
            // 
            // korisniciGrid
            // 
            this.korisniciGrid.AllowUserToAddRows = false;
            this.korisniciGrid.AllowUserToDeleteRows = false;
            this.korisniciGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.korisniciGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.korisniciGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.korisniciGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.korisniciGrid.Location = new System.Drawing.Point(0, 71);
            this.korisniciGrid.MultiSelect = false;
            this.korisniciGrid.Name = "korisniciGrid";
            this.korisniciGrid.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.korisniciGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.korisniciGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.korisniciGrid.Size = new System.Drawing.Size(534, 303);
            this.korisniciGrid.TabIndex = 4;
            this.korisniciGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.korisniciGrid_CellClick);
            // 
            // PretragaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(534, 374);
            this.Controls.Add(this.administracijaToolStrip);
            this.Controls.Add(this.korisniciGrid);
            this.Controls.Add(this.imePrezimeInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PretragaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracija korisnika";
            this.Load += new System.EventHandler(this.PretragaForm_Load);
            this.administracijaToolStrip.ResumeLayout(false);
            this.administracijaToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox imePrezimeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip administracijaToolStrip;
        private System.Windows.Forms.ToolStripButton deaktivirajButton;
        private System.Windows.Forms.ToolStripDropDownButton izmjeneMenu;
        private System.Windows.Forms.ToolStripMenuItem pristupMenu;
        private System.Windows.Forms.ToolStripMenuItem updateMenu;
        private System.Windows.Forms.DataGridView korisniciGrid;
    }
}