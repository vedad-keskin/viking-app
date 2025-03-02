namespace Viking.WinApp.Forms
{
    partial class frmNaloziEdit
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
            txtIznos = new TextBox();
            txtKolicina = new TextBox();
            cbFirma = new ComboBox();
            cbVozilo = new ComboBox();
            cbUsluga = new ComboBox();
            cbRadnik = new ComboBox();
            lblKolicina = new Label();
            lblIznos = new Label();
            label4 = new Label();
            lblVozilo = new Label();
            lblUsluga = new Label();
            label1 = new Label();
            lblDatum = new Label();
            dtpDatum = new DateTimePicker();
            btnSpasi = new Button();
            btnOtkazi = new Button();
            err = new ErrorProvider(components);
            lblLinija = new Label();
            pbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // txtIznos
            // 
            txtIznos.Location = new Point(674, 108);
            txtIznos.Name = "txtIznos";
            txtIznos.Size = new Size(189, 27);
            txtIznos.TabIndex = 13;
            // 
            // txtKolicina
            // 
            txtKolicina.Location = new Point(330, 108);
            txtKolicina.Name = "txtKolicina";
            txtKolicina.Size = new Size(189, 27);
            txtKolicina.TabIndex = 14;
            // 
            // cbFirma
            // 
            cbFirma.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFirma.FormattingEnabled = true;
            cbFirma.Location = new Point(674, 68);
            cbFirma.Name = "cbFirma";
            cbFirma.Size = new Size(189, 28);
            cbFirma.TabIndex = 9;
            // 
            // cbVozilo
            // 
            cbVozilo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVozilo.FormattingEnabled = true;
            cbVozilo.Location = new Point(674, 31);
            cbVozilo.Name = "cbVozilo";
            cbVozilo.Size = new Size(189, 28);
            cbVozilo.TabIndex = 10;
            // 
            // cbUsluga
            // 
            cbUsluga.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUsluga.FormattingEnabled = true;
            cbUsluga.Location = new Point(330, 68);
            cbUsluga.Name = "cbUsluga";
            cbUsluga.Size = new Size(189, 28);
            cbUsluga.TabIndex = 11;
            // 
            // cbRadnik
            // 
            cbRadnik.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRadnik.FormattingEnabled = true;
            cbRadnik.Location = new Point(330, 30);
            cbRadnik.Name = "cbRadnik";
            cbRadnik.Size = new Size(189, 28);
            cbRadnik.TabIndex = 12;
            // 
            // lblKolicina
            // 
            lblKolicina.AutoSize = true;
            lblKolicina.Location = new Point(254, 111);
            lblKolicina.Name = "lblKolicina";
            lblKolicina.Size = new Size(65, 20);
            lblKolicina.TabIndex = 3;
            lblKolicina.Text = "Količina:";
            // 
            // lblIznos
            // 
            lblIznos.AutoSize = true;
            lblIznos.Location = new Point(598, 110);
            lblIznos.Name = "lblIznos";
            lblIznos.Size = new Size(46, 20);
            lblIznos.TabIndex = 4;
            lblIznos.Text = "Iznos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(598, 70);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 5;
            label4.Text = "Firma:";
            // 
            // lblVozilo
            // 
            lblVozilo.AutoSize = true;
            lblVozilo.Location = new Point(598, 32);
            lblVozilo.Name = "lblVozilo";
            lblVozilo.Size = new Size(53, 20);
            lblVozilo.TabIndex = 6;
            lblVozilo.Text = "Vozilo:";
            // 
            // lblUsluga
            // 
            lblUsluga.AutoSize = true;
            lblUsluga.Location = new Point(254, 71);
            lblUsluga.Name = "lblUsluga";
            lblUsluga.Size = new Size(57, 20);
            lblUsluga.TabIndex = 7;
            lblUsluga.Text = "Usluga:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(254, 33);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 8;
            label1.Text = "Radnik:";
            // 
            // lblDatum
            // 
            lblDatum.AutoSize = true;
            lblDatum.Location = new Point(254, 155);
            lblDatum.Name = "lblDatum";
            lblDatum.Size = new Size(57, 20);
            lblDatum.TabIndex = 3;
            lblDatum.Text = "Datum:";
            // 
            // dtpDatum
            // 
            dtpDatum.Location = new Point(330, 152);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(250, 27);
            dtpDatum.TabIndex = 15;
            // 
            // btnSpasi
            // 
            btnSpasi.Location = new Point(749, 151);
            btnSpasi.Name = "btnSpasi";
            btnSpasi.Size = new Size(114, 29);
            btnSpasi.TabIndex = 16;
            btnSpasi.Text = "Spasi";
            btnSpasi.UseVisualStyleBackColor = true;
            btnSpasi.Click += btnSpasi_Click;
            // 
            // btnOtkazi
            // 
            btnOtkazi.Location = new Point(629, 151);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(114, 29);
            btnOtkazi.TabIndex = 16;
            btnOtkazi.Text = "Otkaži";
            btnOtkazi.UseVisualStyleBackColor = true;
            btnOtkazi.Click += btnOtkazi_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // lblLinija
            // 
            lblLinija.BackColor = SystemColors.ActiveCaptionText;
            lblLinija.Font = new Font("Segoe UI", 5F);
            lblLinija.Location = new Point(210, 31);
            lblLinija.Name = "lblLinija";
            lblLinija.Size = new Size(3, 143);
            lblLinija.TabIndex = 18;
            // 
            // pbLogo
            // 
            pbLogo.Location = new Point(12, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(183, 169);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 17;
            pbLogo.TabStop = false;
            // 
            // frmNaloziEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 204);
            Controls.Add(lblLinija);
            Controls.Add(pbLogo);
            Controls.Add(btnOtkazi);
            Controls.Add(btnSpasi);
            Controls.Add(dtpDatum);
            Controls.Add(txtIznos);
            Controls.Add(txtKolicina);
            Controls.Add(cbFirma);
            Controls.Add(cbVozilo);
            Controls.Add(cbUsluga);
            Controls.Add(cbRadnik);
            Controls.Add(lblDatum);
            Controls.Add(lblKolicina);
            Controls.Add(lblIznos);
            Controls.Add(label4);
            Controls.Add(lblVozilo);
            Controls.Add(lblUsluga);
            Controls.Add(label1);
            Name = "frmNaloziEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Uređivanje naloga";
            Load += frmNaloziEdit_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIznos;
        private TextBox txtKolicina;
        private ComboBox cbFirma;
        private ComboBox cbVozilo;
        private ComboBox cbUsluga;
        private ComboBox cbRadnik;
        private Label lblKolicina;
        private Label lblIznos;
        private Label label4;
        private Label lblVozilo;
        private Label lblUsluga;
        private Label label1;
        private Label lblDatum;
        private DateTimePicker dtpDatum;
        private Button btnSpasi;
        private Button btnOtkazi;
        private ErrorProvider err;
        private Label lblLinija;
        private PictureBox pbLogo;
    }
}