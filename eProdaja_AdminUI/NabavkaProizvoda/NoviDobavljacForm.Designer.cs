namespace eProdaja_AdminUI.NabavkaProizvoda
{
    partial class NoviDobavljacForm
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtbNapomena = new System.Windows.Forms.RichTextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.mtxtbFax = new System.Windows.Forms.MaskedTextBox();
            this.mtxtbTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtbZiroRacun = new System.Windows.Forms.TextBox();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.txtbWeb = new System.Windows.Forms.TextBox();
            this.txtbAdresa = new System.Windows.Forms.TextBox();
            this.txtbKontaktOsoba = new System.Windows.Forms.TextBox();
            this.txtbNaziv = new System.Windows.Forms.TextBox();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.lblZiroRacun = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblWeb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblKontaktOsoba = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txtbNapomena
            // 
            this.txtbNapomena.Location = new System.Drawing.Point(101, 222);
            this.txtbNapomena.MaxLength = 500;
            this.txtbNapomena.Name = "txtbNapomena";
            this.txtbNapomena.Size = new System.Drawing.Size(146, 57);
            this.txtbNapomena.TabIndex = 29;
            this.txtbNapomena.Text = "";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(253, 222);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 57);
            this.btnSpremi.TabIndex = 28;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // mtxtbFax
            // 
            this.mtxtbFax.Location = new System.Drawing.Point(101, 120);
            this.mtxtbFax.Mask = "(999) 000-000";
            this.mtxtbFax.Name = "mtxtbFax";
            this.mtxtbFax.Size = new System.Drawing.Size(146, 20);
            this.mtxtbFax.TabIndex = 20;
            // 
            // mtxtbTelefon
            // 
            this.mtxtbTelefon.Location = new System.Drawing.Point(101, 94);
            this.mtxtbTelefon.Mask = "(999) 000-000";
            this.mtxtbTelefon.Name = "mtxtbTelefon";
            this.mtxtbTelefon.Size = new System.Drawing.Size(146, 20);
            this.mtxtbTelefon.TabIndex = 17;
            this.mtxtbTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.mtxtbTelefon_Validating);
            // 
            // txtbZiroRacun
            // 
            this.txtbZiroRacun.Location = new System.Drawing.Point(101, 195);
            this.txtbZiroRacun.MaxLength = 55;
            this.txtbZiroRacun.Name = "txtbZiroRacun";
            this.txtbZiroRacun.Size = new System.Drawing.Size(146, 20);
            this.txtbZiroRacun.TabIndex = 26;
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(101, 169);
            this.txtbEmail.MaxLength = 55;
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(146, 20);
            this.txtbEmail.TabIndex = 24;
            // 
            // txtbWeb
            // 
            this.txtbWeb.Location = new System.Drawing.Point(101, 145);
            this.txtbWeb.MaxLength = 55;
            this.txtbWeb.Name = "txtbWeb";
            this.txtbWeb.Size = new System.Drawing.Size(146, 20);
            this.txtbWeb.TabIndex = 22;
            // 
            // txtbAdresa
            // 
            this.txtbAdresa.Location = new System.Drawing.Point(101, 67);
            this.txtbAdresa.MaxLength = 55;
            this.txtbAdresa.Name = "txtbAdresa";
            this.txtbAdresa.Size = new System.Drawing.Size(146, 20);
            this.txtbAdresa.TabIndex = 16;
            this.txtbAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.txtbAdresa_Validating);
            // 
            // txtbKontaktOsoba
            // 
            this.txtbKontaktOsoba.Location = new System.Drawing.Point(101, 40);
            this.txtbKontaktOsoba.MaxLength = 55;
            this.txtbKontaktOsoba.Name = "txtbKontaktOsoba";
            this.txtbKontaktOsoba.Size = new System.Drawing.Size(146, 20);
            this.txtbKontaktOsoba.TabIndex = 13;
            // 
            // txtbNaziv
            // 
            this.txtbNaziv.Location = new System.Drawing.Point(101, 12);
            this.txtbNaziv.MaxLength = 55;
            this.txtbNaziv.Name = "txtbNaziv";
            this.txtbNaziv.Size = new System.Drawing.Size(146, 20);
            this.txtbNaziv.TabIndex = 11;
            this.txtbNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtbNaziv_Validating);
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Location = new System.Drawing.Point(13, 224);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(65, 13);
            this.lblNapomena.TabIndex = 27;
            this.lblNapomena.Text = "Napomena :";
            // 
            // lblZiroRacun
            // 
            this.lblZiroRacun.AutoSize = true;
            this.lblZiroRacun.Location = new System.Drawing.Point(14, 198);
            this.lblZiroRacun.Name = "lblZiroRacun";
            this.lblZiroRacun.Size = new System.Drawing.Size(61, 13);
            this.lblZiroRacun.TabIndex = 25;
            this.lblZiroRacun.Text = "Žiro račun :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(13, 172);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 23;
            this.lblEmail.Text = "Email :";
            // 
            // lblWeb
            // 
            this.lblWeb.AutoSize = true;
            this.lblWeb.Location = new System.Drawing.Point(13, 148);
            this.lblWeb.Name = "lblWeb";
            this.lblWeb.Size = new System.Drawing.Size(36, 13);
            this.lblWeb.TabIndex = 21;
            this.lblWeb.Text = "Web :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Fax :";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(14, 97);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(49, 13);
            this.lblTelefon.TabIndex = 18;
            this.lblTelefon.Text = "Telefon :";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(13, 70);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(46, 13);
            this.lblAdresa.TabIndex = 15;
            this.lblAdresa.Text = "Adresa :";
            // 
            // lblKontaktOsoba
            // 
            this.lblKontaktOsoba.AutoSize = true;
            this.lblKontaktOsoba.Location = new System.Drawing.Point(13, 43);
            this.lblKontaktOsoba.Name = "lblKontaktOsoba";
            this.lblKontaktOsoba.Size = new System.Drawing.Size(82, 13);
            this.lblKontaktOsoba.TabIndex = 14;
            this.lblKontaktOsoba.Text = "Kontakt osoba :";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(14, 15);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(40, 13);
            this.lblNaziv.TabIndex = 12;
            this.lblNaziv.Text = "Naziv :";
            // 
            // NoviDobavljacForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(336, 287);
            this.Controls.Add(this.txtbNapomena);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.mtxtbFax);
            this.Controls.Add(this.mtxtbTelefon);
            this.Controls.Add(this.txtbZiroRacun);
            this.Controls.Add(this.txtbEmail);
            this.Controls.Add(this.txtbWeb);
            this.Controls.Add(this.txtbAdresa);
            this.Controls.Add(this.txtbKontaktOsoba);
            this.Controls.Add(this.txtbNaziv);
            this.Controls.Add(this.lblNapomena);
            this.Controls.Add(this.lblZiroRacun);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblWeb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblKontaktOsoba);
            this.Controls.Add(this.lblNaziv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoviDobavljacForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Novi dobavljač";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.RichTextBox txtbNapomena;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.MaskedTextBox mtxtbFax;
        private System.Windows.Forms.MaskedTextBox mtxtbTelefon;
        private System.Windows.Forms.TextBox txtbZiroRacun;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.TextBox txtbWeb;
        private System.Windows.Forms.TextBox txtbAdresa;
        private System.Windows.Forms.TextBox txtbKontaktOsoba;
        private System.Windows.Forms.TextBox txtbNaziv;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.Label lblZiroRacun;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblWeb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblKontaktOsoba;
        private System.Windows.Forms.Label lblNaziv;
    }
}