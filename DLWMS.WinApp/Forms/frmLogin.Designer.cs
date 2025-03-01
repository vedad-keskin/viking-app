namespace DLWMS.WinApp.Forms
{
    partial class frmLogin
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
            pbLogo = new PictureBox();
            lblKorisnickoIme = new Label();
            lblLozinka = new Label();
            btnPrijava = new Button();
            txtLozinka = new TextBox();
            txtKorisnickoIme = new TextBox();
            lblLinija = new Label();
            err = new ErrorProvider(components);
            lblVerzija = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Location = new Point(7, 15);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(308, 293);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // lblKorisnickoIme
            // 
            lblKorisnickoIme.AutoSize = true;
            lblKorisnickoIme.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblKorisnickoIme.ForeColor = SystemColors.ActiveCaptionText;
            lblKorisnickoIme.Location = new Point(406, 25);
            lblKorisnickoIme.Name = "lblKorisnickoIme";
            lblKorisnickoIme.Size = new Size(233, 41);
            lblKorisnickoIme.TabIndex = 1;
            lblKorisnickoIme.Text = "Korisničko ime:";
            // 
            // lblLozinka
            // 
            lblLozinka.AutoSize = true;
            lblLozinka.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblLozinka.ForeColor = SystemColors.ActiveCaptionText;
            lblLozinka.Location = new Point(406, 122);
            lblLozinka.Name = "lblLozinka";
            lblLozinka.Size = new Size(133, 41);
            lblLozinka.TabIndex = 1;
            lblLozinka.Text = "Lozinka:";
            // 
            // btnPrijava
            // 
            btnPrijava.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnPrijava.Location = new Point(614, 229);
            btnPrijava.Name = "btnPrijava";
            btnPrijava.Size = new Size(198, 56);
            btnPrijava.TabIndex = 3;
            btnPrijava.Text = "Prijavi se";
            btnPrijava.UseVisualStyleBackColor = true;
            btnPrijava.Click += btnPrijava_Click;
            // 
            // txtLozinka
            // 
            txtLozinka.Font = new Font("Segoe UI", 18F);
            txtLozinka.Location = new Point(406, 166);
            txtLozinka.Name = "txtLozinka";
            txtLozinka.Size = new Size(406, 47);
            txtLozinka.TabIndex = 2;
            txtLozinka.UseSystemPasswordChar = true;
            // 
            // txtKorisnickoIme
            // 
            txtKorisnickoIme.Font = new Font("Segoe UI", 18F);
            txtKorisnickoIme.Location = new Point(406, 72);
            txtKorisnickoIme.Name = "txtKorisnickoIme";
            txtKorisnickoIme.Size = new Size(406, 47);
            txtKorisnickoIme.TabIndex = 1;
            // 
            // lblLinija
            // 
            lblLinija.BackColor = SystemColors.ActiveCaptionText;
            lblLinija.Font = new Font("Segoe UI", 5F);
            lblLinija.Location = new Point(324, 36);
            lblLinija.Name = "lblLinija";
            lblLinija.Size = new Size(5, 247);
            lblLinija.TabIndex = 5;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // lblVerzija
            // 
            lblVerzija.AutoSize = true;
            lblVerzija.Location = new Point(30, 304);
            lblVerzija.Name = "lblVerzija";
            lblVerzija.Size = new Size(48, 20);
            lblVerzija.TabIndex = 6;
            lblVerzija.Text = "V1.0.0";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(847, 334);
            Controls.Add(lblVerzija);
            Controls.Add(lblLinija);
            Controls.Add(txtKorisnickoIme);
            Controls.Add(txtLozinka);
            Controls.Add(btnPrijava);
            Controls.Add(lblLozinka);
            Controls.Add(lblKorisnickoIme);
            Controls.Add(pbLogo);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Label lblKorisnickoIme;
        private Label lblLozinka;
        private Button btnPrijava;
        private TextBox txtLozinka;
        private TextBox txtKorisnickoIme;
        private Label lblLinija;
        private ErrorProvider err;
        private Label lblVerzija;
    }
}