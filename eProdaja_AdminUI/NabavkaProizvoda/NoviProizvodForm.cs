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
using eProdaja_Service.Util;
using System.IO;

namespace eProdaja_AdminUI.NabavkaProizvoda
{
    public partial class NoviProizvodForm : Form
    {
        private Proizvodi proizvod { get; set; }
        public NoviProizvodForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void NoviProizvodForm_Load(object sender, EventArgs e)
        {
            BindVrste();
            BindJediniceMjere();
        }

        private void BindVrste()
        {
            vrstaList.DataSource = DAProizvodi.VrsteSelect();
            vrstaList.DisplayMember = "Naziv";
            vrstaList.ValueMember = "VrstaID";

        }

        private void BindJediniceMjere()
        {
            jedinicaMjereList.DataSource = DAProizvodi.JediniceMjereSelect();
            jedinicaMjereList.DisplayMember = "Naziv";
            jedinicaMjereList.ValueMember = "JedinicaMjereID";

        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {
                    if (proizvod == null)
                        proizvod = new Proizvodi();

                    if (vrstaList.SelectedIndex > 0)
                        proizvod.VrstaID = Convert.ToInt32(vrstaList.SelectedValue);

                    if (jedinicaMjereList.SelectedIndex > 0)
                        proizvod.JedinicaMjereID = Convert.ToInt32(jedinicaMjereList.SelectedValue);

                    proizvod.Sifra = sifraInput.Text;
                    proizvod.Naziv = nazivInput.Text;
                    proizvod.Cijena = Convert.ToDecimal(cijenaInput.Text);

                    DAProizvodi.Insert(proizvod);
                    BindGrid();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void clear()
        {
            sifraInput.Text = "";
            nazivInput.Text = "";
            cijenaInput.Text = "";
            jedinicaMjereList.SelectedIndex = 0;
            pictureBox.Image = null;
        }

        private void BindGrid()
        {
            int vrstaId = Convert.ToInt32(vrstaList.SelectedValue);
            proizvodiGrid.ClearSelection();
            proizvodiGrid.DataSource = DAProizvodi.SelectByVrsta(vrstaId);
            proizvodiGrid.Columns[0].Visible = false;
        }

        private void vrstaList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vrstaList.SelectedIndex > 0)
                BindGrid();
            else
                proizvodiGrid.DataSource = null;
        }

        private void dodajSlikuButton_Click(object sender, EventArgs e)
        {
            try
            {
                proizvod = new Proizvodi();

                openFileDialog.ShowDialog();
                slikaInput.Text = openFileDialog.FileName;

                Image image = Image.FromFile(slikaInput.Text);

                MemoryStream ms = new MemoryStream();
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                proizvod.Slika = ms.ToArray();

                if (image.Width > 200)
                {
                    Image resizedImage = UIHelper.ResizeImage(image, new Size(200, 180));
                    Image croppedImage = resizedImage;

                    
                    if (resizedImage.Width >= 160 && resizedImage.Height >= 140)
                        croppedImage = UIHelper.CropImage(resizedImage, new Rectangle(40, 40, 120, 100));

                    ms = new MemoryStream();

                    croppedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    proizvod.SlikaThumb = ms.ToArray();

                    pictureBox.Image = croppedImage;
                }
                else
                {
                    proizvod.SlikaThumb = ms.ToArray();
                    pictureBox.Image = image;
                }
            }
            catch
            {
                proizvod = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VrsteProizvoda form = new VrsteProizvoda();


            NabavkaProizvoda.VrsteProizvodaForm vrste= new NabavkaProizvoda.VrsteProizvodaForm();
            vrste.Show();
        }

        #region validacija
        private void vrstaList_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32(vrstaList.SelectedValue) <= 0)
            {
                e.Cancel = true;
                errorProvider.SetError(vrstaList, "Niste odabrali vrstu proizvoda!");
            }
        }

        private void sifraInput_Validating(object sender, CancelEventArgs e)
        {
            if (sifraInput.Text.Trim()=="")
            {
                e.Cancel = true;
                errorProvider.SetError(sifraInput, "Niste unijeli šifru proizvoda!");
            }
        }

        private void nazivInput_Validating(object sender, CancelEventArgs e)
        {
            if (nazivInput.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider.SetError(nazivInput, "Niste unijeli naziv proizvoda!");
            }
        }

        private void cijenaInput_Validating(object sender, CancelEventArgs e)
        {
            if (cijenaInput.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider.SetError(nazivInput, "Niste unijeli cijenu proizvoda!");
            }
        }

        private void jedinicaMjereList_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32(jedinicaMjereList.SelectedValue) <= 0)
            {
                e.Cancel = true;
                errorProvider.SetError(jedinicaMjereList, "Niste odabrali jedinicu mjere!");
            }
        }
        #endregion
    }
}
