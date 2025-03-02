using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viking.Data.Models
{
    public class Usluga
    {
        [Key]
        public int Id { get; set; }
        public string Naziv { get; set; } = string.Empty;

        public int VrstaId { get; set; }
        public Vrsta Vrsta { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
