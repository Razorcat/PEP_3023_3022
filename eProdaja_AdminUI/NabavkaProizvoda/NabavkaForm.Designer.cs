﻿namespace eProdaja_AdminUI.NabavkaProizvoda
{
    partial class NabavkaForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBrisiStavku = new System.Windows.Forms.Button();
            this.zakljuciButton = new System.Windows.Forms.Button();
            this.stavkeGrid = new System.Windows.Forms.DataGridView();
            this.ProizvodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proizvodi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dodajStavkuButton = new System.Windows.Forms.Button();
            this.cijenaInput = new System.Windows.Forms.MaskedTextBox();
            this.kolicinaInput = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.sifraPInput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pdvInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.iznosRacunaInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.napomenaInput = new System.Windows.Forms.RichTextBox();
            this.datumDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.brojFaktureInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.skladisteList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pretragaDButton = new System.Windows.Forms.Button();
            this.telefonDInput = new System.Windows.Forms.TextBox();
            this.kontaktDInput = new System.Windows.Forms.TextBox();
            this.nazivDInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBrisiStavku);
            this.groupBox3.Controls.Add(this.zakljuciButton);
            this.groupBox3.Controls.Add(this.stavkeGrid);
            this.groupBox3.Controls.Add(this.dodajStavkuButton);
            this.groupBox3.Controls.Add(this.cijenaInput);
            this.groupBox3.Controls.Add(this.kolicinaInput);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.sifraPInput);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(254, 214);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(692, 243);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stavke";
            // 
            // btnBrisiStavku
            // 
            this.btnBrisiStavku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBrisiStavku.ForeColor = System.Drawing.Color.Black;
            this.btnBrisiStavku.Image = global::eProdaja_AdminUI.Properties.Resources.linedpaperminus32;
            this.btnBrisiStavku.Location = new System.Drawing.Point(225, 180);
            this.btnBrisiStavku.Name = "btnBrisiStavku";
            this.btnBrisiStavku.Size = new System.Drawing.Size(100, 47);
            this.btnBrisiStavku.TabIndex = 12;
            this.btnBrisiStavku.Text = "Briši stavku";
            this.btnBrisiStavku.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrisiStavku.UseVisualStyleBackColor = true;
            this.btnBrisiStavku.Click += new System.EventHandler(this.btnBrisiStavku_Click);
            // 
            // zakljuciButton
            // 
            this.zakljuciButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zakljuciButton.ForeColor = System.Drawing.Color.Black;
            this.zakljuciButton.Image = global::eProdaja_AdminUI.Properties.Resources.save_2_32;
            this.zakljuciButton.Location = new System.Drawing.Point(543, 180);
            this.zakljuciButton.Name = "zakljuciButton";
            this.zakljuciButton.Size = new System.Drawing.Size(100, 47);
            this.zakljuciButton.TabIndex = 10;
            this.zakljuciButton.Text = "Zaključi";
            this.zakljuciButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.zakljuciButton.UseVisualStyleBackColor = true;
            this.zakljuciButton.Click += new System.EventHandler(this.zakljuciButton_Click);
            // 
            // stavkeGrid
            // 
            this.stavkeGrid.AllowUserToAddRows = false;
            this.stavkeGrid.AllowUserToDeleteRows = false;
            this.stavkeGrid.AllowUserToOrderColumns = true;
            this.stavkeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stavkeGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.stavkeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stavkeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProizvodID,
            this.Proizvodi,
            this.Kolicina,
            this.Cijena});
            this.stavkeGrid.GridColor = System.Drawing.SystemColors.Control;
            this.stavkeGrid.Location = new System.Drawing.Point(225, 23);
            this.stavkeGrid.Name = "stavkeGrid";
            this.stavkeGrid.ReadOnly = true;
            this.stavkeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stavkeGrid.Size = new System.Drawing.Size(418, 133);
            this.stavkeGrid.TabIndex = 0;
            this.stavkeGrid.TabStop = false;
            this.stavkeGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stavkeGrid_CellClick);
            // 
            // ProizvodID
            // 
            this.ProizvodID.DataPropertyName = "ProizvodID";
            this.ProizvodID.HeaderText = "ProizvodID";
            this.ProizvodID.Name = "ProizvodID";
            this.ProizvodID.ReadOnly = true;
            this.ProizvodID.Visible = false;
            // 
            // Proizvodi
            // 
            this.Proizvodi.DataPropertyName = "Proizvodi";
            this.Proizvodi.HeaderText = "Proizvod";
            this.Proizvodi.Name = "Proizvodi";
            this.Proizvodi.ReadOnly = true;
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Kolicina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // dodajStavkuButton
            // 
            this.dodajStavkuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajStavkuButton.ForeColor = System.Drawing.Color.Black;
            this.dodajStavkuButton.Location = new System.Drawing.Point(103, 126);
            this.dodajStavkuButton.Name = "dodajStavkuButton";
            this.dodajStavkuButton.Size = new System.Drawing.Size(87, 30);
            this.dodajStavkuButton.TabIndex = 9;
            this.dodajStavkuButton.Text = "Dodaj";
            this.dodajStavkuButton.UseVisualStyleBackColor = true;
            this.dodajStavkuButton.Click += new System.EventHandler(this.dodajStavkuButton_Click);
            // 
            // cijenaInput
            // 
            this.cijenaInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cijenaInput.Location = new System.Drawing.Point(103, 86);
            this.cijenaInput.Mask = "0000.00";
            this.cijenaInput.Name = "cijenaInput";
            this.cijenaInput.Size = new System.Drawing.Size(87, 21);
            this.cijenaInput.TabIndex = 8;
            this.cijenaInput.Text = "000000";
            this.cijenaInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cijenaInput_KeyPress);
            // 
            // kolicinaInput
            // 
            this.kolicinaInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kolicinaInput.Location = new System.Drawing.Point(103, 57);
            this.kolicinaInput.Mask = "000";
            this.kolicinaInput.Name = "kolicinaInput";
            this.kolicinaInput.Size = new System.Drawing.Size(87, 21);
            this.kolicinaInput.TabIndex = 7;
            this.kolicinaInput.Text = "000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(15, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Cijena:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(15, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Količina:";
            // 
            // sifraPInput
            // 
            this.sifraPInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sifraPInput.Location = new System.Drawing.Point(103, 23);
            this.sifraPInput.Name = "sifraPInput";
            this.sifraPInput.Size = new System.Drawing.Size(87, 21);
            this.sifraPInput.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(15, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Šifra proizvoda:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pdvInput);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.iznosRacunaInput);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.napomenaInput);
            this.groupBox2.Controls.Add(this.datumDatePicker);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.brojFaktureInput);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.skladisteList);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(479, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(620, 161);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ulazna faktura";
            // 
            // pdvInput
            // 
            this.pdvInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pdvInput.Location = new System.Drawing.Point(233, 123);
            this.pdvInput.Name = "pdvInput";
            this.pdvInput.ReadOnly = true;
            this.pdvInput.Size = new System.Drawing.Size(87, 21);
            this.pdvInput.TabIndex = 0;
            this.pdvInput.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(194, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "PDV:";
            // 
            // iznosRacunaInput
            // 
            this.iznosRacunaInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iznosRacunaInput.Location = new System.Drawing.Point(103, 123);
            this.iznosRacunaInput.Name = "iznosRacunaInput";
            this.iznosRacunaInput.ReadOnly = true;
            this.iznosRacunaInput.Size = new System.Drawing.Size(87, 21);
            this.iznosRacunaInput.TabIndex = 0;
            this.iznosRacunaInput.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(15, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Iznos računa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(333, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Napomena:";
            // 
            // napomenaInput
            // 
            this.napomenaInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.napomenaInput.Location = new System.Drawing.Point(401, 24);
            this.napomenaInput.Name = "napomenaInput";
            this.napomenaInput.Size = new System.Drawing.Size(202, 119);
            this.napomenaInput.TabIndex = 5;
            this.napomenaInput.Text = "";
            // 
            // datumDatePicker
            // 
            this.datumDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datumDatePicker.Location = new System.Drawing.Point(103, 88);
            this.datumDatePicker.Name = "datumDatePicker";
            this.datumDatePicker.Size = new System.Drawing.Size(217, 21);
            this.datumDatePicker.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(15, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Datum:";
            // 
            // brojFaktureInput
            // 
            this.brojFaktureInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.brojFaktureInput.Location = new System.Drawing.Point(103, 55);
            this.brojFaktureInput.Name = "brojFaktureInput";
            this.brojFaktureInput.ReadOnly = true;
            this.brojFaktureInput.Size = new System.Drawing.Size(217, 21);
            this.brojFaktureInput.TabIndex = 3;
            this.brojFaktureInput.Validating += new System.ComponentModel.CancelEventHandler(this.brojFaktureInput_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(15, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Broj fakture:";
            // 
            // skladisteList
            // 
            this.skladisteList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.skladisteList.FormattingEnabled = true;
            this.skladisteList.Location = new System.Drawing.Point(103, 24);
            this.skladisteList.Name = "skladisteList";
            this.skladisteList.Size = new System.Drawing.Size(217, 23);
            this.skladisteList.TabIndex = 2;
            this.skladisteList.Validating += new System.ComponentModel.CancelEventHandler(this.skladisteList_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(15, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Skladište:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pretragaDButton);
            this.groupBox1.Controls.Add(this.telefonDInput);
            this.groupBox1.Controls.Add(this.kontaktDInput);
            this.groupBox1.Controls.Add(this.nazivDInput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(11, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 161);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dobavljač";
            // 
            // pretragaDButton
            // 
            this.pretragaDButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pretragaDButton.ForeColor = System.Drawing.Color.Black;
            this.pretragaDButton.Image = global::eProdaja_AdminUI.Properties.Resources.search32;
            this.pretragaDButton.Location = new System.Drawing.Point(336, 108);
            this.pretragaDButton.Name = "pretragaDButton";
            this.pretragaDButton.Size = new System.Drawing.Size(111, 47);
            this.pretragaDButton.TabIndex = 1;
            this.pretragaDButton.Text = "Pretraga";
            this.pretragaDButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pretragaDButton.UseVisualStyleBackColor = true;
            this.pretragaDButton.Click += new System.EventHandler(this.pretragaDButton_Click);
            // 
            // telefonDInput
            // 
            this.telefonDInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.telefonDInput.Location = new System.Drawing.Point(103, 77);
            this.telefonDInput.Name = "telefonDInput";
            this.telefonDInput.ReadOnly = true;
            this.telefonDInput.Size = new System.Drawing.Size(217, 21);
            this.telefonDInput.TabIndex = 0;
            this.telefonDInput.TabStop = false;
            // 
            // kontaktDInput
            // 
            this.kontaktDInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kontaktDInput.Location = new System.Drawing.Point(103, 48);
            this.kontaktDInput.Name = "kontaktDInput";
            this.kontaktDInput.ReadOnly = true;
            this.kontaktDInput.Size = new System.Drawing.Size(217, 21);
            this.kontaktDInput.TabIndex = 0;
            this.kontaktDInput.TabStop = false;
            // 
            // nazivDInput
            // 
            this.nazivDInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazivDInput.Location = new System.Drawing.Point(103, 19);
            this.nazivDInput.Name = "nazivDInput";
            this.nazivDInput.ReadOnly = true;
            this.nazivDInput.Size = new System.Drawing.Size(217, 21);
            this.nazivDInput.TabIndex = 0;
            this.nazivDInput.TabStop = false;
            this.nazivDInput.Validating += new System.ComponentModel.CancelEventHandler(this.nazivDInput_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(15, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kontakt osoba:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // NabavkaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1122, 490);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NabavkaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nabavka proizvoda";
            this.Load += new System.EventHandler(this.NabavkaForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button zakljuciButton;
        private System.Windows.Forms.DataGridView stavkeGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProizvodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proizvodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.Button dodajStavkuButton;
        private System.Windows.Forms.MaskedTextBox cijenaInput;
        private System.Windows.Forms.MaskedTextBox kolicinaInput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox sifraPInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox pdvInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox iznosRacunaInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox napomenaInput;
        private System.Windows.Forms.DateTimePicker datumDatePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox brojFaktureInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox skladisteList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button pretragaDButton;
        private System.Windows.Forms.TextBox telefonDInput;
        private System.Windows.Forms.TextBox kontaktDInput;
        private System.Windows.Forms.TextBox nazivDInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnBrisiStavku;
    }
}