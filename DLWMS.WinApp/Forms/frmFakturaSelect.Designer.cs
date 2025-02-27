namespace DLWMS.WinApp.Forms
{
    partial class frmFakturaSelect
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
            lblFirma = new Label();
            cbFirma = new ComboBox();
            lblDatumOd = new Label();
            dtpDatumOd = new DateTimePicker();
            lblDatumDo = new Label();
            dtpDatumDo = new DateTimePicker();
            label1 = new Label();
            txtRok = new TextBox();
            label2 = new Label();
            txtBroj = new TextBox();
            btnFaktura = new Button();
            btnOtkazi = new Button();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // lblFirma
            // 
            lblFirma.AutoSize = true;
            lblFirma.Location = new Point(12, 66);
            lblFirma.Name = "lblFirma";
            lblFirma.Size = new Size(49, 20);
            lblFirma.TabIndex = 0;
            lblFirma.Text = "Firma:";
            // 
            // cbFirma
            // 
            cbFirma.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFirma.FormattingEnabled = true;
            cbFirma.Location = new Point(67, 63);
            cbFirma.MaxDropDownItems = 7;
            cbFirma.Name = "cbFirma";
            cbFirma.Size = new Size(188, 28);
            cbFirma.TabIndex = 7;
            // 
            // lblDatumOd
            // 
            lblDatumOd.AutoSize = true;
            lblDatumOd.Location = new Point(12, 17);
            lblDatumOd.Name = "lblDatumOd";
            lblDatumOd.Size = new Size(29, 20);
            lblDatumOd.TabIndex = 0;
            lblDatumOd.Text = "Od";
            // 
            // dtpDatumOd
            // 
            dtpDatumOd.Location = new Point(52, 14);
            dtpDatumOd.Name = "dtpDatumOd";
            dtpDatumOd.Size = new Size(270, 27);
            dtpDatumOd.TabIndex = 5;
            // 
            // lblDatumDo
            // 
            lblDatumDo.AutoSize = true;
            lblDatumDo.Location = new Point(328, 19);
            lblDatumDo.Name = "lblDatumDo";
            lblDatumDo.Size = new Size(27, 20);
            lblDatumDo.TabIndex = 0;
            lblDatumDo.Text = "do";
            // 
            // dtpDatumDo
            // 
            dtpDatumDo.Location = new Point(361, 14);
            dtpDatumDo.Name = "dtpDatumDo";
            dtpDatumDo.Size = new Size(270, 27);
            dtpDatumDo.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 67);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 0;
            label1.Text = "Rok za uplatu:";
            // 
            // txtRok
            // 
            txtRok.Location = new Point(377, 64);
            txtRok.Name = "txtRok";
            txtRok.Size = new Size(66, 27);
            txtRok.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(449, 67);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 0;
            label2.Text = "Broj ugovora:";
            // 
            // txtBroj
            // 
            txtBroj.Location = new Point(553, 63);
            txtBroj.Name = "txtBroj";
            txtBroj.Size = new Size(78, 27);
            txtBroj.TabIndex = 2;
            // 
            // btnFaktura
            // 
            btnFaktura.Location = new Point(470, 119);
            btnFaktura.Name = "btnFaktura";
            btnFaktura.Size = new Size(161, 54);
            btnFaktura.TabIndex = 3;
            btnFaktura.Text = "Napravi fakturu";
            btnFaktura.UseVisualStyleBackColor = true;
            btnFaktura.Click += btnFaktura_Click;
            // 
            // btnOtkazi
            // 
            btnOtkazi.Location = new Point(313, 119);
            btnOtkazi.Name = "btnOtkazi";
            btnOtkazi.Size = new Size(151, 54);
            btnOtkazi.TabIndex = 4;
            btnOtkazi.Text = "Otkaži";
            btnOtkazi.UseVisualStyleBackColor = true;
            btnOtkazi.Click += btnOtkazi_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmFakturaSelect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 190);
            Controls.Add(btnOtkazi);
            Controls.Add(btnFaktura);
            Controls.Add(txtBroj);
            Controls.Add(txtRok);
            Controls.Add(dtpDatumDo);
            Controls.Add(dtpDatumOd);
            Controls.Add(cbFirma);
            Controls.Add(lblDatumDo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblDatumOd);
            Controls.Add(lblFirma);
            Name = "frmFakturaSelect";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Odabir fakture";
            Load += frmFakturaSelect_Load;
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirma;
        private ComboBox cbFirma;
        private Label lblDatumOd;
        private DateTimePicker dtpDatumOd;
        private Label lblDatumDo;
        private DateTimePicker dtpDatumDo;
        private Label label1;
        private TextBox txtRok;
        private Label label2;
        private TextBox txtBroj;
        private Button btnFaktura;
        private Button btnOtkazi;
        private ErrorProvider err;
    }
}