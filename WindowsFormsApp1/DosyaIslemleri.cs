using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class DosyaIslemleri
    {
        string AyarlarKlasorAdi = ".\\Ayarlar.ini";
        public string FileRead_SaatKacTaYedekAl, FileRead_KayitDizini, FileRead_timeout, FileRead_ziple;
        public void AyarlarDosyaOlustur()
        {
            
            if(File.Exists(AyarlarKlasorAdi) == false)
            {
                FileStream fs = File.Create( AyarlarKlasorAdi);
                fs.Close();
            }
        }

        public void AyarlarDosyaYaz(string KayitDizini,string YedekSaati, string timeout, CheckBox ziple)
        {
            StreamWriter sw = new StreamWriter(AyarlarKlasorAdi);
            sw.WriteLine("KayitDizini="+KayitDizini);
            sw.WriteLine("YedekSaati="+YedekSaati);
            sw.WriteLine("timeout=" + timeout);

            if(ziple.Checked == true)
            sw.WriteLine("ziple=True");
            else
            sw.WriteLine("ziple=False");

            sw.Close();
        }

        public void AyarlarDosyaOku()
        {

            FileStream fs = new FileStream(AyarlarKlasorAdi, FileMode.Open, FileAccess.Read);

            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadLine();

            while (yazi != null)
            {
                if(yazi.Contains("YedekSaati"))
                {
                    FileRead_SaatKacTaYedekAl = string.Join("YedekSaati", yazi.Split('=').Where(r => r != "YedekSaati"));
                }

                if (yazi.Contains("KayitDizini"))
                {
                    FileRead_KayitDizini = string.Join("KayitDizini", yazi.Split('=').Where(r => r != "KayitDizini"));
                }

                if (yazi.Contains("timeout"))
                {
                    FileRead_timeout = string.Join("timeout", yazi.Split('=').Where(r => r != "timeout"));
                }

                if (yazi.Contains("ziple"))
                {
                    FileRead_ziple = string.Join("ziple", yazi.Split('=').Where(r => r != "ziple"));
                }


                yazi = sw.ReadLine();
            }
            sw.Close();
            fs.Close();
        }

    }
}
