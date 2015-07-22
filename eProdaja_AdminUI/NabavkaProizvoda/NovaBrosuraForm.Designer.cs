namespace eProdaja_AdminUI.NabavkaProizvoda
{
    partial class NovaBrosuraForm
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
            this.nazivInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datumIsteka = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.datumPTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datumITimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // nazivInput
            // 
            this.nazivInput.Location = new System.Drawing.Point(137, 26);
            this.nazivInput.Name = "nazivInput";
            this.nazivInput.Size = new System.Drawing.Size(200, 20);
            this.nazivInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(38, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Datum početka:";
            // 
            // datumIsteka
            // 
            this.datumIsteka.AutoSize = true;
            this.datumIsteka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datumIsteka.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datumIsteka.Location = new System.Drawing.Point(40, 116);
            this.datumIsteka.Name = "datumIsteka";
            this.datumIsteka.Size = new System.Drawing.Size(85, 13);
            this.datumIsteka.TabIndex = 6;
            this.datumIsteka.Text = "Datum isteka:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Image = global::eProdaja_AdminUI.Properties.Resources.paperplus323;
            this.btnDodaj.Location = new System.Drawing.Point(271, 163);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(66, 44);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // datumPTimePicker
            // 
            this.datumPTimePicker.Location = new System.Drawing.Point(137, 72);
            this.datumPTimePicker.Name = "datumPTimePicker";
            this.datumPTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datumPTimePicker.TabIndex = 7;
            // 
            // datumITimePicker1
            // 
            this.datumITimePicker1.Location = new System.Drawing.Point(137, 110);
            this.datumITimePicker1.Name = "datumITimePicker1";
            this.datumITimePicker1.Size = new System.Drawing.Size(200, 20);
            this.datumITimePicker1.TabIndex = 8;
            // 
            // NovaBrosuraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(390, 248);
            this.Controls.Add(this.datumITimePicker1);
            this.Controls.Add(this.datumPTimePicker);
            this.Controls.Add(this.datumIsteka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.nazivInput);
            this.Controls.Add(this.label1);
            this.Name = "NovaBrosuraForm";
            this.Text = "Nova brošura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nazivInput;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label datumIsteka;
        private System.Windows.Forms.DateTimePicker datumPTimePicker;
        private System.Windows.Forms.DateTimePicker datumITimePicker1;
    }
}