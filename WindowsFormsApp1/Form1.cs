using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Timers;
using System.IO;
using SqlBackupTools;
using System.Threading;
using Ionic.Zip;

namespace WindowsFormsApp1
{

    public static class SqlExtensions
    {
        public static bool IsAvailable(this SqlConnection bag)
        {
            try
            {
                bag.Open();
            }
            catch (SqlException)
            {
                return false;
            }
            return true;
        }
    }


    public partial class Form1 : Form
    {
        DosyaIslemleri FileManager = new DosyaIslemleri();
        private string SaatKactaYedekAl, DizinBilgisiniAl, DosyaOku_timeout, DosyaOku_ziple, buguntarih;
        bool Yedeklemeislemibittimi        = true;
        SqlConnection bag               = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Trusted_Connection=Yes;");
        public ProgressBar              publicprogressbar;
        int SleepTime                   = 10000;
        //Tarih işlemleri
        
        public Form1()
        {
            InitializeComponent();
            BugunTarih();
        }

        void BugunTarih()
        {
            DateTime dt = DateTime.Today;
            int yil = dt.Year;
            int ay = dt.Month;
            int gun = dt.Day;
            buguntarih = Convert.ToString(yil + "_" + ay + "_" + gun);
        }


        public void GetDatabaseList()
        {
            if (lb_cb_dbname.Items.Count > 0)
                lb_cb_dbname.Items.Clear();

                if (bag.IsAvailable())
                {
                    SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", bag);
                    cmd.Parameters.AddWithValue("@p1", lb_cb_dbname.Text);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        //Eğer Pas geçmesini istediğiniz bir veri tabanı var ise buraya yazınız.
                        if (dr[0].ToString() == "master" || dr[0].ToString() == "tempdb" ||
                            dr[0].ToString() == "model" ||
                            dr[0].ToString() == "msdb")
                        {
                            //MessageBox.Show("MS-SQL Veritabanı pas geçildi.");
                        }
                        else
                        {
                            lb_cb_dbname.Items.Add(dr[0].ToString());
                        }
                    }
                    lbl_VeritabaniListesi.Text = "Tablolar Listelendi";
                    bag.Close();
                }
                else
                {
                    MessageBox.Show("Veritabanı Başarısız.");
                }
        }

        public void FullBackup()
        {
            if (tb_backup_patch.ToString() == "" || tb_backup_patch.ToString() == null)
            {
                MessageBox.Show("Yedekleme dizini boş görünüyor.");
            }

            if (lb_cb_dbname.Items.Count == 0)
            {
                MessageBox.Show("Veritabanı Adı Girilmedi.");
            }

            bag.Open();
            SqlCommand command;
            foreach (var listBoxItem in lb_cb_dbname.Items)
            {
                string BackupDBFullName = buguntarih+"_"+listBoxItem.ToString() + ".bak";
                string BackupDBFullDir = tb_backup_patch.Text + "\\" + BackupDBFullName;

                if(File.Exists(BackupDBFullDir))
                {
                    bag.Close();
                    //MessageBox.Show("Yedekleme Mevcuttur. İşlem iptal edildi");
                    return;
                }

                command = new SqlCommand(@"backup database " + listBoxItem.ToString() + " to disk ='" + tb_backup_patch.Text + "\\" + BackupDBFullName + "' with init,stats=10", bag);
                command.CommandTimeout = Convert.ToInt32(DosyaOku_timeout);
                command.ExecuteNonQuery();

                if (DosyaOku_ziple == "True")
                {
                    //Yedekleme işlemi bittikten sonra zipleme işlemini başlat.
                    DosyaZiple(tb_backup_patch.Text, BackupDBFullName, listBoxItem.ToString());
                    //Zipleme işlemi sonrası 10 saniye bekle
                    Thread.Sleep(SleepTime);
                }


                if (DosyaOku_ziple == "True")
                {
                    //Zipleme işlemi bittikten sonra Eski dosyaları sil.
                    //string BackupDBFullName = listBoxItem.ToString() + ".bak";
                    //string BackupDBFullName = buguntarih + "_" + listBoxItem.ToString() + ".bak";
                    //string BackupDBFullDir = tb_backup_patch.Text + "\\" + BackupDBFullName;

                    if (File.Exists(BackupDBFullDir))
                    {
                        File.Delete(BackupDBFullDir);
                        Thread.Sleep(SleepTime);
                    }
                }
            }
            
            bag.Close();
            
            //MessageBox.Show("Yedekleme işlemi Tamamlandı.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false; //Thread çakışmasını önle
            FileManager.AyarlarDosyaOku();
            GetDatabaseList();

            //Dosya okunuyor ve saat kaçta yedek alınacak bilgisi ekrana yazdırılıyor.
            SaatKactaYedekAl = FileManager.FileRead_SaatKacTaYedekAl;
            txt_yedeksaati.Text = SaatKactaYedekAl;

            //Dosya okunuyor ve Veritaqbanı yedeklenecek dizinin bilgisi okunuyor.
            DizinBilgisiniAl = FileManager.FileRead_KayitDizini;
            tb_backup_patch.Text = DizinBilgisiniAl;

            //Dosya okunuyor ve timeout bilgisi alınıyor.
            DosyaOku_timeout = FileManager.FileRead_timeout;
            txt_timeout.Text = DosyaOku_timeout;

            //Dosya okunuyor ve timeout bilgisi alınıyor.
            DosyaOku_ziple = FileManager.FileRead_ziple;

            if(DosyaOku_ziple =="True")
            {
                chb_ziple.Checked = true;
            }
            else
            {
                chb_ziple.Checked = false;
            }

            System.Timers.Timer t = new System.Timers.Timer(30000);
            t.Elapsed += new ElapsedEventHandler(SaniyelikIs);
            t.Start();
        }

