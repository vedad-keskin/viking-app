using DLWMS.Data.Models;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
using DLWMS.WinApp.Properties;
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
    public partial class frmNaloziEdit : Form
    {
        private Nalog odabraniNalog;
        DLWMSContext db = new DLWMSContext();

        public frmNaloziEdit(Nalog odabraniNalog)
        {
            InitializeComponent();
            this.odabraniNalog = odabraniNalog;
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmNaloziEdit_Load(object sender, EventArgs e)
        {
            UcitajComboBox();
            UcitajInfo();
        }

        private void UcitajComboBox()
        {
            cbUsluga.DataSource = db.Usluge.ToList();
            cbVozilo.DataSource = db.Vozila.ToList();
            cbFirma.DataSource = db.Firme.ToList();
            cbRadnik.DataSource = db.Radnici.ToList();
        }

        private void UcitajInfo()
        {
            pbLogo.Image = Resources.Viking_transparent;

            cbFirma.SelectedIndex = cbFirma.Items.Cast<Firma>().ToList()
                 .FindIndex(f => f.Id == odabraniNalog.FirmaId);

            cbRadnik.SelectedIndex = cbRadnik.Items.Cast<Radnik>().ToList()
                .FindIndex(r => r.Id == odabraniNalog.RadnikId);

            cbUsluga.SelectedIndex = cbUsluga.Items.Cast<Usluga>().ToList()
                .FindIndex(u => u.Id == odabraniNalog.UslugaId);

            cbVozilo.SelectedIndex = cbVozilo.Items.Cast<Vozilo>().ToList()
                .FindIndex(v => v.Id == odabraniNalog.VoziloId);

            txtIznos.Text = odabraniNalog.Iznos.ToString();
            txtKolicina.Text = odabraniNalog.Kolicina.ToString();
            dtpDatum.Value = odabraniNalog.Datum;

            txtIznos.Text = odabraniNalog?.Iznos.ToString() ?? string.Empty;
            txtKolicina.Text = odabraniNalog?.Kolicina.ToString() ?? string.Empty;
            dtpDatum.Value = odabraniNalog?.Datum ?? DateTime.Now;

        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {

                var radnik = cbRadnik.SelectedItem as Radnik;
                var vozilo = cbVozilo.SelectedItem as Vozilo;
                var firma = cbFirma.SelectedItem as Firma;
                var usluga = cbUsluga.SelectedItem as Usluga;

                var iznos = int.Parse(txtIznos.Text);
                var kolicina = int.Parse(txtKolicina.Text);
                var datum = dtpDatum.Value;


                odabraniNalog.FirmaId = firma!.Id;
                odabraniNalog.Firma = firma;
                odabraniNalog.VoziloId = vozilo!.Id;
                odabraniNalog.Vozilo = vozilo;
                odabraniNalog.RadnikId = radnik!.Id;
                odabraniNalog.Radnik = radnik;
                odabraniNalog.UslugaId = usluga!.Id;
                odabraniNalog.Usluga = usluga;
                odabraniNalog.Iznos = iznos;
                odabraniNalog.Kolicina = kolicina;
                odabraniNalog.Datum = datum;

                db.Nalozi.Update(odabraniNalog);
                db.SaveChanges();

                DialogResult = DialogResult.OK;


            }
        }

        private bool ValidirajUnos()
        {
            return Validator.ProvjeriJeLiBroj(txtKolicina, err, "Vrijednost mora biti numerička")
                           &&
                       Validator.ProvjeriJeLiBroj(txtIznos, err, "Vrijednost mora biti numerička");
        }
    }
}
