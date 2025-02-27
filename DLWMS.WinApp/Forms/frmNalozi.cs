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
        int vrsta = 1;

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
            cbUsluga.DataSource = db.Usluge.Where(x => x.VrstaId == vrsta).ToList();
            cbVozilo.DataSource = db.Vozila.ToList();
            cbFirma.DataSource = db.Firme.ToList();
            cbRadnik.DataSource = db.Radnici.ToList();


            if(vrsta == 1) // dft korisnik na vulk said
            {
                cbRadnik.SelectedIndex = 0;
            }
            else // hare na praoni
            {
                cbRadnik.SelectedIndex = 1;
            }

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
                .Where(x => x.Usluga.VrstaId == vrsta)
                .ToListAsync();

            if (dnevniNalozi != null)
            {

                dgvNalozi.DataSource = null;
                dgvNalozi.DataSource = dnevniNalozi;

            }

            lblUkupno.Text = $"Ukupno {dnevniNalozi.Sum(x => x.Iznos)} KM";
            Text = $"Viking - {odabraniDatum.ToString("dd.MM.yyyy")}";

            IzracunajProcenat();
            lblVrsta.Text = vrsta == 1 ? "Vuklanizerska radnja" : "Praonica";

        }

        private void IzracunajProcenat()
        {

            float saidProcenat = 0;

            // Dobivanje naloga koji nisu repro materijali

            var reportMaterijal = new HashSet<string>
              {
                  "Ventil", "Pojas", "Zračnice",
                  "BP1 Fleka", "BP2 Fleka", "BP3 Fleka",
                  "BP4 Fleka", "BP5 Fleka"
              };

            // Računanje 100% od repro materijala

            var reproMaterijalNalozi = dnevniNalozi
                           .Where(x => x.Usluga != null && reportMaterijal.Contains(x.Usluga.Naziv))
                           .ToList();

            if (reproMaterijalNalozi.Count() != 0)
            {
                saidProcenat += reproMaterijalNalozi.Sum(x => x.Iznos);

            }

            MessageBox.Show($"{reproMaterijalNalozi.Count()} <--");

            var dnevniNaloziBezRepro = dnevniNalozi
                           .Where(x => x.Usluga != null && !reportMaterijal.Contains(x.Usluga.Naziv))
                           .ToList();

            float senoProcenat = (float)((dnevniNaloziBezRepro.Sum(x=> x.Iznos)) * 0.25);

            float hareProcenat = 0;

            float beliProcenat = 0;



            if (vrsta == 1) // AKO JE VULKAZNIZERSKA
            {
                // SAID SAM V 

                var saidRadioSam = dnevniNaloziBezRepro.Where(x => x.RadnikId == 1);

                saidProcenat += (float)(saidRadioSam.Sum(x => x.Iznos) * 0.75);

                // HARE SAM

                var hareRadioSam = dnevniNaloziBezRepro.Where(x => x.RadnikId == 2);

                hareProcenat += (float)(hareRadioSam.Sum(x => x.Iznos) * 0.25);

                saidProcenat += (float)(hareRadioSam.Sum(x => x.Iznos) * 0.50);

                // BELI SAM

                var beliRadioSam = dnevniNaloziBezRepro.Where(x => x.RadnikId == 3);

                beliProcenat += (float)(beliRadioSam.Sum(x => x.Iznos) * 0.25);

                saidProcenat += (float)(beliRadioSam.Sum(x => x.Iznos) * 0.50);

                // SAID I HARIS

                var saidHarisRadio = dnevniNaloziBezRepro.Where(x => x.RadnikId == 4);

                saidProcenat += (float)(saidHarisRadio.Sum(x => x.Iznos) * 0.60);

                hareProcenat += (float)(saidHarisRadio.Sum(x => x.Iznos) * 0.15);

                // BELI I HARIS

                var beliHarisRadio = dnevniNaloziBezRepro.Where(x => x.RadnikId == 5);

                saidProcenat += (float)(beliHarisRadio.Sum(x => x.Iznos) * 0.45);

                hareProcenat += (float)(beliHarisRadio.Sum(x => x.Iznos) * 0.15);

                beliProcenat += (float)(beliHarisRadio.Sum(x => x.Iznos) * 0.15);

                // SAID I BELI

                var saidBeliRadio = dnevniNaloziBezRepro.Where(x => x.RadnikId == 6);

                saidProcenat += (float)(saidBeliRadio.Sum(x => x.Iznos) * 0.60);

                beliProcenat += (float)(saidBeliRadio.Sum(x => x.Iznos) * 0.15);


            }else if (vrsta == 2) // PRAONICA 
            {

                // SAID SAM P 

                var saidRadioSam = dnevniNaloziBezRepro.Where(x => x.RadnikId == 1);

                saidProcenat += (float)(saidRadioSam.Sum(x => x.Iznos) * 0.25);

                hareProcenat += (float)(saidRadioSam.Sum(x => x.Iznos) * 0.50);

                // HARE SAM 

                var hareRadioSam = dnevniNaloziBezRepro.Where(x => x.RadnikId == 2);

                hareProcenat += (float)(hareRadioSam.Sum(x => x.Iznos) * 0.75);

                // BELI SAM 

                var beliRadioSam = dnevniNaloziBezRepro.Where(x => x.RadnikId == 3);

                hareProcenat += (float)(beliRadioSam.Sum(x => x.Iznos) * 0.50);

                beliProcenat += (float)(beliRadioSam.Sum(x => x.Iznos) * 0.25);

                // SAID I HARIS

                var saidHarisRadio = dnevniNaloziBezRepro.Where(x => x.RadnikId == 4);

                saidProcenat += (float)(saidHarisRadio.Sum(x => x.Iznos) * 0.15);

                hareProcenat += (float)(saidHarisRadio.Sum(x => x.Iznos) * 0.60);

                // BELI I HARIS

                var beliHarisRadio = dnevniNaloziBezRepro.Where(x => x.RadnikId == 5);

                hareProcenat += (float)(beliHarisRadio.Sum(x => x.Iznos) * 0.60);

                beliProcenat += (float)(beliHarisRadio.Sum(x => x.Iznos) * 0.15);

                // SAID I BELI

                var saidBeliRadio = dnevniNaloziBezRepro.Where(x => x.RadnikId == 6);

                hareProcenat += (float)(saidBeliRadio.Sum(x => x.Iznos) * 0.45);

                beliProcenat += (float)(saidBeliRadio.Sum(x => x.Iznos) * 0.15);

                saidProcenat += (float)(saidBeliRadio.Sum(x => x.Iznos) * 0.15);


            }







            lblProcenti.Text = $"Seno procenat : {senoProcenat} KM\r\n" +
                               $"Said procenat : {saidProcenat} KM\r\n" +
                               $"Hare procenat : {hareProcenat} KM\r\n" +
                               $"Beli procenat : {beliProcenat} KM\r\n";

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
            var noviIzvjestaj = new frmIzvjestaji(dnevniNalozi, dtpDatumFilter.Value.Date);

            noviIzvjestaj.ShowDialog();
        }

        private void btnVulkanizerska_Click(object sender, EventArgs e)
        {
            vrsta = 1;
            UcitajComboBox();
            UcitajNaloge();
        }

        private void btnPraonica_Click(object sender, EventArgs e)
        {
            vrsta = 2;
            UcitajComboBox();
            UcitajNaloge();
        }
    }
}
