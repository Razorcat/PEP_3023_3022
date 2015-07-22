namespace eProdaja_AdminUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviKorisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ulazRobeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proizvodiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviProizvodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nabavkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brošureToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazBrošuraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajProizvodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaBrošuraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvještajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.korisnikLabel = new System.Windows.Forms.ToolStripLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightPink;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciToolStripMenuItem,
            this.ulazRobeToolStripMenuItem,
            this.izvještajiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(722, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noviKorisnikToolStripMenuItem,
            this.administracijaToolStripMenuItem});
            this.korisniciToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.korisniciToolStripMenuItem.Image = global::eProdaja_AdminUI.Properties.Resources.users32;
            this.korisniciToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(113, 36);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // noviKorisnikToolStripMenuItem
            // 
            this.noviKorisnikToolStripMenuItem.Image = global::eProdaja_AdminUI.Properties.Resources.usersplus32;
            this.noviKorisnikToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.noviKorisnikToolStripMenuItem.Name = "noviKorisnikToolStripMenuItem";
            this.noviKorisnikToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.noviKorisnikToolStripMenuItem.Text = "Novi korisnik";
            this.noviKorisnikToolStripMenuItem.Click += new System.EventHandler(this.noviKorisnikToolStripMenuItem_Click);
            // 
            // administracijaToolStripMenuItem
            // 
            this.administracijaToolStripMenuItem.Image = global::eProdaja_AdminUI.Properties.Resources.wrench32;
            this.administracijaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.administracijaToolStripMenuItem.Name = "administracijaToolStripMenuItem";
            this.administracijaToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.administracijaToolStripMenuItem.Text = "Administracija";
            this.administracijaToolStripMenuItem.Click += new System.EventHandler(this.administracijaToolStripMenuItem_Click);
            // 
            // ulazRobeToolStripMenuItem
            // 
            this.ulazRobeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proizvodiToolStripMenuItem,
            this.nabavkaToolStripMenuItem,
            this.brošureToolStripMenuItem1});
            this.ulazRobeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ulazRobeToolStripMenuItem.Image = global::eProdaja_AdminUI.Properties.Resources.linedpaper32;
            this.ulazRobeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ulazRobeToolStripMenuItem.Name = "ulazRobeToolStripMenuItem";
            this.ulazRobeToolStripMenuItem.Size = new System.Drawing.Size(121, 36);
            this.ulazRobeToolStripMenuItem.Text = "Ulaz robe";
            // 
            // proizvodiToolStripMenuItem
            // 
            this.proizvodiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noviProizvodToolStripMenuItem,
            this.pretragaPToolStripMenuItem,
            this.toolStripMenuItem1});
            this.proizvodiToolStripMenuItem.Image = global::eProdaja_AdminUI.Properties.Resources.box32;
            this.proizvodiToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.proizvodiToolStripMenuItem.Name = "proizvodiToolStripMenuItem";
            this.proizvodiToolStripMenuItem.Size = new System.Drawing.Size(161, 38);
            this.proizvodiToolStripMenuItem.Text = "Proizvodi";
            // 
            // noviProizvodToolStripMenuItem
            // 
            this.noviProizvodToolStripMenuItem.Image = global::eProdaja_AdminUI.Properties.Resources.plus32;
            this.noviProizvodToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.noviProizvodToolStripMenuItem.Name = "noviProizvodToolStripMenuItem";
            this.noviProizvodToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
            this.noviProizvodToolStripMenuItem.Text = "Novi proizvod";
            this.noviProizvodToolStripMenuItem.Click += new System.EventHandler(this.noviProizvodToolStripMenuItem_Click);
            // 
            // pretragaPToolStripMenuItem
            // 
            this.pretragaPToolStripMenuItem.Image = global::eProdaja_AdminUI.Properties.Resources.search32;
            this.pretragaPToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pretragaPToolStripMenuItem.Name = "pretragaPToolStripMenuItem";
            this.pretragaPToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
            this.pretragaPToolStripMenuItem.Text = "Pretraga";
            this.pretragaPToolStripMenuItem.Click += new System.EventHandler(this.pretragaPToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::eProdaja_AdminUI.Properties.Resources.linedpaperpencil32;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(203, 38);
            this.toolStripMenuItem1.Text = "Stanje skladišta";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // nabavkaToolStripMenuItem
            // 
            this.nabavkaToolStripMenuItem.Image = global::eProdaja_AdminUI.Properties.Resources.shoppingcart321;
            this.nabavkaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nabavkaToolStripMenuItem.Name = "nabavkaToolStripMenuItem";
            this.nabavkaToolStripMenuItem.Size = new System.Drawing.Size(161, 38);
            this.nabavkaToolStripMenuItem.Text = "Nabavka";
            this.nabavkaToolStripMenuItem.Click += new System.EventHandler(this.nabavkaToolStripMenuItem_Click);
            // 
            // brošureToolStripMenuItem1
            // 
            this.brošureToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikazBrošuraToolStripMenuItem,
            this.dodajProizvodeToolStripMenuItem,
            this.novaBrošuraToolStripMenuItem});
            this.brošureToolStripMenuItem1.Image = global::eProdaja_AdminUI.Properties.Resources.linedpaper322;
            this.brošureToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.brošureToolStripMenuItem1.Name = "brošureToolStripMenuItem1";
            this.brošureToolStripMenuItem1.Size = new System.Drawing.Size(161, 38);
            this.brošureToolStripMenuItem1.Text = "Brošure";
            this.brošureToolStripMenuItem1.Click += new System.EventHandler(this.brošureToolStripMenuItem1_Click);
            // 
            // prikazBrošuraToolStripMenuItem
            // 
            this.prikazBrošuraToolStripMenuItem.Image = global::eProdaja_AdminUI.Properties.Resources.article321;
            this.prikazBrošuraToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.prikazBrošuraToolStripMenuItem.Name = "prikazBrošuraToolStripMenuItem";
            this.prikazBrošuraToolStripMenuItem.Size = new System.Drawing.Size(211, 38);
            this.prikazBrošuraToolStripMenuItem.Text = "Prikaz brošura";
            this.prikazBrošuraToolStripMenuItem.Click += new System.EventHandler(this.prikazBrošuraToolStripMenuItem_Click);
            // 
            // dodajProizvodeToolStripMenuItem
            // 
            this.dodajProizvodeToolStripMenuItem.Image = global::eProdaja_AdminUI.Properties.Resources.paperpencil321;
            this.dodajProizvodeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dodajProizvodeToolStripMenuItem.Name = "dodajProizvodeToolStripMenuItem";
            this.dodajProizvodeToolStripMenuItem.Size = new System.Drawing.Size(211, 38);
            this.dodajProizvodeToolStripMenuItem.Text = "Dodaj proizvode";
            this.dodajProizvodeToolStripMenuItem.Click += new System.EventHandler(this.dodajProizvodeToolStripMenuItem_Click);
            // 
            // novaBrošuraToolStripMenuItem
            // 
            this.novaBrošuraToolStripMenuItem.Image = global::eProdaja_AdminUI.Properties.Resources.paperplus325;
            this.novaBrošuraToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.novaBrošuraToolStripMenuItem.Name = "novaBrošuraToolStripMenuItem";
            this.novaBrošuraToolStripMenuItem.Size = new System.Drawing.Size(211, 38);
            this.novaBrošuraToolStripMenuItem.Text = "Nova brošura";
            this.novaBrošuraToolStripMenuItem.Click += new System.EventHandler(this.novaBrošuraToolStripMenuItem_Click);
            // 
            // izvještajiToolStripMenuItem
            // 
            this.izvještajiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prodajaToolStripMenuItem});
            this.izvještajiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izvještajiToolStripMenuItem.Image = global::eProdaja_AdminUI.Properties.Resources.bargraph32;
            this.izvještajiToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.izvještajiToolStripMenuItem.Name = "izvještajiToolStripMenuItem";
            this.izvještajiToolStripMenuItem.Size = new System.Drawing.Size(113, 36);
            this.izvještajiToolStripMenuItem.Text = "Izvještaji";
            // 
            // prodajaToolStripMenuItem
            // 
            this.prodajaToolStripMenuItem.Image = global::eProdaja_AdminUI.Properties.Resources.boxupload32;
            this.prodajaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.prodajaToolStripMenuItem.Name = "prodajaToolStripMenuItem";
            this.prodajaToolStripMenuItem.Size = new System.Drawing.Size(151, 38);
            this.prodajaToolStripMenuItem.Text = "Prodaja";
            this.prodajaToolStripMenuItem.Click += new System.EventHandler(this.prodajaToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisnikLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 486);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(722, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // korisnikLabel
            // 
            this.korisnikLabel.Name = "korisnikLabel";
            this.korisnikLabel.Size = new System.Drawing.Size(69, 22);
            this.korisnikLabel.Text = "ImePrezime";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            this.notifyIcon.BalloonTipClicked += new System.EventHandler(this.notifyIcon_BalloonTipClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::eProdaja_AdminUI.Properties.Resources._99;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(722, 511);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "E-prodaja";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviKorisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel korisnikLabel;
        private System.Windows.Forms.ToolStripMenuItem administracijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ulazRobeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proizvodiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviProizvodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nabavkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem izvještajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prodajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brošureToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prikazBrošuraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajProizvodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaBrošuraToolStripMenuItem;
    }
}

