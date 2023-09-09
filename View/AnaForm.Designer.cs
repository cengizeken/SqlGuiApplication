namespace SqlGuiApplication
{
    partial class AnaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            btnSqlQueryPanel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            btnAyarlar = new Button();
            btnIslemlerHareketler = new Button();
            btnUrunler = new Button();
            btnSifreKullanicilar = new Button();
            btnMusteriler = new Button();
            btnIstatistikler = new Button();
            btnPersoneller = new Button();
            btnKategoriler = new Button();
            btnKasa = new Button();
            btnCikis = new Button();
            splitContainer1 = new SplitContainer();
            btnSqlQueryPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSqlQueryPanel
            // 
            btnSqlQueryPanel.BackColor = SystemColors.ActiveCaption;
            btnSqlQueryPanel.Controls.Add(tableLayoutPanel1);
            btnSqlQueryPanel.Dock = DockStyle.Fill;
            btnSqlQueryPanel.Location = new Point(0, 0);
            btnSqlQueryPanel.Name = "btnSqlQueryPanel";
            btnSqlQueryPanel.Size = new Size(354, 576);
            btnSqlQueryPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(42, 54, 80);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.4689274F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.5310745F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(btnAyarlar, 1, 8);
            tableLayoutPanel1.Controls.Add(btnIslemlerHareketler, 1, 7);
            tableLayoutPanel1.Controls.Add(btnUrunler, 1, 0);
            tableLayoutPanel1.Controls.Add(btnSifreKullanicilar, 1, 6);
            tableLayoutPanel1.Controls.Add(btnMusteriler, 1, 1);
            tableLayoutPanel1.Controls.Add(btnIstatistikler, 1, 5);
            tableLayoutPanel1.Controls.Add(btnPersoneller, 1, 3);
            tableLayoutPanel1.Controls.Add(btnKategoriler, 1, 2);
            tableLayoutPanel1.Controls.Add(btnKasa, 1, 4);
            tableLayoutPanel1.Controls.Add(btnCikis, 1, 9);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.999433F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.99943352F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.99943352F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.99943352F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.99943352F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.99943352F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0014324F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0014324F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0014324F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.999099F));
            tableLayoutPanel1.Size = new Size(354, 576);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnAyarlar
            // 
            btnAyarlar.Dock = DockStyle.Fill;
            btnAyarlar.FlatStyle = FlatStyle.Flat;
            btnAyarlar.ForeColor = Color.White;
            btnAyarlar.Location = new Point(79, 459);
            btnAyarlar.Name = "btnAyarlar";
            btnAyarlar.Size = new Size(272, 51);
            btnAyarlar.TabIndex = 1;
            btnAyarlar.Text = "Ayarlar";
            btnAyarlar.UseVisualStyleBackColor = true;
            // 
            // btnIslemlerHareketler
            // 
            btnIslemlerHareketler.Dock = DockStyle.Fill;
            btnIslemlerHareketler.FlatStyle = FlatStyle.Flat;
            btnIslemlerHareketler.ForeColor = Color.White;
            btnIslemlerHareketler.Location = new Point(79, 402);
            btnIslemlerHareketler.Name = "btnIslemlerHareketler";
            btnIslemlerHareketler.Size = new Size(272, 51);
            btnIslemlerHareketler.TabIndex = 1;
            btnIslemlerHareketler.Text = "İşlemler ve Hareketler";
            btnIslemlerHareketler.UseVisualStyleBackColor = true;
            // 
            // btnUrunler
            // 
            btnUrunler.Dock = DockStyle.Fill;
            btnUrunler.FlatStyle = FlatStyle.Flat;
            btnUrunler.ForeColor = Color.White;
            btnUrunler.Location = new Point(79, 3);
            btnUrunler.Name = "btnUrunler";
            btnUrunler.Size = new Size(272, 51);
            btnUrunler.TabIndex = 1;
            btnUrunler.Text = "Ürünler";
            btnUrunler.UseVisualStyleBackColor = true;
            // 
            // btnSifreKullanicilar
            // 
            btnSifreKullanicilar.Dock = DockStyle.Fill;
            btnSifreKullanicilar.FlatStyle = FlatStyle.Flat;
            btnSifreKullanicilar.ForeColor = Color.White;
            btnSifreKullanicilar.Location = new Point(79, 345);
            btnSifreKullanicilar.Name = "btnSifreKullanicilar";
            btnSifreKullanicilar.Size = new Size(272, 51);
            btnSifreKullanicilar.TabIndex = 1;
            btnSifreKullanicilar.Text = "Şifre ve Kullanıcılar";
            btnSifreKullanicilar.UseVisualStyleBackColor = true;
            // 
            // btnMusteriler
            // 
            btnMusteriler.Dock = DockStyle.Fill;
            btnMusteriler.FlatStyle = FlatStyle.Flat;
            btnMusteriler.ForeColor = Color.White;
            btnMusteriler.Location = new Point(79, 60);
            btnMusteriler.Name = "btnMusteriler";
            btnMusteriler.Size = new Size(272, 51);
            btnMusteriler.TabIndex = 1;
            btnMusteriler.Text = "Müşteriler";
            btnMusteriler.UseVisualStyleBackColor = true;
            // 
            // btnIstatistikler
            // 
            btnIstatistikler.Dock = DockStyle.Fill;
            btnIstatistikler.FlatStyle = FlatStyle.Flat;
            btnIstatistikler.ForeColor = Color.White;
            btnIstatistikler.Location = new Point(79, 288);
            btnIstatistikler.Name = "btnIstatistikler";
            btnIstatistikler.Size = new Size(272, 51);
            btnIstatistikler.TabIndex = 1;
            btnIstatistikler.Text = "İstatistikler";
            btnIstatistikler.UseVisualStyleBackColor = true;
            // 
            // btnPersoneller
            // 
            btnPersoneller.Dock = DockStyle.Fill;
            btnPersoneller.FlatStyle = FlatStyle.Flat;
            btnPersoneller.ForeColor = Color.White;
            btnPersoneller.Location = new Point(79, 174);
            btnPersoneller.Name = "btnPersoneller";
            btnPersoneller.Size = new Size(272, 51);
            btnPersoneller.TabIndex = 1;
            btnPersoneller.Text = "Personeller";
            btnPersoneller.UseVisualStyleBackColor = true;
            // 
            // btnKategoriler
            // 
            btnKategoriler.Dock = DockStyle.Fill;
            btnKategoriler.FlatStyle = FlatStyle.Flat;
            btnKategoriler.ForeColor = Color.White;
            btnKategoriler.Image = Properties.Resources.Category_1;
            btnKategoriler.ImageAlign = ContentAlignment.MiddleLeft;
            btnKategoriler.Location = new Point(79, 117);
            btnKategoriler.Name = "btnKategoriler";
            btnKategoriler.Size = new Size(272, 51);
            btnKategoriler.TabIndex = 1;
            btnKategoriler.Text = "Kategoriler";
            btnKategoriler.UseVisualStyleBackColor = true;
            btnKategoriler.Click += btnKategoriler_Click;
            // 
            // btnKasa
            // 
            btnKasa.Dock = DockStyle.Fill;
            btnKasa.FlatStyle = FlatStyle.Flat;
            btnKasa.ForeColor = Color.White;
            btnKasa.Location = new Point(79, 231);
            btnKasa.Name = "btnKasa";
            btnKasa.Size = new Size(272, 51);
            btnKasa.TabIndex = 1;
            btnKasa.Text = "Kasa";
            btnKasa.UseVisualStyleBackColor = true;
            // 
            // btnCikis
            // 
            btnCikis.Dock = DockStyle.Fill;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.ForeColor = Color.White;
            btnCikis.Location = new Point(79, 516);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(272, 57);
            btnCikis.TabIndex = 1;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnSqlQueryPanel);
            splitContainer1.Size = new Size(944, 576);
            splitContainer1.SplitterDistance = 354;
            splitContainer1.TabIndex = 1;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 576);
            Controls.Add(splitContainer1);
            Name = "AnaForm";
            Text = "SQL Veri Kayıt";
            btnSqlQueryPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel btnSqlQueryPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnUrunler;
        private Button btnAyarlar;
        private Button btnIslemlerHareketler;
        private Button btnSifreKullanicilar;
        private Button btnMusteriler;
        private Button btnIstatistikler;
        private Button btnPersoneller;
        private Button btnKategoriler;
        private Button btnKasa;
        private Button btnCikis;
        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
    }
}