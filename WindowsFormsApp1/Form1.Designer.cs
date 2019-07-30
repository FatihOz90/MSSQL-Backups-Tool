namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_cb_dbname = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chb_ziple = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_timeout = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.txt_yedeksaati = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_backup_patch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvl_SonYedekZamani = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_DBName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_VeritabaniListesi = new System.Windows.Forms.Label();
            this.lbl_VeritabaniBag = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hakkımdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_cb_dbname);
            this.groupBox1.Location = new System.Drawing.Point(576, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(320, 432);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veritabanı Listesi";
            // 
            // lb_cb_dbname
            // 
            this.lb_cb_dbname.FormattingEnabled = true;
            this.lb_cb_dbname.ItemHeight = 18;
            this.lb_cb_dbname.Location = new System.Drawing.Point(8, 28);
            this.lb_cb_dbname.Margin = new System.Windows.Forms.Padding(4);
            this.lb_cb_dbname.Name = "lb_cb_dbname";
            this.lb_cb_dbname.Size = new System.Drawing.Size(304, 400);
            this.lb_cb_dbname.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chb_ziple);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_timeout);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btn_Kaydet);
            this.groupBox2.Controls.Add(this.txt_yedeksaati);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tb_backup_patch);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 236);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(547, 224);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yedekleme İşlemleri";
            // 
            // chb_ziple
            // 
            this.chb_ziple.AutoSize = true;
            this.chb_ziple.Location = new System.Drawing.Point(13, 140);
            this.chb_ziple.Name = "chb_ziple";
            this.chb_ziple.Size = new System.Drawing.Size(433, 22);
            this.chb_ziple.TabIndex = 10;
            this.chb_ziple.Text = "Sıkıştırma işlemi yap  ve sıkıştırılma işlemi yapılan dosyaları sil.";
            this.chb_ziple.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(241, 101);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Saniye";
            // 
            // txt_timeout
            // 
            this.txt_timeout.Location = new System.Drawing.Point(174, 98);
            this.txt_timeout.Margin = new System.Windows.Forms.Padding(4);
            this.txt_timeout.Name = "txt_timeout";
            this.txt_timeout.Size = new System.Drawing.Size(59, 24);
            this.txt_timeout.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Zaman Aşımı :";
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(0, 192);
            this.btn_Kaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(112, 32);
            this.btn_Kaydet.TabIndex = 5;
            this.btn_Kaydet.Text = "Güncelle";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // txt_yedeksaati
            // 
            this.txt_yedeksaati.Location = new System.Drawing.Point(174, 35);
            this.txt_yedeksaati.Margin = new System.Windows.Forms.Padding(4);
            this.txt_yedeksaati.Name = "txt_yedeksaati";
            this.txt_yedeksaati.Size = new System.Drawing.Size(115, 24);
            this.txt_yedeksaati.TabIndex = 4;
            this.txt_yedeksaati.Text = "00:10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Günlük Yedek Saati :";
            // 
            // tb_backup_patch
            // 
            this.tb_backup_patch.Location = new System.Drawing.Point(174, 67);
            this.tb_backup_patch.Margin = new System.Windows.Forms.Padding(4);
            this.tb_backup_patch.Name = "tb_backup_patch";
            this.tb_backup_patch.Size = new System.Drawing.Size(327, 24);
            this.tb_backup_patch.TabIndex = 1;
            this.tb_backup_patch.Text = "NULL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Yedeklenecek dizin :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvl_SonYedekZamani);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lbl_DBName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Controls.Add(this.lbl_VeritabaniListesi);
            this.groupBox3.Controls.Add(this.lbl_VeritabaniBag);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(13, 28);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(547, 200);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Durum Bildirimleri";
            // 
            // lvl_SonYedekZamani
            // 
            this.lvl_SonYedekZamani.AutoSize = true;
            this.lvl_SonYedekZamani.Location = new System.Drawing.Point(181, 75);
            this.lvl_SonYedekZamani.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lvl_SonYedekZamani.Name = "lvl_SonYedekZamani";
            this.lvl_SonYedekZamani.Size = new System.Drawing.Size(144, 18);
            this.lvl_SonYedekZamani.TabIndex = 101;
            this.lvl_SonYedekZamani.Text = "Henüz Yedek Almadı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 18);
            this.label7.TabIndex = 100;
            this.label7.Text = "Son Yedek Tarihi";
            // 
            // lbl_DBName
            // 
            this.lbl_DBName.AutoSize = true;
            this.lbl_DBName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_DBName.Location = new System.Drawing.Point(177, 131);
            this.lbl_DBName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DBName.Name = "lbl_DBName";
            this.lbl_DBName.Size = new System.Drawing.Size(0, 14);
            this.lbl_DBName.TabIndex = 99;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(10, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Yedekleme Süreci :";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 149);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(488, 43);
            this.progressBar1.TabIndex = 7;
            // 
            // lbl_VeritabaniListesi
            // 
            this.lbl_VeritabaniListesi.AutoSize = true;
            this.lbl_VeritabaniListesi.Location = new System.Drawing.Point(181, 50);
            this.lbl_VeritabaniListesi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_VeritabaniListesi.Name = "lbl_VeritabaniListesi";
            this.lbl_VeritabaniListesi.Size = new System.Drawing.Size(77, 18);
            this.lbl_VeritabaniListesi.TabIndex = 5;
            this.lbl_VeritabaniListesi.Text = "Bağlı Değil";
            // 
            // lbl_VeritabaniBag
            // 
            this.lbl_VeritabaniBag.AutoSize = true;
            this.lbl_VeritabaniBag.Location = new System.Drawing.Point(182, 28);
            this.lbl_VeritabaniBag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_VeritabaniBag.Name = "lbl_VeritabaniBag";
            this.lbl_VeritabaniBag.Size = new System.Drawing.Size(77, 18);
            this.lbl_VeritabaniBag.TabIndex = 3;
            this.lbl_VeritabaniBag.Text = "Bağlı Değil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Veritabanı Listesi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veritabanı Bağlantısı :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkımdaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(896, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hakkımdaToolStripMenuItem
            // 
            this.hakkımdaToolStripMenuItem.Name = "hakkımdaToolStripMenuItem";
            this.hakkımdaToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.hakkımdaToolStripMenuItem.Text = "Hakkımda";
            this.hakkımdaToolStripMenuItem.Click += new System.EventHandler(this.hakkımdaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 471);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Veritabanı Yönetimi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_backup_patch;
        private System.Windows.Forms.TextBox txt_yedeksaati;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lb_cb_dbname;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_VeritabaniBag;
        private System.Windows.Forms.Label lbl_VeritabaniListesi;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lbl_DBName;
        private System.Windows.Forms.Label lvl_SonYedekZamani;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hakkımdaToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_timeout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chb_ziple;
    }
}

