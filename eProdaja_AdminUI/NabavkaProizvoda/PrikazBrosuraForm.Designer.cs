namespace eProdaja_AdminUI.NabavkaProizvoda
{
    partial class PrikazBrosuraForm
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
            this.brosuraList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.proizvodiGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // brosuraList
            // 
            this.brosuraList.FormattingEnabled = true;
            this.brosuraList.Location = new System.Drawing.Point(99, 28);
            this.brosuraList.Name = "brosuraList";
            this.brosuraList.Size = new System.Drawing.Size(203, 21);
            this.brosuraList.TabIndex = 0;
            this.brosuraList.SelectedIndexChanged += new System.EventHandler(this.brosuraList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Brošura:";
            // 
            // proizvodiGrid
            // 
            this.proizvodiGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proizvodiGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.proizvodiGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.proizvodiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proizvodiGrid.Location = new System.Drawing.Point(37, 65);
            this.proizvodiGrid.Name = "proizvodiGrid";
            this.proizvodiGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.proizvodiGrid.Size = new System.Drawing.Size(860, 437);
            this.proizvodiGrid.TabIndex = 2;
            // 
            // PrikazBrosuraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(926, 514);
            this.Controls.Add(this.proizvodiGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brosuraList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrikazBrosuraForm";
            this.ShowIcon = false;
            this.Text = "Brošure";
            this.Load += new System.EventHandler(this.PrikazBrosuraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox brosuraList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView proizvodiGrid;
    }
}