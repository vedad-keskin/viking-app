using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.Models
{
    public class Nalog
    {
        [Key]
        public int Id { get; set; }
        public int RadnikId { get; set; }
        public Radnik Radnik { get; set; }
        public int? VoziloId { get; set; }
        public Vozilo Vozilo { get; set; }
        public int? UslugaId { get; set; }
        public Usluga Usluga { get; set; }

        public int Kolicina { get; set; }

        public int Iznos { get; set; }

        public int? FirmaId { get; set; }

        public Firma Firma { get; set; }

        public DateTime Datum { get; set; }


    }
}
