namespace eProdaja_AdminUI.Korisnici
{
    partial class PristupSistemuForm
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
            this.aktivanCheck = new System.Windows.Forms.CheckBox();
            this.ulogeList = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.korisnickoImeInput = new System.Windows.Forms.TextBox();
            this.lozinkaInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sacuvajButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aktivanCheck
            // 
            this.aktivanCheck.AutoSize = true;
            this.aktivanCheck.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aktivanCheck.ForeColor = System.Drawing.Color.White;
            this.aktivanCheck.Location = new System.Drawing.Point(134, 107);
            this.aktivanCheck.Name = "aktivanCheck";
            this.aktivanCheck.Size = new System.Drawing.Size(66, 17);
            this.aktivanCheck.TabIndex = 32;
            this.aktivanCheck.Text = "Aktivan";
            this.aktivanCheck.UseVisualStyleBackColor = true;
            // 
            // ulogeList
            // 
            this.ulogeList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ulogeList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ulogeList.FormattingEnabled = true;
            this.ulogeList.Location = new System.Drawing.Point(134, 69);
            this.ulogeList.Name = "ulogeList";
            this.ulogeList.Size = new System.Drawing.Size(227, 19);
            this.ulogeList.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(78, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Uloge:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Korisničko ime:";
            // 
            // korisnickoImeInput
            // 
            this.korisnickoImeInput.Location = new System.Drawing.Point(134, 17);
            this.korisnickoImeInput.Name = "korisnickoImeInput";
            this.korisnickoImeInput.ReadOnly = true;
            this.korisnickoImeInput.Size = new System.Drawing.Size(227, 22);
            this.korisnickoImeInput.TabIndex = 25;
            // 
            // lozinkaInput
            // 
            this.lozinkaInput.Location = new System.Drawing.Point(134, 43);
            this.lozinkaInput.Name = "lozinkaInput";
            this.lozinkaInput.PasswordChar = '*';
            this.lozinkaInput.Size = new System.Drawing.Size(227, 22);
            this.lozinkaInput.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(68, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Lozinka:";
            // 
            // sacuvajButton
            // 
            this.sacuvajButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sacuvajButton.ForeColor = System.Drawing.Color.Black;
            this.sacuvajButton.Image = global::eProdaja_AdminUI.Properties.Resources.save_2_32;
            this.sacuvajButton.Location = new System.Drawing.Point(252, 137);
            this.sacuvajButton.Name = "sacuvajButton";
            this.sacuvajButton.Size = new System.Drawing.Size(110, 44);
            this.sacuvajButton.TabIndex = 31;
            this.sacuvajButton.Text = "Sačuvaj";
            this.sacuvajButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sacuvajButton.UseVisualStyleBackColor = true;
            this.sacuvajButton.Click += new System.EventHandler(this.sacuvajButton_Click);
            // 
            // PristupSistemuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(397, 198);
            this.Controls.Add(this.aktivanCheck);
            this.Controls.Add(this.sacuvajButton);
            this.Controls.Add(this.ulogeList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.korisnickoImeInput);
            this.Controls.Add(this.lozinkaInput);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PristupSistemuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podaci za pristup sistemu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox aktivanCheck;
        private System.Windows.Forms.Button sacuvajButton;
        private System.Windows.Forms.CheckedListBox ulogeList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox korisnickoImeInput;
        private System.Windows.Forms.TextBox lozinkaInput;
        private System.Windows.Forms.Label label6;
    }
}