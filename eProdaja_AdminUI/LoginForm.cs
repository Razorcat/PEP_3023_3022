using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using eProdaja_Service.Data;

namespace eProdaja_AdminUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void potvrdiButton_Click(object sender, EventArgs e)
        {
            try
            {
                eProdaja_Service.Data.Korisnici k = DAKorisnici.SelectByKorisnickoIme(korisnickoImeInput.Text, lozinkaInput.Text);

                if (k != null) 
                {
                    if (k.Uloge.Count > 0) 
                    {
                        Global.prijavljeniKorisnik = k;
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    lozinkaInput.Text = "";
                    MessageBox.Show(Global.GetString("login_err"), "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
            }
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lozinkaInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                potvrdiButton_Click(potvrdiButton, EventArgs.Empty);
        }
    }
}
