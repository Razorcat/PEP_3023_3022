namespace eProdaja_AdminUI.NabavkaProizvoda
{
    partial class StanjeSkladistaForm
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
            this.skladisteList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.proizvodiGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // skladisteList
            // 
            this.skladisteList.FormattingEnabled = true;
            this.skladisteList.Location = new System.Drawing.Point(73, 18);
            this.skladisteList.Name = "skladisteList";
            this.skladisteList.Size = new System.Drawing.Size(209, 21);
            this.skladisteList.TabIndex = 17;
            this.skladisteList.SelectedIndexChanged += new System.EventHandler(this.skladisteList_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Skladište:";
            // 
            // proizvodiGrid
            // 
            this.proizvodiGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.proizvodiGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.proizvodiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proizvodiGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.proizvodiGrid.Location = new System.Drawing.Point(0, 55);
            this.proizvodiGrid.Name = "proizvodiGrid";
            this.proizvodiGrid.RowTemplate.Height = 100;
            this.proizvodiGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.proizvodiGrid.Size = new System.Drawing.Size(550, 408);
            this.proizvodiGrid.TabIndex = 16;
            // 
            // StanjeSkladistaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(550, 463);
            this.Controls.Add(this.skladisteList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.proizvodiGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StanjeSkladistaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stanje skladišta";
            this.Load += new System.EventHandler(this.StanjeSkladistaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox skladisteList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView proizvodiGrid;
    }
}