        public void SaniyelikIs(object o, ElapsedEventArgs a)
        {
            string SaatKac = DateTime.Now.ToString("HH:mm");
            string SaatKacTest = DateTime.Now.ToString(SaatKactaYedekAl);

            if (Yedeklemeislemibittimi)
            {
                if (SaatKac == SaatKacTest)
                {
                    Yedeklemeislemibittimi = false;
                    FullBackup();
                    lvl_SonYedekZamani.Text = "Son Yedek Aldığı Tarihi :" + DateTime.Now.ToString();
                    Yedeklemeislemibittimi = true;
                }
            }
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            FileManager.AyarlarDosyaYaz(tb_backup_patch.Text, txt_yedeksaati.Text,txt_timeout.Text, chb_ziple);

            Form1_Load(sender, e);
        }


        void Zip_SaveProccess(object sender, SaveProgressEventArgs e)
        {
            if (e.EventType == Ionic.Zip.ZipProgressEventType.Saving_EntryBytesRead)
            {
                Invoke(new MethodInvoker(delegate
                {
                    progressBar1.Maximum = 100;
                    progressBar1.Value = (int)((e.BytesTransferred * 100) / e.TotalBytesToTransfer);
                    progressBar1.Update();
                }));
            }
        }

        private void DosyaZiple(string dosyayolu, string dosyaadi, string DbName)
        {
            ManualResetEvent syncEvent = new ManualResetEvent(false);

            string DosyaAdiveYolu = dosyayolu + "\\" + dosyaadi;
            lbl_DBName.Text = DosyaAdiveYolu.ToString();

            Thread thread = new Thread(T =>
            {
                using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile())
                {
                    FileInfo Fi = new FileInfo(DosyaAdiveYolu);
                    zip.UseZip64WhenSaving = Zip64Option.Always;
                    zip.AddFile(DosyaAdiveYolu);
                    DirectoryInfo di = new DirectoryInfo(DosyaAdiveYolu);
                    zip.SaveProgress += Zip_SaveProccess;
                    zip.Save(string.Format("{0}/{1}.zip", di.Parent.FullName, di.Name));
                }
            })
            { IsBackground = true };
            thread.Start();
            thread.Join();
        }

        private void hakkımdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hakkimda hak = new Hakkimda();
            hak.Show();
        }
    }
}
