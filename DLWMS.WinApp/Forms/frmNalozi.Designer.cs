namespace DLWMS.WinApp.Forms
{
    partial class frmNalozi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblRadnik = new Label();
            lblUsluga = new Label();
            lblVozilo = new Label();
            label4 = new Label();
            lblKolicina = new Label();
            lblIznos = new Label();
            cbRadnik = new ComboBox();
            cbUsluga = new ComboBox();
            txtKolicina = new TextBox();
            cbVozilo = new ComboBox();
            cbFirma = new ComboBox();
            txtIznos = new TextBox();
            btnDodaj = new Button();
            dgvNalozi = new DataGridView();
            Vozilo = new DataGridViewTextBoxColumn();
            Usluga = new DataGridViewTextBoxColumn();
            Kolicina = new DataGridViewTextBoxColumn();
            Firma = new DataGridViewTextBoxColumn();
            Datum = new DataGridViewTextBoxColumn();
            Iznos = new DataGridViewTextBoxColumn();
            Radnik = new DataGridViewTextBoxColumn();
            Uredi = new DataGridViewButtonColumn();
            Obrisi = new DataGridViewButtonColumn();
            err = new ErrorProvider(components);
            lblUkupno = new Label();
            btnBack = new Button();
            btnNext = new Button();
            dtpDatumFilter = new DateTimePicker();
            btnIzvjestaj = new Button();
            lblProcenti = new Label();
            btnVulkanizerska = new Button();
            btnPraonica = new Button();
            lblVrsta = new Label();
            btnFaktura = new Button();
            pbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvNalozi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // lblRadnik
            // 
            lblRadnik.AutoSize = true;
            lblRadnik.Location = new Point(12, 114);
            lblRadnik.Name = "lblRadnik";
            lblRadnik.Size = new Size(57, 20);
            lblRadnik.TabIndex = 0;
            lblRadnik.Text = "Radnik:";
            // 
            // lblUsluga
            // 
            lblUsluga.AutoSize = true;
            lblUsluga.Location = new Point(207, 114);
            lblUsluga.Name = "lblUsluga";
            lblUsluga.Size = new Size(57, 20);
            lblUsluga.TabIndex = 0;
            lblUsluga.Text = "Usluga:";
            // 
            // lblVozilo
            // 
            lblVozilo.AutoSize = true;
            lblVozilo.Location = new Point(536, 114);
            lblVozilo.Name = "lblVozilo";
            lblVozilo.Size = new Size(53, 20);
            lblVozilo.TabIndex = 0;
            lblVozilo.Text = "Vozilo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(731, 114);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 0;
            label4.Text = "Firma:";
            // 
            // lblKolicina
            // 
            lblKolicina.AutoSize = true;
            lblKolicina.Location = new Point(405, 114);
            lblKolicina.Name = "lblKolicina";
            lblKolicina.Size = new Size(65, 20);
            lblKolicina.TabIndex = 0;
            lblKolicina.Text = "Količina:";
            // 
            // lblIznos
            // 
            lblIznos.AutoSize = true;
            lblIznos.Location = new Point(926, 114);
            lblIznos.Name = "lblIznos";
            lblIznos.Size = new Size(46, 20);
            lblIznos.TabIndex = 0;
            lblIznos.Text = "Iznos:";
            // 
            // cbRadnik
            // 
            cbRadnik.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRadnik.FormattingEnabled = true;
            cbRadnik.Location = new Point(12, 137);
            cbRadnik.Name = "cbRadnik";
            cbRadnik.Size = new Size(189, 28);
            cbRadnik.TabIndex = 10;
            // 
            // cbUsluga
            // 
            cbUsluga.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUsluga.FormattingEnabled = true;
            cbUsluga.Location = new Point(207, 137);
            cbUsluga.Name = "cbUsluga";
            cbUsluga.Size = new Size(189, 28);
            cbUsluga.TabIndex = 5;
            // 
            // txtKolicina
            // 
            txtKolicina.Location = new Point(405, 137);
            txtKolicina.Name = "txtKolicina";
            txtKolicina.Size = new Size(125, 27);
            txtKolicina.TabIndex = 1;
            // 
            // cbVozilo
            // 
            cbVozilo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVozilo.FormattingEnabled = true;
            cbVozilo.Location = new Point(536, 137);
            cbVozilo.Name = "cbVozilo";
            cbVozilo.Size = new Size(189, 28);
            cbVozilo.TabIndex = 6;
            // 
            // cbFirma
            // 
            cbFirma.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFirma.FormattingEnabled = true;
            cbFirma.Location = new Point(731, 136);
            cbFirma.Name = "cbFirma";
            cbFirma.Size = new Size(189, 28);
            cbFirma.TabIndex = 7;
            // 
            // txtIznos
            // 
            txtIznos.Location = new Point(926, 138);
            txtIznos.Name = "txtIznos";
            txtIznos.Size = new Size(125, 27);
            txtIznos.TabIndex = 2;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(1057, 138);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(121, 29);
            btnDodaj.TabIndex = 3;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvNalozi
            // 
            dgvNalozi.AllowUserToAddRows = false;
            dgvNalozi.AllowUserToDeleteRows = false;
            dgvNalozi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNalozi.Columns.AddRange(new DataGridViewColumn[] { Vozilo, Usluga, Kolicina, Firma, Datum, Iznos, Radnik, Uredi, Obrisi });
            dgvNalozi.Location = new Point(12, 171);
            dgvNalozi.Name = "dgvNalozi";
            dgvNalozi.ReadOnly = true;
            dgvNalozi.RowHeadersWidth = 51;
            dgvNalozi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNalozi.Size = new Size(1166, 362);
            dgvNalozi.TabIndex = 4;
            dgvNalozi.CellClick += dgvNalozi_CellClick;
            // 
            // Vozilo
            // 
            Vozilo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Vozilo.DataPropertyName = "Vozilo";
            Vozilo.HeaderText = "Vozilo";
            Vozilo.MinimumWidth = 6;
            Vozilo.Name = "Vozilo";
            Vozilo.ReadOnly = true;
            // 
            // Usluga
            // 
            Usluga.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Usluga.DataPropertyName = "Usluga";
            Usluga.HeaderText = "Usluga";
            Usluga.MinimumWidth = 6;
            Usluga.Name = "Usluga";
            Usluga.ReadOnly = true;
            // 
            // Kolicina
            // 
            Kolicina.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Kolicina.DataPropertyName = "Kolicina";
            Kolicina.HeaderText = "Količina";
            Kolicina.MinimumWidth = 6;
            Kolicina.Name = "Kolicina";
            Kolicina.ReadOnly = true;
            // 
            // Firma
            // 
            Firma.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Firma.DataPropertyName = "Firma";
            Firma.HeaderText = "Firma";
            Firma.MinimumWidth = 6;
            Firma.Name = "Firma";
            Firma.ReadOnly = true;
            // 
            // Datum
            // 
            Datum.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Datum.DataPropertyName = "Datum";
            Datum.HeaderText = "Datum i vrijeme";
            Datum.MinimumWidth = 6;
            Datum.Name = "Datum";
            Datum.ReadOnly = true;
            // 
            // Iznos
            // 
            Iznos.DataPropertyName = "Iznos";
            Iznos.HeaderText = "Iznos";
            Iznos.MinimumWidth = 6;
            Iznos.Name = "Iznos";
            Iznos.ReadOnly = true;
            Iznos.Width = 80;
            // 
            // Radnik
            // 
            Radnik.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Radnik.DataPropertyName = "Radnik";
            Radnik.HeaderText = "Uradio";
            Radnik.MinimumWidth = 6;
            Radnik.Name = "Radnik";
            Radnik.ReadOnly = true;
            // 
            // Uredi
            // 
            Uredi.HeaderText = "";
            Uredi.MinimumWidth = 6;
            Uredi.Name = "Uredi";
            Uredi.ReadOnly = true;
            Uredi.Text = "Uredi";
            Uredi.UseColumnTextForButtonValue = true;
            Uredi.Width = 80;
            // 
            // Obrisi
            // 
            Obrisi.HeaderText = "";
            Obrisi.MinimumWidth = 6;
            Obrisi.Name = "Obrisi";
            Obrisi.ReadOnly = true;
            Obrisi.Text = "Obriši";
            Obrisi.UseColumnTextForButtonValue = true;
            Obrisi.Width = 80;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // lblUkupno
            // 
            lblUkupno.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblUkupno.Location = new Point(12, 539);
            lblUkupno.Name = "lblUkupno";
            lblUkupno.Size = new Size(404, 54);
            lblUkupno.TabIndex = 5;
            lblUkupno.Text = "Ukupno :";
            lblUkupno.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnBack.Location = new Point(161, 7);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(69, 50);
            btnBack.TabIndex = 8;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnNext.Location = new Point(702, 7);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(69, 50);
            btnNext.TabIndex = 9;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // dtpDatumFilter
            // 
            dtpDatumFilter.Font = new Font("Segoe UI", 18F);
            dtpDatumFilter.Location = new Point(236, 9);
            dtpDatumFilter.Name = "dtpDatumFilter";
            dtpDatumFilter.Size = new Size(460, 47);
            dtpDatumFilter.TabIndex = 8;
            dtpDatumFilter.ValueChanged += dtpDatumFilter_ValueChanged;
            // 
            // btnIzvjestaj
            // 
            btnIzvjestaj.Location = new Point(998, 549);
            btnIzvjestaj.Name = "btnIzvjestaj";
            btnIzvjestaj.Size = new Size(180, 29);
            btnIzvjestaj.TabIndex = 9;
            btnIzvjestaj.Text = "Dnevni izvještaj";
            btnIzvjestaj.UseVisualStyleBackColor = true;
            btnIzvjestaj.Click += btnIzvjestaj_Click;
            // 
            // lblProcenti
            // 
            lblProcenti.AutoSize = true;
            lblProcenti.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProcenti.Location = new Point(19, 593);
            lblProcenti.Name = "lblProcenti";
            lblProcenti.Size = new Size(49, 92);
            lblProcenti.TabIndex = 10;
            lblProcenti.Text = "Seno\r\nSaid\r\nHare\r\nBeli";
            // 
            // btnVulkanizerska
            // 
            btnVulkanizerska.Location = new Point(161, 63);
            btnVulkanizerska.Name = "btnVulkanizerska";
            btnVulkanizerska.Size = new Size(167, 43);
            btnVulkanizerska.TabIndex = 11;
            btnVulkanizerska.Text = "Vulkanizerska";
            btnVulkanizerska.UseVisualStyleBackColor = true;
            btnVulkanizerska.Click += btnVulkanizerska_Click;
            // 
            // btnPraonica
            // 
            btnPraonica.Location = new Point(334, 63);
            btnPraonica.Name = "btnPraonica";
            btnPraonica.Size = new Size(167, 43);
            btnPraonica.TabIndex = 11;
            btnPraonica.Text = "Praonica";
            btnPraonica.UseVisualStyleBackColor = true;
            btnPraonica.Click += btnPraonica_Click;
            // 
            // lblVrsta
            // 
            lblVrsta.AutoSize = true;
            lblVrsta.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblVrsta.Location = new Point(791, 12);
            lblVrsta.Name = "lblVrsta";
            lblVrsta.Size = new Size(264, 41);
            lblVrsta.TabIndex = 12;
            lblVrsta.Text = "Vrsta placeholder";
            // 
            // btnFaktura
            // 
            btnFaktura.Location = new Point(828, 549);
            btnFaktura.Name = "btnFaktura";
            btnFaktura.Size = new Size(153, 29);
            btnFaktura.TabIndex = 13;
            btnFaktura.Text = "Napravi fakturu";
            btnFaktura.UseVisualStyleBackColor = true;
            btnFaktura.Click += btnFaktura_Click;
            // 
            // pbLogo
            // 
            pbLogo.Location = new Point(2, -9);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(143, 127);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 19;
            pbLogo.TabStop = false;
            // 
            // frmNalozi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 704);
            Controls.Add(pbLogo);
            Controls.Add(btnFaktura);
            Controls.Add(lblVrsta);
            Controls.Add(btnPraonica);
            Controls.Add(btnVulkanizerska);
            Controls.Add(lblProcenti);
            Controls.Add(btnIzvjestaj);
            Controls.Add(dtpDatumFilter);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(lblUkupno);
            Controls.Add(dgvNalozi);
            Controls.Add(btnDodaj);
            Controls.Add(txtIznos);
            Controls.Add(txtKolicina);
            Controls.Add(cbFirma);
            Controls.Add(cbVozilo);
            Controls.Add(cbUsluga);
            Controls.Add(cbRadnik);
            Controls.Add(lblKolicina);
            Controls.Add(lblIznos);
            Controls.Add(label4);
            Controls.Add(lblVozilo);
            Controls.Add(lblUsluga);
            Controls.Add(lblRadnik);
            Name = "frmNalozi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Viking";
            FormClosing += frmNalozi_FormClosing;
            Load += frmNalozi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNalozi).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRadnik;
        private Label lblUsluga;
        private Label lblVozilo;
        private Label label4;
        private Label lblKolicina;
        private Label lblIznos;
        private ComboBox cbRadnik;
        private ComboBox cbUsluga;
        private TextBox txtKolicina;
        private ComboBox cbVozilo;
        private ComboBox cbFirma;
        private TextBox txtIznos;
        private Button btnDodaj;
        private DataGridView dgvNalozi;
        private ErrorProvider err;
        private Label lblUkupno;
        private Button btnBack;
        private DateTimePicker dtpDatumFilter;
        private Button btnNext;
        private Button btnIzvjestaj;
        private Label lblProcenti;
        private Label lblVrsta;
        private Button btnPraonica;
        private Button btnVulkanizerska;
        private DataGridViewTextBoxColumn Vozilo;
        private DataGridViewTextBoxColumn Usluga;
        private DataGridViewTextBoxColumn Kolicina;
        private DataGridViewTextBoxColumn Firma;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewTextBoxColumn Iznos;
        private DataGridViewTextBoxColumn Radnik;
        private DataGridViewButtonColumn Uredi;
        private DataGridViewButtonColumn Obrisi;
        private Button btnFaktura;
        private PictureBox pbLogo;
    }
}