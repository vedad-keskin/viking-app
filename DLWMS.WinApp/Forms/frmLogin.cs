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
            if (Validiraj())
            {
                var korisnickoIme = txtKorisnickoIme.Text.ToLower();
                var lozinka = txtLozinka.Text.ToLower();

                var korisnik = await db.Radnici.Where(x => x.Username.ToLower() == korisnickoIme).FirstOrDefaultAsync();

                if(korisnik == null || korisnik.Password != lozinka)
                {
                    MessageBox.Show("Korisnički podaci nisu ispravni","Upozorenje",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    var frmNalozi = new frmNalozi(korisnik.Id);

                    frmNalozi.ShowDialog();
                }


            }
        }

        private bool Validiraj()
        {
            return Validator.ProvjeriUnos(txtKorisnickoIme, err, "Obavezno polje")
                &&
                Validator.ProvjeriUnos(txtLozinka, err, "Obavezno polje");

        }
    }
}
