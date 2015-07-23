namespace eProdaja_AdminUI.NabavkaProizvoda
{
    partial class NoviProizvodForm
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
            this.cijenaInput = new System.Windows.Forms.MaskedTextBox();
            this.dodajButton = new System.Windows.Forms.Button();
            this.proizvodiGrid = new System.Windows.Forms.DataGridView();
            this.dodajSlikuButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.slikaInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.jedinicaMjereList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vrstaList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nazivInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sifraInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cijenaInput
            // 
            this.cijenaInput.Location = new System.Drawing.Point(104, 91);
            this.cijenaInput.Mask = "0000.00";
            this.cijenaInput.Name = "cijenaInput";
            this.cijenaInput.Size = new System.Drawing.Size(53, 20);
            this.cijenaInput.TabIndex = 4;
            this.cijenaInput.Validating += new System.ComponentModel.CancelEventHandler(this.cijenaInput_Validating);
            // 
            // dodajButton
            // 
            this.dodajButton.Image = global::eProdaja_AdminUI.Properties.Resources.save_2_32;
            this.dodajButton.Location = new System.Drawing.Point(513, 173);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(98, 43);
            this.dodajButton.TabIndex = 6;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // proizvodiGrid
            // 
            this.proizvodiGrid.AllowUserToAddRows = false;
            this.proizvodiGrid.AllowUserToDeleteRows = false;
            this.proizvodiGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.proizvodiGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.proizvodiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proizvodiGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.proizvodiGrid.Location = new System.Drawing.Point(0, 225);
            this.proizvodiGrid.Name = "proizvodiGrid";
            this.proizvodiGrid.ReadOnly = true;
            this.proizvodiGrid.RowTemplate.Height = 100;
            this.proizvodiGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.proizvodiGrid.Size = new System.Drawing.Size(640, 216);
            this.proizvodiGrid.TabIndex = 7;
            // 
            // dodajSlikuButton
            // 
            this.dodajSlikuButton.Location = new System.Drawing.Point(339, 135);
            this.dodajSlikuButton.Name = "dodajSlikuButton";
            this.dodajSlikuButton.Size = new System.Drawing.Size(96, 23);
            this.dodajSlikuButton.TabIndex = 5;
            this.dodajSlikuButton.Text = "Učitaj sliku";
            this.dodajSlikuButton.UseVisualStyleBackColor = true;
            this.dodajSlikuButton.Click += new System.EventHandler(this.dodajSlikuButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(491, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(120, 100);
            this.pictureBox.TabIndex = 33;
            this.pictureBox.TabStop = false;
            // 
            // slikaInput
            // 
            this.slikaInput.Location = new System.Drawing.Point(104, 137);
            this.slikaInput.Name = "slikaInput";
            this.slikaInput.Size = new System.Drawing.Size(209, 20);
            this.slikaInput.TabIndex = 24;
            this.slikaInput.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(55, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Slika:";
            // 
            // jedinicaMjereList
            // 
            this.jedinicaMjereList.FormattingEnabled = true;
            this.jedinicaMjereList.Location = new System.Drawing.Point(248, 90);
            this.jedinicaMjereList.Name = "jedinicaMjereList";
            this.jedinicaMjereList.Size = new System.Drawing.Size(65, 21);
            this.jedinicaMjereList.TabIndex = 5;
            this.jedinicaMjereList.Validating += new System.ComponentModel.CancelEventHandler(this.jedinicaMjereList_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(179, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Jed. mjere:";
            // 
            // vrstaList
            // 
            this.vrstaList.FormattingEnabled = true;
            this.vrstaList.Location = new System.Drawing.Point(104, 12);
            this.vrstaList.Name = "vrstaList";
            this.vrstaList.Size = new System.Drawing.Size(209, 21);
            this.vrstaList.TabIndex = 1;
            this.vrstaList.SelectedIndexChanged += new System.EventHandler(this.vrstaList_SelectedIndexChanged);
            this.vrstaList.Validating += new System.ComponentModel.CancelEventHandler(this.vrstaList_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(58, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Vrsta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Cijena:";
            // 
            // nazivInput
            // 
            this.nazivInput.Location = new System.Drawing.Point(104, 65);
            this.nazivInput.Name = "nazivInput";
            this.nazivInput.Size = new System.Drawing.Size(209, 20);
            this.nazivInput.TabIndex = 3;
            this.nazivInput.Validating += new System.ComponentModel.CancelEventHandler(this.nazivInput_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Naziv:";
            // 
            // sifraInput
            // 
            this.sifraInput.Location = new System.Drawing.Point(104, 39);
            this.sifraInput.Name = "sifraInput";
            this.sifraInput.Size = new System.Drawing.Size(209, 20);
            this.sifraInput.TabIndex = 2;
            this.sifraInput.Validating += new System.ComponentModel.CancelEventHandler(this.sifraInput_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Šifra proizvoda:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Dodaj novu vrstu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // NoviProizvodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(640, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cijenaInput);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.proizvodiGrid);
            this.Controls.Add(this.dodajSlikuButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.slikaInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.jedinicaMjereList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vrstaList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nazivInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sifraInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NoviProizvodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi proizvod";
            this.Load += new System.EventHandler(this.NoviProizvodForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox cijenaInput;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.DataGridView proizvodiGrid;
        private System.Windows.Forms.Button dodajSlikuButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox slikaInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox jedinicaMjereList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox vrstaList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nazivInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sifraInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}