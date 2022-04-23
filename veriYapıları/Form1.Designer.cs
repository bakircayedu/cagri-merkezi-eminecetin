namespace veriYapıları
{
    partial class Form1
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
            this.AramaYap = new System.Windows.Forms.Button();
            this.ZamanBilgisi = new System.Windows.Forms.ListBox();
            this.AramaSon = new System.Windows.Forms.Button();
            this.TemsilciSec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.AramaSonucu = new System.Windows.Forms.ListBox();
            this.CagriBilgisi = new System.Windows.Forms.ListBox();
            this.CagriBilgisiGetir = new System.Windows.Forms.Button();
            this.KelimeBul = new System.Windows.Forms.Button();
            this.CagriNotOrnek = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AramaYap
            // 
            this.AramaYap.Location = new System.Drawing.Point(7, 181);
            this.AramaYap.Name = "AramaYap";
            this.AramaYap.Size = new System.Drawing.Size(141, 38);
            this.AramaYap.TabIndex = 0;
            this.AramaYap.Text = "AramaYap";
            this.AramaYap.UseVisualStyleBackColor = true;
            this.AramaYap.Click += new System.EventHandler(this.AramaYap_Click);
            // 
            // ZamanBilgisi
            // 
            this.ZamanBilgisi.FormattingEnabled = true;
            this.ZamanBilgisi.ItemHeight = 25;
            this.ZamanBilgisi.Location = new System.Drawing.Point(12, 39);
            this.ZamanBilgisi.Name = "ZamanBilgisi";
            this.ZamanBilgisi.Size = new System.Drawing.Size(136, 104);
            this.ZamanBilgisi.TabIndex = 1;
            // 
            // AramaSon
            // 
            this.AramaSon.Location = new System.Drawing.Point(7, 259);
            this.AramaSon.Name = "AramaSon";
            this.AramaSon.Size = new System.Drawing.Size(178, 38);
            this.AramaSon.TabIndex = 2;
            this.AramaSon.Text = "Arama Sonlandır";
            this.AramaSon.UseVisualStyleBackColor = true;
            this.AramaSon.Click += new System.EventHandler(this.AramaSon_Click);
            // 
            // TemsilciSec
            // 
            this.TemsilciSec.Location = new System.Drawing.Point(294, 245);
            this.TemsilciSec.Name = "TemsilciSec";
            this.TemsilciSec.Size = new System.Drawing.Size(158, 52);
            this.TemsilciSec.TabIndex = 3;
            this.TemsilciSec.Text = "Çağrıyı Ata";
            this.TemsilciSec.UseVisualStyleBackColor = true;
            this.TemsilciSec.Click += new System.EventHandler(this.TemsilciSec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Müşteri Türü Seçiniz:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "1-Ahmet Kulaç (ticari temsilci)",
            "2-Yaren Ataşer(ticari temsilci)",
            "3-Sude Terim(bireysel temsilci)",
            "4-Berke Coşgun(biraysel temsilci)"});
            this.checkedListBox1.Location = new System.Drawing.Point(229, 103);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(299, 116);
            this.checkedListBox1.TabIndex = 7;
            // 
            // AramaSonucu
            // 
            this.AramaSonucu.FormattingEnabled = true;
            this.AramaSonucu.ItemHeight = 25;
            this.AramaSonucu.Location = new System.Drawing.Point(1038, 23);
            this.AramaSonucu.Name = "AramaSonucu";
            this.AramaSonucu.Size = new System.Drawing.Size(220, 154);
            this.AramaSonucu.TabIndex = 8;
            // 
            // CagriBilgisi
            // 
            this.CagriBilgisi.FormattingEnabled = true;
            this.CagriBilgisi.ItemHeight = 25;
            this.CagriBilgisi.Location = new System.Drawing.Point(65, 417);
            this.CagriBilgisi.Name = "CagriBilgisi";
            this.CagriBilgisi.Size = new System.Drawing.Size(290, 179);
            this.CagriBilgisi.TabIndex = 9;
            // 
            // CagriBilgisiGetir
            // 
            this.CagriBilgisiGetir.Location = new System.Drawing.Point(390, 470);
            this.CagriBilgisiGetir.Name = "CagriBilgisiGetir";
            this.CagriBilgisiGetir.Size = new System.Drawing.Size(221, 47);
            this.CagriBilgisiGetir.TabIndex = 10;
            this.CagriBilgisiGetir.Text = "Çağrı Bilgilerini Getir";
            this.CagriBilgisiGetir.UseVisualStyleBackColor = true;
            this.CagriBilgisiGetir.Click += new System.EventHandler(this.CagriBilgisiGetir_Click);
            // 
            // KelimeBul
            // 
            this.KelimeBul.Location = new System.Drawing.Point(872, 120);
            this.KelimeBul.Name = "KelimeBul";
            this.KelimeBul.Size = new System.Drawing.Size(147, 40);
            this.KelimeBul.TabIndex = 11;
            this.KelimeBul.Text = "Kelime Bul";
            this.KelimeBul.UseVisualStyleBackColor = true;
            this.KelimeBul.Click += new System.EventHandler(this.KelimeBul_Click);
            // 
            // CagriNotOrnek
            // 
            this.CagriNotOrnek.Location = new System.Drawing.Point(869, 445);
            this.CagriNotOrnek.Multiline = true;
            this.CagriNotOrnek.Name = "CagriNotOrnek";
            this.CagriNotOrnek.Size = new System.Drawing.Size(298, 95);
            this.CagriNotOrnek.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(869, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Çağrı not örneği";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(869, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Aranacak Kelime";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(869, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 31);
            this.textBox1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 683);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CagriNotOrnek);
            this.Controls.Add(this.KelimeBul);
            this.Controls.Add(this.CagriBilgisiGetir);
            this.Controls.Add(this.CagriBilgisi);
            this.Controls.Add(this.AramaSonucu);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TemsilciSec);
            this.Controls.Add(this.AramaSon);
            this.Controls.Add(this.ZamanBilgisi);
            this.Controls.Add(this.AramaYap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AramaYap;
        private ListBox ZamanBilgisi;
        private Button AramaSon;
        private Button TemsilciSec;
        private Label label1;
        private CheckedListBox checkedListBox1;
        private ListBox AramaSonucu;
        private ListBox CagriBilgisi;
        private Button CagriBilgisiGetir;
        private Button KelimeBul;
        private TextBox CagriNotOrnek;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
    }
}