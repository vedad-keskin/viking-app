using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viking.Data.Models
{
    public class Vozilo
    {
        [Key]
        public int Id { get; set; }
        public string Naziv { get; set; } = string.Empty;

        public override string ToString()
        {
            return Naziv;
        }
    }
}
