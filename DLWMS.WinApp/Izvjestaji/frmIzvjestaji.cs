using DLWMS.Data.Models;
using DLWMS.Infrastructure;
using Microsoft.Reporting.WinForms;

namespace DLWMS.WinApp.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private List<Nalog> dnevniNalozi;
        private DateTime date;
        DLWMSContext db = new DLWMSContext();


        public frmIzvjestaji(List<Nalog> dnevniNalozi, DateTime date)
        {
            InitializeComponent();            
            this.dnevniNalozi = dnevniNalozi;
            this.date = date;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            UcitajIzvjestaj();

            reportViewer1.RefreshReport(); 
        }

        private void UcitajIzvjestaj()
        {
            var tblNalozi = new dsDLWMS.dsDnevniIzvjestajDataTable();

            for (int i = 0; i < dnevniNalozi.Count(); i++)
            {
                var Red = tblNalozi.NewdsDnevniIzvjestajRow();

                Red.Rb = (i + 1).ToString();
                Red.Usluga = dnevniNalozi[i]?.Usluga.ToString() ?? "N/A";
                Red.Vozilo = dnevniNalozi[i]?.Vozilo.ToString() ?? "N/A";
                Red.Radnik = dnevniNalozi[i]?.Radnik.Ime + " " + dnevniNalozi[i]?.Radnik.Prezime ?? "N/A";
                Red.Kolicina = dnevniNalozi[i]?.Kolicina.ToString() ?? "N/A";
                Red.Iznos = dnevniNalozi[i]?.Iznos.ToString() ?? "N/A";
                Red.Datum = dnevniNalozi[i]?.Datum.ToString("d") ?? "N/A";
                Red.Firma = dnevniNalozi[i]?.Firma.ToString() ?? "N/A";
                

                tblNalozi.Rows.Add(Red);

            }

            var rds = new ReportDataSource();

            rds.Value = tblNalozi;
            rds.Name = "dsDnevniIzvjestaj";

            reportViewer1.LocalReport.DataSources.Add(rds);


            var rpc = new ReportParameterCollection();

            var sumaIznos = dnevniNalozi.Sum(x => x.Iznos);

            rpc.Add(new ReportParameter("iznos", sumaIznos.ToString()));

            rpc.Add(new ReportParameter("datum", date.ToString("d")));

            reportViewer1.LocalReport.SetParameters(rpc);

        }
    }
}
