namespace SqlGuiApplication.View
{
    partial class KategorilerForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnListele = new Button();
            btnKaydet = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            dgvKategoriler = new DataGridView();
            tbKategoriID = new TextBox();
            tbKategoriAd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKategoriler).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(42, 54, 80);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.329113F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.67088F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 504F));
            tableLayoutPanel1.Controls.Add(btnListele, 2, 0);
            tableLayoutPanel1.Controls.Add(btnKaydet, 2, 1);
            tableLayoutPanel1.Controls.Add(btnSil, 2, 2);
            tableLayoutPanel1.Controls.Add(btnGuncelle, 2, 3);
            tableLayoutPanel1.Controls.Add(dgvKategoriler, 0, 4);
            tableLayoutPanel1.Controls.Add(tbKategoriID, 1, 1);
            tableLayoutPanel1.Controls.Add(tbKategoriAd, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.7647047F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.7647057F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.7647057F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.7647057F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.9411774F));
            tableLayoutPanel1.Size = new Size(900, 574);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnListele
            // 
            btnListele.Dock = DockStyle.Fill;
            btnListele.FlatStyle = FlatStyle.Flat;
            btnListele.ForeColor = Color.White;
            btnListele.Location = new Point(398, 3);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(499, 61);
            btnListele.TabIndex = 2;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.Dock = DockStyle.Fill;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(398, 70);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(499, 61);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Dock = DockStyle.Fill;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(398, 137);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(499, 61);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Dock = DockStyle.Fill;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(398, 204);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(499, 61);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // dgvKategoriler
            // 
            dgvKategoriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dgvKategoriler, 3);
            dgvKategoriler.Dock = DockStyle.Fill;
            dgvKategoriler.Location = new Point(3, 271);
            dgvKategoriler.Name = "dgvKategoriler";
            dgvKategoriler.RowHeadersWidth = 51;
            dgvKategoriler.RowTemplate.Height = 29;
            dgvKategoriler.Size = new Size(894, 300);
            dgvKategoriler.TabIndex = 3;
            // 
            // tbKategoriID
            // 
            tbKategoriID.Dock = DockStyle.Fill;
            tbKategoriID.Location = new Point(107, 70);
            tbKategoriID.Multiline = true;
            tbKategoriID.Name = "tbKategoriID";
            tbKategoriID.Size = new Size(285, 61);
            tbKategoriID.TabIndex = 4;
            // 
            // tbKategoriAd
            // 
            tbKategoriAd.Dock = DockStyle.Fill;
            tbKategoriAd.Location = new Point(107, 137);
            tbKategoriAd.Multiline = true;
            tbKategoriAd.Name = "tbKategoriAd";
            tbKategoriAd.Size = new Size(285, 61);
            tbKategoriAd.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 67);
            label1.Name = "label1";
            label1.Size = new Size(98, 67);
            label1.TabIndex = 5;
            label1.Text = "Kategori ID:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 134);
            label2.Name = "label2";
            label2.Size = new Size(98, 67);
            label2.TabIndex = 6;
            label2.Text = "Kategori Ad:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // KategorilerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 574);
            Controls.Add(tableLayoutPanel1);
            Name = "KategorilerForm";
            Text = "KategorilerForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKategoriler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnListele;
        private Button btnKaydet;
        private Button btnSil;
        private Button btnGuncelle;
        private DataGridView dgvKategoriler;
        private TextBox tbKategoriID;
        private TextBox tbKategoriAd;
        private Label label1;
        private Label label2;
    }
}