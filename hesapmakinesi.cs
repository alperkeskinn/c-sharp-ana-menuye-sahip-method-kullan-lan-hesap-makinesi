using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesapmakinesi
{
    internal class Program
    {
        public static void anamenu()
        {
            string giris;
            Console.WriteLine("************ HESAP MAKİNESİ ************");
            Console.WriteLine("TOPLAMA İŞLEMİ İÇİN ---------> '+'");
            Console.WriteLine("ÇIKARMA İŞLEMİ İÇİN ---------> '-'");
            Console.WriteLine("ÇARPMA İŞLEMİ İÇİN ---------> 'x'");
            Console.WriteLine("BÖLME İŞLEMİ İÇİN ---------> '/'");
            Console.WriteLine("KARESİNİ ALMA İŞLEMİ İÇİN ---------> 'kare'");
            Console.WriteLine("GİRİNİZ : ");
            giris = Console.ReadLine();
            

            if (giris == "+")
            {
                
                toplama();
            }
            else if (giris == "-")
            {
                cikarma();
            }
            else if (giris == "x")
            {
                carpma();   
            }
            else if (giris == "/")
            {
                bolme();
            }
            else if (giris == "kare")
            {
                kareal();
            }

        }
        static void toplama()
        {
            Console.Clear();
            int toplam = 0;
            int sayilar;
            string asd;

            Console.WriteLine("Sayi  girişi yapınız. Sayı  girişiniz  bittiğinde '0' tuşlayınız");
            for  (int i=0; ; i++)
            {
                
                sayilar = Convert.ToInt32(Console.ReadLine());
                if (sayilar != 0)
                 {
                    Console.WriteLine(" + ");
                    toplam += sayilar;
                 }
                 else 
                 {
                    Console.Clear();
                    Console.WriteLine("İşlemin sonucu "  +  toplam );
                    Console.WriteLine("Ana Menüye Dönmek İçin 'A' yazınız.");
                    Console.WriteLine("Çıkmak için 'E' yazınız.");
                    asd = Console.ReadLine();
                    if (asd == "A") 
                    {
                        anamenu();
                    }
                    else if (asd == "E")
                    {
                        Environment.Exit(0);
                    }
                    
                 }
            }

            
        }
        static void cikarma()
        {
            Console.Clear();
            int birincisayi;
            int ikincisayi;
            string asd;

            Console.Write("İlk sayıyı giriniz : ");
            birincisayi = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz : ");
            ikincisayi = Convert.ToInt32(Console.ReadLine());
            int toplam = birincisayi - ikincisayi;

            
                
                    Console.Clear();
                    Console.WriteLine("İşlemin sonucu " + toplam);
                    Console.WriteLine("Ana Menüye Dönmek İçin 'A' yazınız.");
                    Console.WriteLine("Çıkmak için 'E' yazınız.");
                    asd = Console.ReadLine();
                    if (asd == "A")
                    {
                        anamenu();
                    }
                    else if (asd == "E")
                    {
                        Environment.Exit(0);
                    }

                
            

        }
        static void carpma()
        {
            Console.Clear();
            int carpim = 1;
            int sayilar;
            string asd;

            Console.Write("Sayi  girişi yapınız. Sayı  girişiniz  bittiğinde '0' tuşlayınız");
            for (int i = 0; ; i++)
            {

                sayilar = Convert.ToInt32(Console.ReadLine());
                if (sayilar != 0)
                {
                    Console.WriteLine(" x ");
                    carpim *= sayilar;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("İşlemin sonucu " + carpim);
                    Console.WriteLine("Ana Menüye Dönmek İçin 'A' yazınız.");
                    Console.WriteLine("Çıkmak için 'E' yazınız.");
                    asd = Console.ReadLine();
                    if (asd == "A")
                    {
                        anamenu();
                    }
                    else if (asd == "E")
                    {
                        Environment.Exit(0);
                    }

                }
            }


        }
        static void bolme()
        {
            Console.Clear();
            int bolunen;
            int bolen;
            
            string asd;

            Console.Write("Bölüneni Giriniz : ");
            bolunen = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bölen Giriniz : ");
            bolen = Convert.ToInt32(Console.ReadLine());
            int bolum = bolunen / bolen;
            int kalan = bolunen % bolen;



            Console.Clear();
            Console.WriteLine("Bölüm: " + bolum);
            Console.WriteLine("Kalan: " + kalan);
            Console.WriteLine("Ana Menüye Dönmek İçin 'A' yazınız.");
            Console.WriteLine("Çıkmak için 'E' yazınız.");
            asd = Console.ReadLine();
            if (asd == "A")
            {
                anamenu();
            }
            else if (asd == "E")
            {
                Environment.Exit(0);
            }




        }
        static void kareal()
        {
            Console.Clear();
            int sayi;
            string asd;

            Console.Write("Karesini Almak İstediğiniz Sayıyı Giriniz : ");
            sayi = Convert.ToInt32(Console.ReadLine());

            int kare = sayi * sayi;



            Console.Clear();
            Console.WriteLine("Sayını Karesi " + kare);
            Console.WriteLine("Ana Menüye Dönmek İçin 'A' yazınız.");
            Console.WriteLine("Çıkmak için 'E' yazınız.");
            asd = Console.ReadLine();
            if (asd == "A")
            {
                anamenu();
            }
            else if (asd == "E")
            {
                Environment.Exit(0);
            }




        }




        static void Main(string[] args)
        {

            anamenu();
            Console.ReadKey();
            


        }
    }
}
