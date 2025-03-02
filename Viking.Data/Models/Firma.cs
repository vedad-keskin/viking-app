using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viking.Data.Models
{
    public class Firma
    {
        [Key]
        public int Id { get; set; }
        public string Naziv { get; set; } = string.Empty;
        public string? PuniNaziv { get; set; } = string.Empty;
        public string? Adresa { get; set; } = string.Empty;
        public string? IDbr { get; set; } = string.Empty;
        public string? PDVbr { get; set; } = string.Empty;

        public override string ToString()
        {
            return Naziv;
        }
    }
}
