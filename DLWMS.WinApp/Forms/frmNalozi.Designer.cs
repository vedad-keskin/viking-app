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
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvNalozi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // lblRadnik
            // 
            lblRadnik.AutoSize = true;
            lblRadnik.Location = new Point(12, 26);
            lblRadnik.Name = "lblRadnik";
            lblRadnik.Size = new Size(57, 20);
            lblRadnik.TabIndex = 0;
            lblRadnik.Text = "Radnik:";
            // 
            // lblUsluga
            // 
            lblUsluga.AutoSize = true;
            lblUsluga.Location = new Point(207, 26);
            lblUsluga.Name = "lblUsluga";
            lblUsluga.Size = new Size(57, 20);
            lblUsluga.TabIndex = 0;
            lblUsluga.Text = "Usluga:";
            // 
            // lblVozilo
            // 
            lblVozilo.AutoSize = true;
            lblVozilo.Location = new Point(536, 26);
            lblVozilo.Name = "lblVozilo";
            lblVozilo.Size = new Size(53, 20);
            lblVozilo.TabIndex = 0;
            lblVozilo.Text = "Vozilo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(731, 26);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 0;
            label4.Text = "Firma:";
            // 
            // lblKolicina
            // 
            lblKolicina.AutoSize = true;
            lblKolicina.Location = new Point(405, 26);
            lblKolicina.Name = "lblKolicina";
            lblKolicina.Size = new Size(65, 20);
            lblKolicina.TabIndex = 0;
            lblKolicina.Text = "Količina:";
            // 
            // lblIznos
            // 
            lblIznos.AutoSize = true;
            lblIznos.Location = new Point(926, 26);
            lblIznos.Name = "lblIznos";
            lblIznos.Size = new Size(46, 20);
            lblIznos.TabIndex = 0;
            lblIznos.Text = "Iznos:";
            // 
            // cbRadnik
            // 
            cbRadnik.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRadnik.FormattingEnabled = true;
            cbRadnik.Location = new Point(12, 49);
            cbRadnik.Name = "cbRadnik";
            cbRadnik.Size = new Size(189, 28);
            cbRadnik.TabIndex = 1;
            // 
            // cbUsluga
            // 
            cbUsluga.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUsluga.FormattingEnabled = true;
            cbUsluga.Location = new Point(207, 49);
            cbUsluga.Name = "cbUsluga";
            cbUsluga.Size = new Size(189, 28);
            cbUsluga.TabIndex = 1;
            // 
            // txtKolicina
            // 
            txtKolicina.Location = new Point(405, 49);
            txtKolicina.Name = "txtKolicina";
            txtKolicina.Size = new Size(125, 27);
            txtKolicina.TabIndex = 2;
            // 
            // cbVozilo
            // 
            cbVozilo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVozilo.FormattingEnabled = true;
            cbVozilo.Location = new Point(536, 49);
            cbVozilo.Name = "cbVozilo";
            cbVozilo.Size = new Size(189, 28);
            cbVozilo.TabIndex = 1;
            // 
            // cbFirma
            // 
            cbFirma.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFirma.FormattingEnabled = true;
            cbFirma.Location = new Point(731, 48);
            cbFirma.Name = "cbFirma";
            cbFirma.Size = new Size(189, 28);
            cbFirma.TabIndex = 1;
            // 
            // txtIznos
            // 
            txtIznos.Location = new Point(926, 50);
            txtIznos.Name = "txtIznos";
            txtIznos.Size = new Size(125, 27);
            txtIznos.TabIndex = 2;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(1057, 50);
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
            dgvNalozi.Columns.AddRange(new DataGridViewColumn[] { Radnik, Vozilo, Usluga, Kolicina, Firma, Datum, Iznos });
            dgvNalozi.Location = new Point(12, 83);
            dgvNalozi.Name = "dgvNalozi";
            dgvNalozi.ReadOnly = true;
            dgvNalozi.RowHeadersWidth = 51;
            dgvNalozi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNalozi.Size = new Size(1166, 413);
            dgvNalozi.TabIndex = 4;
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
            Iznos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Iznos.DataPropertyName = "Iznos";
            Iznos.HeaderText = "Iznos";
            Iznos.MinimumWidth = 6;
            Iznos.Name = "Iznos";
            Iznos.ReadOnly = true;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmNalozi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 508);
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
            Text = "Placeholder";
            Load += frmNalozi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNalozi).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
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
        private DataGridViewTextBoxColumn Radnik;
        private DataGridViewTextBoxColumn Vozilo;
        private DataGridViewTextBoxColumn Usluga;
        private DataGridViewTextBoxColumn Kolicina;
        private DataGridViewTextBoxColumn Firma;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewTextBoxColumn Iznos;
        private ErrorProvider err;
    }
}