using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
using DLWMS.WinApp.Properties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinApp.Forms
{
    public partial class frmLogin : Form
    {
        DLWMSContext db = new DLWMSContext();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            UcitajLogo();
        }

        private void UcitajLogo()
        {
            pbLogo.Image = Resources.logo_black;
        }

        private async void btnPrijava_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {
                var korisnickoIme = txtKorisnickoIme.Text.ToLower();
                var lozinka = txtLozinka.Text.ToLower();

                frmLoading loadingScreen = new frmLoading();
                loadingScreen.Show();
                loadingScreen.Refresh(); // Ensure it renders before the task starts

                try
                {
                    var korisnik = await db.Radnici
                        .Where(x => x.Username.ToLower() == korisnickoIme)
                        .FirstOrDefaultAsync();

                    if (korisnik == null || string.IsNullOrEmpty(korisnik.Password) || korisnik.Password != lozinka)
                    {
                        MessageBox.Show("Korisnički podaci nisu ispravni", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        var frmNalozi = new frmNalozi(korisnik.Id);
                        if (frmNalozi.ShowDialog() == DialogResult.OK)
                        {
                            txtKorisnickoIme.Clear();
                            txtLozinka.Clear();
                        }
                    }
                }
                finally
                {
                    loadingScreen.Close(); // Close the loading screen when login is complete
                }
            }
        }

        private bool ValidirajUnos()
        {
            return Validator.ProvjeriUnos(txtKorisnickoIme, err, "Obavezno polje")
                &&
                Validator.ProvjeriUnos(txtLozinka, err, "Obavezno polje");

        }
    }
}
