using Viking.Data.Models;
using Viking.Infrastructure;
using Viking.WinApp.Invoices;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;

namespace Viking.WinApp.Fakture
{
    public partial class frmFaktura : Form
    {

        DLWMSContext db = new DLWMSContext();
        private Firma? firma;
        private DateTime datumOd;
        private DateTime datumDo;
        private int rok;
        private int brojUgovora;


        public frmFaktura(Firma? firma, DateTime datumOd, DateTime datumDo, int rok, int brojUgovora)
        {
            InitializeComponent();            
            this.firma = firma;
            this.datumOd = datumOd;
            this.datumDo = datumDo;
            this.rok = rok;
            this.brojUgovora = brojUgovora;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            UcitajIzvjestaj();

            reportViewer1.LocalReport.DisplayName = $"Faktura - {firma} - {DateTime.Now.ToShortDateString()}";
            reportViewer1.RefreshReport(); 
        }

        private void UcitajIzvjestaj()
        {

            var naloziFirme = db.Nalozi
                .Include(x=> x.Firma)
                .Include(x=> x.Vozilo)
                .Include(x=> x.Usluga)
                .Where(x=> x.Datum >=  datumOd && x.Datum <= datumDo)
                .Where(x=> x.FirmaId == firma.Id)
                .ToList();

            var tblNalozi = new dsFaktura.dsFakturaDataTable();

            for (int i = 0; i < naloziFirme.Count(); i++)
            {
                var Red = tblNalozi.NewdsFakturaRow();

                Red.Datum = naloziFirme[i]?.Datum.ToShortDateString() ?? "N/A";
                Red.Vozilo = naloziFirme[i]?.Vozilo.ToString() ?? "N/A";
                Red.Usluga = naloziFirme[i]?.Usluga.ToString() ?? "N/A";
                Red.Kolicina = naloziFirme[i]?.Kolicina.ToString() ?? "N/A";
                Red.Iznos = naloziFirme[i]?.Iznos.ToString() ?? "N/A";

                tblNalozi.Rows.Add(Red);

            }

            var rds = new ReportDataSource();

            rds.Value = tblNalozi;
            rds.Name = "dsFaktura";

            reportViewer1.LocalReport.DataSources.Add(rds);


            var rpc = new ReportParameterCollection();

            var sumaIznos = naloziFirme.Sum(x => x.Iznos);

            rpc.Add(new ReportParameter("sumaIznos", sumaIznos.ToString()));

            rpc.Add(new ReportParameter("naziv", firma?.PuniNaziv ?? "N/A"));
            rpc.Add(new ReportParameter("adresa", firma?.Adresa ?? "N/A"));
            rpc.Add(new ReportParameter("id", firma?.IDbr ?? "N/A"));
            rpc.Add(new ReportParameter("pdv", firma?.PDVbr ?? "N/A"));
            rpc.Add(new ReportParameter("rok", rok.ToString() ?? "N/A"));
            rpc.Add(new ReportParameter("datum", DateTime.Now.ToShortDateString()));

            var brojFakture = $"{brojUgovora}-{DateTime.Now.Month}/{DateTime.Now.Year}";

            rpc.Add(new ReportParameter("brojFaktura", brojFakture ?? "N/A"));

            reportViewer1.LocalReport.SetParameters(rpc);

        }
    }
}
