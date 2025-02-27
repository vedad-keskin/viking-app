﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data.Models
{
    public class Vrsta
    {
        public int Id { get; set; }
        public string Naziv { get; set; } = string.Empty;

        public override string ToString()
        {
            return Naziv;
        }
    }
}
