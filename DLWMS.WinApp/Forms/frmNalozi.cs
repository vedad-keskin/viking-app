using DLWMS.Data.Models;
using DLWMS.Infrastructure;
using DLWMS.WinApp.Helpers;
using DLWMS.WinApp.Izvjestaji;
using Microsoft.EntityFrameworkCore;
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
        List<Nalog> dnevniNalozi;

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
            UcitajVrijeme();
        }

        private void UcitajComboBox()
        {
            cbUsluga.DataSource = db.Usluge.ToList();
            cbVozilo.DataSource = db.Vozila.ToList();
            cbFirma.DataSource = db.Firme.ToList();
            cbRadnik.DataSource = db.Radnici.ToList();

            cbRadnik.SelectedIndex = id - 1;

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

                var noviNalog = new Nalog();


                // Ako se filtrira novi datum da se dodati nalog stavi na taj datum

                if (DateTime.Now.Date == dtpDatumFilter.Value.Date)
                {

                    noviNalog.RadnikId = radnik.Id;
                    noviNalog.UslugaId = usluga.Id;
                    noviNalog.Kolicina = kolicina;
                    noviNalog.FirmaId = firma.Id;
                    noviNalog.VoziloId = vozilo.Id;
                    noviNalog.Datum = DateTime.Now;
                    noviNalog.Iznos = iznos;

                }
                else
                {

                    noviNalog.RadnikId = radnik.Id;
                    noviNalog.UslugaId = usluga.Id;
                    noviNalog.Kolicina = kolicina;
                    noviNalog.FirmaId = firma.Id;
                    noviNalog.VoziloId = vozilo.Id;
                    noviNalog.Datum = dtpDatumFilter.Value;
                    noviNalog.Iznos = iznos;

                }


                db.Nalozi.Add(noviNalog);
                db.SaveChanges();

                UcitajNaloge();

                txtKolicina.Clear();
                txtIznos.Clear();

            }



        }

        private bool ValidirajUnosNaloga()
        {
            return Validator.ProvjeriJeLiBroj(txtKolicina, err, "Vrijednost mora biti numerička")
                &&
                Validator.ProvjeriJeLiBroj(txtIznos, err, "Vrijednost mora biti numerička");
        }

        private async void UcitajNaloge()
        {

            var odabraniDatum = dtpDatumFilter.Value;

            dnevniNalozi = await db.Nalozi
                .Where(x => x.Datum.Date == odabraniDatum.Date)
                .ToListAsync();

            if (dnevniNalozi != null)
            {

                dgvNalozi.DataSource = null;
                dgvNalozi.DataSource = dnevniNalozi;

            }

            lblUkupno.Text = $"Ukupno {dnevniNalozi.Sum(x => x.Iznos)} KM";
            Text = $"Viking - {odabraniDatum.ToString("dd.MM.yyyy")}";
        }

        private void frmNalozi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void dgvNalozi_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var odabraniNalog = dnevniNalozi[e.RowIndex];

            if (Obrisi.Index == e.ColumnIndex)
            {

                if (MessageBox.Show($"Da li ste sigurni da želite obrisati nalog {odabraniNalog} ?", "Pitanje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    db.Nalozi.Remove(odabraniNalog);
                    db.SaveChanges();

                    UcitajNaloge();
                }


            }
            else if (Uredi.Index == e.ColumnIndex)
            {

                var frmNalogEdit = new frmNaloziEdit(odabraniNalog);

                if (frmNalogEdit.ShowDialog() == DialogResult.OK)
                {
                    UcitajNaloge();
                }

            }


        }

        private void timer_Tick(object sender, EventArgs e)
        {
            UcitajVrijeme();
        }

        private void UcitajVrijeme()
        {
            tsslDatumIVrijeme.Text = $"Datum i vrijeme: {DateTime.Now.ToString("dd.mm.yyyy HH:mm")}";
        }

        private void dtpDatumFilter_ValueChanged(object sender, EventArgs e)
        {
            UcitajNaloge();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dtpDatumFilter.Value = dtpDatumFilter.Value.AddDays(1);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dtpDatumFilter.Value = dtpDatumFilter.Value.AddDays(-1);
        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            var noviIzvjestaj = new frmIzvjestaji();

            noviIzvjestaj.ShowDialog();
        }
    }
}
