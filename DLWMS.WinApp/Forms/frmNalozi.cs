using DLWMS.Data.Models;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinApp.Forms
{
    public partial class frmNalozi : Form
    {
        private int id;
        DLWMSContext db = new DLWMSContext();

        public frmNalozi(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frmNalozi_Load(object sender, EventArgs e)
        {
            dgvNalozi.AutoGenerateColumns = false;
            UcitajComboBox();
            UcitajNaloge();
        }

        private void UcitajComboBox()
        {
            cbUsluga.DataSource = db.Usluge.ToList();
            cbRadnik.DataSource = db.Radnici.ToList();
            cbVozilo.DataSource = db.Vozila.ToList();
            cbFirma.DataSource = db.Firme.ToList();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (ValidirajUnosNaloga())
            {

                var radnik = cbRadnik.SelectedItem as Radnik;
                var vozilo = cbVozilo.SelectedItem as Vozilo;
                var firma = cbFirma.SelectedItem as Firma;
                var usluga = cbUsluga.SelectedItem as Usluga;

                var iznos = int.Parse(txtIznos.Text);
                var kolicina = int.Parse(txtKolicina.Text);

                var noviNalog = new Nalog()
                {

                    RadnikId = radnik.Id,
                    UslugaId = usluga.Id,
                    Kolicina = kolicina,
                    FirmaId = firma.Id,
                    VoziloId = vozilo.Id,
                    Datum = DateTime.Now,
                    Iznos = iznos

                };

                db.Nalozi.Add(noviNalog);
                db.SaveChanges();

                UcitajNaloge();

            }



        }

        private bool ValidirajUnosNaloga()
        {
            return Validator.ProvjeriJeLiBroj(txtKolicina, err, "Vrijednost mora biti numerička")
                &&
                Validator.ProvjeriJeLiBroj(txtIznos, err, "Vrijednost mora biti numerička");
        }

        private void UcitajNaloge()
        {
            var nalozi = db.Nalozi.ToList();

            if(nalozi != null)
            {

                dgvNalozi.DataSource = null;
                dgvNalozi.DataSource = nalozi;

            }
        }
    }
}
