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
            Radnik = new DataGridViewTextBoxColumn();
            Vozilo = new DataGridViewTextBoxColumn();
            Usluga = new DataGridViewTextBoxColumn();
            Kolicina = new DataGridViewTextBoxColumn();
            Firma = new DataGridViewTextBoxColumn();
            Datum = new DataGridViewTextBoxColumn();
            Iznos = new DataGridViewTextBoxColumn();
            Uredi = new DataGridViewButtonColumn();
            Obrisi = new DataGridViewButtonColumn();
            err = new ErrorProvider(components);
            lblUkupno = new Label();
            statusStrip1 = new StatusStrip();
            tsslDatumIVrijeme = new ToolStripStatusLabel();
            timer = new System.Windows.Forms.Timer(components);
            btnBack = new Button();
            btnNext = new Button();
            dtpDatumFilter = new DateTimePicker();
            btnIzvjestaj = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNalozi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblRadnik
            // 
            lblRadnik.AutoSize = true;
            lblRadnik.Location = new Point(12, 82);
            lblRadnik.Name = "lblRadnik";
            lblRadnik.Size = new Size(57, 20);
            lblRadnik.TabIndex = 0;
            lblRadnik.Text = "Radnik:";
            // 
            // lblUsluga
            // 
            lblUsluga.AutoSize = true;
            lblUsluga.Location = new Point(207, 82);
            lblUsluga.Name = "lblUsluga";
            lblUsluga.Size = new Size(57, 20);
            lblUsluga.TabIndex = 0;
            lblUsluga.Text = "Usluga:";
            // 
            // lblVozilo
            // 
            lblVozilo.AutoSize = true;
            lblVozilo.Location = new Point(536, 82);
            lblVozilo.Name = "lblVozilo";
            lblVozilo.Size = new Size(53, 20);
            lblVozilo.TabIndex = 0;
            lblVozilo.Text = "Vozilo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(731, 82);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 0;
            label4.Text = "Firma:";
            // 
            // lblKolicina
            // 
            lblKolicina.AutoSize = true;
            lblKolicina.Location = new Point(405, 82);
            lblKolicina.Name = "lblKolicina";
            lblKolicina.Size = new Size(65, 20);
            lblKolicina.TabIndex = 0;
            lblKolicina.Text = "Količina:";
            // 
            // lblIznos
            // 
            lblIznos.AutoSize = true;
            lblIznos.Location = new Point(926, 82);
            lblIznos.Name = "lblIznos";
            lblIznos.Size = new Size(46, 20);
            lblIznos.TabIndex = 0;
            lblIznos.Text = "Iznos:";
            // 
            // cbRadnik
            // 
            cbRadnik.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRadnik.FormattingEnabled = true;
            cbRadnik.Location = new Point(12, 105);
            cbRadnik.Name = "cbRadnik";
            cbRadnik.Size = new Size(189, 28);
            cbRadnik.TabIndex = 1;
            // 
            // cbUsluga
            // 
            cbUsluga.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUsluga.FormattingEnabled = true;
            cbUsluga.Location = new Point(207, 105);
            cbUsluga.Name = "cbUsluga";
            cbUsluga.Size = new Size(189, 28);
            cbUsluga.TabIndex = 1;
            // 
            // txtKolicina
            // 
            txtKolicina.Location = new Point(405, 105);
            txtKolicina.Name = "txtKolicina";
            txtKolicina.Size = new Size(125, 27);
            txtKolicina.TabIndex = 2;
            // 
            // cbVozilo
            // 
            cbVozilo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVozilo.FormattingEnabled = true;
            cbVozilo.Location = new Point(536, 105);
            cbVozilo.Name = "cbVozilo";
            cbVozilo.Size = new Size(189, 28);
            cbVozilo.TabIndex = 1;
            // 
            // cbFirma
            // 
            cbFirma.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFirma.FormattingEnabled = true;
            cbFirma.Location = new Point(731, 104);
            cbFirma.Name = "cbFirma";
            cbFirma.Size = new Size(189, 28);
            cbFirma.TabIndex = 1;
            // 
            // txtIznos
            // 
            txtIznos.Location = new Point(926, 106);
            txtIznos.Name = "txtIznos";
            txtIznos.Size = new Size(125, 27);
            txtIznos.TabIndex = 2;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(1057, 106);
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
            dgvNalozi.Columns.AddRange(new DataGridViewColumn[] { Radnik, Vozilo, Usluga, Kolicina, Firma, Datum, Iznos, Uredi, Obrisi });
            dgvNalozi.Location = new Point(12, 139);
            dgvNalozi.Name = "dgvNalozi";
            dgvNalozi.ReadOnly = true;
            dgvNalozi.RowHeadersWidth = 51;
            dgvNalozi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNalozi.Size = new Size(1166, 362);
            dgvNalozi.TabIndex = 4;
            dgvNalozi.CellClick += dgvNalozi_CellClick;
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
            lblUkupno.Font = new Font("Segoe UI", 18F);
            lblUkupno.Location = new Point(12, 507);
            lblUkupno.Name = "lblUkupno";
            lblUkupno.Size = new Size(241, 54);
            lblUkupno.TabIndex = 5;
            lblUkupno.Text = "Ukupno :";
            lblUkupno.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslDatumIVrijeme });
            statusStrip1.Location = new Point(0, 575);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1190, 26);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsslDatumIVrijeme
            // 
            tsslDatumIVrijeme.Name = "tsslDatumIVrijeme";
            tsslDatumIVrijeme.Size = new Size(115, 20);
            tsslDatumIVrijeme.Text = "Datum i vrijeme";
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 60000;
            timer.Tick += timer_Tick;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(69, 50);
            btnBack.TabIndex = 7;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnNext.Location = new Point(553, 12);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(69, 50);
            btnNext.TabIndex = 7;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // dtpDatumFilter
            // 
            dtpDatumFilter.Font = new Font("Segoe UI", 18F);
            dtpDatumFilter.Location = new Point(87, 14);
            dtpDatumFilter.Name = "dtpDatumFilter";
            dtpDatumFilter.Size = new Size(460, 47);
            dtpDatumFilter.TabIndex = 8;
            dtpDatumFilter.ValueChanged += dtpDatumFilter_ValueChanged;
            // 
            // btnIzvjestaj
            // 
            btnIzvjestaj.Location = new Point(998, 517);
            btnIzvjestaj.Name = "btnIzvjestaj";
            btnIzvjestaj.Size = new Size(180, 29);
            btnIzvjestaj.TabIndex = 9;
            btnIzvjestaj.Text = "Dnevni izvještaj";
            btnIzvjestaj.UseVisualStyleBackColor = true;
            btnIzvjestaj.Click += btnIzvjestaj_Click;
            // 
            // frmNalozi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 601);
            Controls.Add(btnIzvjestaj);
            Controls.Add(dtpDatumFilter);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(statusStrip1);
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
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private DataGridViewTextBoxColumn Radnik;
        private DataGridViewTextBoxColumn Vozilo;
        private DataGridViewTextBoxColumn Usluga;
        private DataGridViewTextBoxColumn Kolicina;
        private DataGridViewTextBoxColumn Firma;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewTextBoxColumn Iznos;
        private DataGridViewButtonColumn Uredi;
        private DataGridViewButtonColumn Obrisi;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslDatumIVrijeme;
        private System.Windows.Forms.Timer timer;
        private Button btnBack;
        private DateTimePicker dtpDatumFilter;
        private Button btnNext;
        private Button btnIzvjestaj;
    }
}