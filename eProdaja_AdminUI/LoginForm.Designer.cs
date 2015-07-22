namespace eProdaja_AdminUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.odustaniButton = new System.Windows.Forms.Button();
            this.potvrdiButton = new System.Windows.Forms.Button();
            this.lozinkaInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.korisnickoImeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // odustaniButton
            // 
            this.odustaniButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.odustaniButton.Image = global::eProdaja_AdminUI.Properties.Resources.minus32;
            this.odustaniButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.odustaniButton.Location = new System.Drawing.Point(155, 80);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(93, 40);
            this.odustaniButton.TabIndex = 11;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.odustaniButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // potvrdiButton
            // 
            this.potvrdiButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.potvrdiButton.Image = global::eProdaja_AdminUI.Properties.Resources.unlock32;
            this.potvrdiButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.potvrdiButton.Location = new System.Drawing.Point(254, 80);
            this.potvrdiButton.Name = "potvrdiButton";
            this.potvrdiButton.Size = new System.Drawing.Size(93, 40);
            this.potvrdiButton.TabIndex = 10;
            this.potvrdiButton.Text = "Potvrdi";
            this.potvrdiButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.potvrdiButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.potvrdiButton.UseVisualStyleBackColor = true;
            this.potvrdiButton.Click += new System.EventHandler(this.potvrdiButton_Click);
            // 
            // lozinkaInput
            // 
            this.lozinkaInput.Location = new System.Drawing.Point(140, 43);
            this.lozinkaInput.Name = "lozinkaInput";
            this.lozinkaInput.PasswordChar = '*';
            this.lozinkaInput.Size = new System.Drawing.Size(207, 20);
            this.lozinkaInput.TabIndex = 9;
            this.lozinkaInput.Text = "admin";
            this.lozinkaInput.UseWaitCursor = true;
            this.lozinkaInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lozinkaInput_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(87, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lozinka:";
            // 
            // korisnickoImeInput
            // 
            this.korisnickoImeInput.Location = new System.Drawing.Point(140, 17);
            this.korisnickoImeInput.Name = "korisnickoImeInput";
            this.korisnickoImeInput.Size = new System.Drawing.Size(207, 20);
            this.korisnickoImeInput.TabIndex = 7;
            this.korisnickoImeInput.Text = "admin";
            this.korisnickoImeInput.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Korisničko ime:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(433, 142);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.potvrdiButton);
            this.Controls.Add(this.lozinkaInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.korisnickoImeInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava na sistem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Button potvrdiButton;
        private System.Windows.Forms.TextBox lozinkaInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox korisnickoImeInput;
        private System.Windows.Forms.Label label1;
    }
}