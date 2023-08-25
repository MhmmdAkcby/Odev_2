using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Odev_2
{
    public class Banka
    {
        private string kullaniciAdi;
        private string sifre;

        private int bakiye;

        public string KullaniciAdi { get { return kullaniciAdi; } set { kullaniciAdi = value; } }
        public string Sifre { get { return sifre; } set { sifre = value; } }
        public int Bakiye { get { return bakiye; } set { bakiye = value; } }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Banka bank = new Banka();

            //bank.KullaniciAdi = "Muhammed Akcabey";
            //bank.Sifre = "akcabey123";

            Console.WriteLine("Lütfen Giriş Yapınız...");

            Console.Write("Kullanıcı Adınız: ");
            bank.KullaniciAdi= Console.ReadLine();

            Console.Write("Şifre: ");
            bank.Sifre= Console.ReadLine();

            Console.Clear();
            int bakiye = 0;
            bool kontrol = true;

            while (kontrol)
            {
                if (bank.KullaniciAdi == "Muhammed Akcabey" && bank.Sifre == "akcabey123")
                {
                    Console.WriteLine("Bank Bankaya Hoş Geldiniz!");
                    Console.WriteLine("1.Bakiye Sorgulama \n 2.Para Yatırma \n 3.Para Çekme \n 4.Çıkış Yap");
                    Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz: ");
                    string secim = Console.ReadLine();
                    switch (secim)
                    {
                        case "1":
                            Console.Write("Mevcut Bakiyeniz: ");
                            Bakiye();
                            break;
                        case "2":
                            ParaYatirma();
                            break;
                        case "3":
                            ParaCekme();
                            break;
                        case "4":
                            Console.WriteLine("Çıkış Yapılıyor...");
                            kontrol = false;
                            break;
                        default:
                            Console.WriteLine("Hatalı Tuşlama");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Kullanıcı Adı veya Hatalı");
                    Console.WriteLine("Çıkış Yapılıyor...");
                    break;
                }
            }
            
            void Bakiye()
            {
                Console.Clear();
                Console.WriteLine(bakiye);
            }
            void ParaYatirma()
            {
                Console.Clear();
                Console.Write("Lütfen yatırmak istediğiniz Tutarı girin: ");
               int a = Convert.ToInt32(Console.ReadLine());
                bakiye += a;
                Console.WriteLine("Bakiye Yükleme işlemi başarılı");
                Console.WriteLine($"Güncel Bakiyeniz: {bakiye}");
            }
            void ParaCekme()
            {
                Console.Clear();
                Console.Write("Lütfen cekmek istediğiniz Tutarı girin: ");
                int b = Convert.ToInt32(Console.ReadLine());
                
                if (bakiye >= b)
                {
                    bakiye -=b;
                    Console.WriteLine("Para çekme işlemi başarılı");
                    Console.WriteLine($"Güncel Bakiyeniz: {bakiye}");
                }
                else Console.WriteLine("Yetersiz Bakiye");


            }





        }
    }
}
