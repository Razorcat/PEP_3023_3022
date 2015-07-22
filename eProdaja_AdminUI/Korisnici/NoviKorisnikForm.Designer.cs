namespace eProdaja_AdminUI.Korisnici
{
    partial class NoviKorisnikForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.telefonInput = new System.Windows.Forms.MaskedTextBox();
            this.lozinkaInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.korisnickoImeInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dodajButton = new System.Windows.Forms.Button();
            this.ulogeList = new System.Windows.Forms.CheckedListBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prezimeInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pristupPanel = new System.Windows.Forms.Panel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pristupPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Uloge:";
            // 
            // telefonInput
            // 
            this.telefonInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.telefonInput.Location = new System.Drawing.Point(125, 104);
            this.telefonInput.Mask = "(999) 000-000";
            this.telefonInput.Name = "telefonInput";
            this.telefonInput.Size = new System.Drawing.Size(227, 20);
            this.telefonInput.TabIndex = 4;
            // 
            // lozinkaInput
            // 
            this.lozinkaInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lozinkaInput.Location = new System.Drawing.Point(111, 41);
            this.lozinkaInput.Name = "lozinkaInput";
            this.lozinkaInput.PasswordChar = '*';
            this.lozinkaInput.Size = new System.Drawing.Size(227, 20);
            this.lozinkaInput.TabIndex = 6;
            this.lozinkaInput.Validating += new System.ComponentModel.CancelEventHandler(this.lozinkaInput_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Lozinka:";
            // 
            // korisnickoImeInput
            // 
            this.korisnickoImeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.korisnickoImeInput.Location = new System.Drawing.Point(111, 15);
            this.korisnickoImeInput.Name = "korisnickoImeInput";
            this.korisnickoImeInput.Size = new System.Drawing.Size(227, 20);
            this.korisnickoImeInput.TabIndex = 5;
            this.korisnickoImeInput.Validating += new System.ComponentModel.CancelEventHandler(this.korisnickoImeInput_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Korisničko ime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(58, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Telefon:";
            // 
            // dodajButton
            // 
            this.dodajButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajButton.ForeColor = System.Drawing.Color.Black;
            this.errorProvider.SetIconAlignment(this.dodajButton, System.Windows.Forms.ErrorIconAlignment.BottomRight);
            this.dodajButton.Image = global::eProdaja_AdminUI.Properties.Resources.userplus32;
            this.dodajButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dodajButton.Location = new System.Drawing.Point(238, 254);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(114, 43);
            this.dodajButton.TabIndex = 8;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dodajButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // ulogeList
            // 
            this.ulogeList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ulogeList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ulogeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ulogeList.FormattingEnabled = true;
            this.ulogeList.Location = new System.Drawing.Point(111, 67);
            this.ulogeList.Name = "ulogeList";
            this.ulogeList.Size = new System.Drawing.Size(227, 32);
            this.ulogeList.TabIndex = 7;
            this.ulogeList.Validating += new System.ComponentModel.CancelEventHandler(this.ulogeList_Validating);
            // 
            // emailInput
            // 
            this.emailInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailInput.Location = new System.Drawing.Point(125, 75);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(227, 20);
            this.emailInput.TabIndex = 3;
            this.emailInput.Validating += new System.ComponentModel.CancelEventHandler(this.emailInput_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(68, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "E-mail:";
            // 
            // prezimeInput
            // 
            this.prezimeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prezimeInput.Location = new System.Drawing.Point(125, 49);
            this.prezimeInput.Name = "prezimeInput";
            this.prezimeInput.Size = new System.Drawing.Size(227, 20);
            this.prezimeInput.TabIndex = 2;
            this.prezimeInput.Validating += new System.ComponentModel.CancelEventHandler(this.prezimeInput_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Prezime:";
            // 
            // imeInput
            // 
            this.imeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imeInput.Location = new System.Drawing.Point(125, 23);
            this.imeInput.Name = "imeInput";
            this.imeInput.Size = new System.Drawing.Size(227, 20);
            this.imeInput.TabIndex = 1;
            this.imeInput.Validating += new System.ComponentModel.CancelEventHandler(this.imeInput_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ime:";
            // 
            // pristupPanel
            // 
            this.pristupPanel.Controls.Add(this.lozinkaInput);
            this.pristupPanel.Controls.Add(this.label7);
            this.pristupPanel.Controls.Add(this.ulogeList);
            this.pristupPanel.Controls.Add(this.label5);
            this.pristupPanel.Controls.Add(this.korisnickoImeInput);
            this.pristupPanel.Controls.Add(this.label6);
            this.pristupPanel.Location = new System.Drawing.Point(14, 130);
            this.pristupPanel.Name = "pristupPanel";
            this.pristupPanel.Size = new System.Drawing.Size(357, 118);
            this.pristupPanel.TabIndex = 5;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // NoviKorisnikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(412, 309);
            this.Controls.Add(this.pristupPanel);
            this.Controls.Add(this.telefonInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prezimeInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imeInput);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NoviKorisnikForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi korisnik";
            this.Load += new System.EventHandler(this.NoviKorisnikForm_Load);
            this.pristupPanel.ResumeLayout(false);
            this.pristupPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox telefonInput;
        private System.Windows.Forms.TextBox lozinkaInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox korisnickoImeInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.CheckedListBox ulogeList;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prezimeInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox imeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pristupPanel;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}