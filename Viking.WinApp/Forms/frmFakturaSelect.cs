﻿using Viking.Data.Models;
using Viking.Infrastructure;
using Viking.WinApp.Fakture;
using Viking.WinApp.Helpers;
using Viking.WinApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viking.WinApp.Forms
{
    public partial class frmFakturaSelect : Form
    {
        DLWMSContext db = new DLWMSContext();
        public frmFakturaSelect()
        {
            InitializeComponent();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmFakturaSelect_Load(object sender, EventArgs e)
        {
            pbLogo.Image = Resources.Viking_transparent;

            cbFirma.DataSource = db.Firme.ToList();

            cbFirma.SelectedIndex = 1;
        }

        private void btnFaktura_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {

                var firma = cbFirma.SelectedItem as Firma;
                var datumOd = dtpDatumOd.Value;
                var datumDo = dtpDatumDo.Value;
                var rok = int.Parse(txtRok.Text);
                var brojUgovora = int.Parse(txtBroj.Text);


                var IzvjestajFaktura = new frmFaktura(firma,datumOd,datumDo,rok,brojUgovora);

                IzvjestajFaktura.ShowDialog();

            }
        }

        private bool ValidirajUnos()
        {
            return Validator.ProvjeriJeLiBroj(txtRok, err, "Vrijednost mora biti numerička")
            &&
             Validator.ProvjeriJeLiBroj(txtBroj, err, "Vrijednost mora biti numerička");
        }
    }
}
