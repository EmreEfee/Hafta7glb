using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta7glb
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            int n = 10; 

            int[] sayilar = new int[n];

            
            for (int i = 0; i < n; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz: ",i+1);
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            
            int enBuyuk = sayilar[0];
            int enKucuk = sayilar[0];

            for (int i = 1; i < n; i++)
            {
                if (sayilar[i] > enBuyuk)
                {
                    enBuyuk = sayilar[i];
                }

                if (sayilar[i] < enKucuk)
                {
                    enKucuk = sayilar[i];
                }
            }

          
            Console.WriteLine("En büyük sayı: "+ enBuyuk);
            Console.WriteLine("En küçük sayı: "+ enKucuk);
            */
            /* hocanın yaprtıgı
             Console.WriteLine("1. Sayıyı giriniz: ");
             int sayi = int.Parse(Console.ReadLine());
             int enk = sayi;
             int enb = sayi;

             for (int i = 1; i < 10; i++)
             {
                 Console.WriteLine("{0}. sayıyı giriniz: ",i+1);
                 sayi = int.Parse(Console.ReadLine());
                 if (sayi>enb)
                 {
                     enb = sayi;
                 }
                 if (sayi<enk)
                 {
                     enk = sayi;
                 }

             }
             Console.WriteLine("Girilen en buyuk sayi={0}",enb);
             Console.WriteLine("Girilen en buyuk sayi={0}",enk);
            */
            /* chatgptnin yaptigi
            int n = 10;
            int[] sayilar = new int[n];

            int i = 0;

            while (i < n)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz: ", i + 1);
                sayilar[i] = int.Parse(Console.ReadLine());
                i++;
            }

            int enBuyuk = sayilar[0];
            int enKucuk = sayilar[0];

            i = 1;

            while (i < n)
            {
                if (sayilar[i] > enBuyuk)
                {
                    enBuyuk = sayilar[i];
                }

                if (sayilar[i] < enKucuk)
                {
                    enKucuk = sayilar[i];
                }

                i++;
            }

            Console.WriteLine("En büyük sayı: " + enBuyuk);
            Console.WriteLine("En küçük sayı: " + enKucuk);
            */
            /*
            Console.Write("1. Sayıyı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int enk = sayi;
            int enb = sayi;

            int i = 1;
            while (i<10)
            {
                Console.Write("{0}. sayıyı giriniz: ",i+1);
                sayi = int.Parse(Console.ReadLine());
                if (sayi>enb)
                {
                    enb = sayi;
                }
                if (sayi<enk)
                {
                    enk = sayi;
                }
                i++;
            }
            Console.WriteLine("Girilen en büyük sayı: {0}",enb);
            Console.WriteLine("Girilen en küçük sayı= {0}, enk);
            */

            /* hocanın yaptıgı glb
            int[] sayilar = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz: ",i+1);
                sayilar[i] = int.Parse(Console.ReadLine());
            }
            int enb = sayilar[0];
            int enk = sayilar[0];
            for (int i = 1; i < 10; i++)
            {
                if (sayilar[i]>enb)
                {
                    enb = sayilar[i];
                }
                if (sayilar[i]<enk)
                {
                    enk = sayilar[i];
                }

            }

            Console.WriteLine("Girilen en büyük sayı= {0}",enb);
            Console.WriteLine("Girilen en küçük sayı= {0}", enk);

            */
            /*
            int[] sayilar = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz: ", i + 1);
                sayilar[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(sayilar);
            int enk = sayilar[0];
            int enb = sayilar[0];

            Console.WriteLine("Girilen en büyük sayı= {0}", enb);
            Console.WriteLine("Girilen en küçük sayı= {0}", enk);
            */


            // Kullanıcıdan 2 adet sayı alalım ve bu iki sayının arasındaki çift sayıların toplamlarını ve ortalamalarını ekrana yazalım
            // for döngüsü ile


            /*
            Console.Write("Birinci sayıyı giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());

            if (sayi1 > sayi2)
            {
                int gecici = sayi1;
                sayi1 = sayi2;
                sayi2 = gecici;
            }

  
            int toplam = 0;
            int ciftSayiAdeti = 0;

            for (int sayi = sayi1; sayi <= sayi2; sayi++)
            {
                if (sayi % 2 == 0)
                {
                    toplam += sayi;
                    ciftSayiAdeti++;
                }
            }

            double ortalama = (double)toplam / ciftSayiAdeti;

            Console.WriteLine("1.sayı ile 2.sayı arasındaki çift sayıların toplamı: "+toplam);
            Console.WriteLine("1.sayı ile 2.sayı arasındaki çift sayıların ortalaması: "+ortalama);
            */
            /* hy
                        int bas = 0;
                        int son = 0;
                        Console.WriteLine("1. sayıyı giriniz: ");
                        bas = int.Parse(Console.ReadLine());
                        Console.WriteLine("2. sayıyı giriniz: ");
                        son = int.Parse(Console.ReadLine());

                        if (bas>son)
                        {
                            int depo = bas;
                            bas = son;
                            son = depo;
                        }

                        int ciftToplam = 0;
                        int adet = 0;
                        Console.WriteLine("Çift sayılar");
                        for (int i = bas; i < son; i++)
                        {
                            if (i%2==0)
                            {
                                Console.Write(i+"-");
                                ciftToplam += i;
                                adet++;
                            }
                        }

                        Console.WriteLine("\nÇift sayıların ortalaması={0}",ciftToplam/adet);

                */

            /*
            Console.Write("Birinci sayıyı giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());


            if (sayi1 > sayi2)
            {
                int gecici = sayi1;
                sayi1 = sayi2;
                sayi2 = gecici;
            }


            int toplam = 0;
            int ciftSayiAdeti = 0;


            int currentSayi = sayi1;
            do
            {
                if (currentSayi % 2 == 0)
                {
                    toplam += currentSayi;
                    ciftSayiAdeti++;
                }
                currentSayi++;
            } while (currentSayi <= sayi2);


            double ortalama = (double)toplam / ciftSayiAdeti;

 
            Console.WriteLine("1.sayı ile 2.sayı arasındaki çift sayıların toplamı: "+toplam);
            Console.WriteLine("1.sayı ile 2.sayı arasındaki çift sayıların ortalaması: "+ortalama);
            */
            /*
            int bas = 0;
            int son = 0;
            Console.WriteLine("1. sayıyı giriniz: ");
            bas = int.Parse(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz: ");
            son = int.Parse(Console.ReadLine());

            if (bas > son)
            {
                int depo = bas;
                bas = son;
                son = depo;
            }

            int ciftToplam = 0;
            int adet = 0;
            int i = bas;
            Console.WriteLine("Çift sayılar");
            do
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
            } while (true);

            Console.WriteLine("\nÇift sayıların ortalaması={0}", ciftToplam / adet);
            */


            // 0 ile 10 arasında rastgele bir sayı oluşturalım
            // kullanıcının 5 tahmin hakkını bu sayıyı bulması için kullandıralım,
            // kullanıcıyı oluşturduğumuz sayıyı bulması için tahminlerinden sonra yönlendirelim(girdiğiniz sayı büyük,küçük).


            /*
            Random random = new Random();
            int hedefSayi = random.Next(0, 11);

            Console.WriteLine("0 ile 10 arasında bir sayı seçildi. Tahmininizi yapın!");

            int tahminHakki = 5;

            while (tahminHakki > 0)
            {
                Console.Write("Tahmininiz: ");
                int kullaniciTahmini = int.Parse(Console.ReadLine());

                if (kullaniciTahmini == hedefSayi)
                {
                    Console.WriteLine("Tebrikler! Doğru tahmin ettiniz.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Hatalı tahmin. {tahminHakki - 1} tahmin hakkınız kaldı.");

                    if (kullaniciTahmini < hedefSayi)
                        Console.WriteLine("Daha büyük bir sayı tahmin edin.");
                    else
                        Console.WriteLine("Daha küçük bir sayı tahmin edin.");

                    tahminHakki--;
                }
            }

            if (tahminHakki == 0)
            {
                Console.WriteLine("Üzgünüm, 5 tahmin hakkınız doldu. Doğru sayı: "+hedefSayi);
            }
            */

            /*hy
            int tahmin, hak = 5;
            bool durum = false;
            Random rastgele = new Random();
            int rastgeleSayi = rastgele.Next(0, 11);
            for (int kalanHak = hak; kalanHak > 0; kalanHak--)
            {
                Console.WriteLine("Hak {0}",kalanHak);
                Console.WriteLine("Tahmininiz : ");
                tahmin = int.Parse(Console.ReadLine());
                if (tahmin==rastgeleSayi)
                {
                    Console.WriteLine("Tebrikler");
                    durum = true;
                    break;
                }
                else if (rastgeleSayi> tahmin && kalanHak!=1)
                {
                    Console.WriteLine("Daha büyük bir sayı giriniz.");





                }
                else if (rastgeleSayi < tahmin && kalanHak!=1)
                {
                    Console.WriteLine("Daha küçük bir sayı giriniz.");
                }


            }

            if (!durum)
            {
                Console.WriteLine("Tekrar deneyin!");
                Console.WriteLine("Sayı: {0}", rastgeleSayi);
            }
            */


            // kullanıcıdan aldığımız 2 sayıya 4 işlemden hangisini yapmak istediğin soralım ve sonucu ekrana yazalım.

            /*
            int ilksayi, ikincisayi;
            char islem;
            Console.WriteLine("İlk sayıyı giriniz: ");
            ilksayi = int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz: ");
            ikincisayi = int.Parse(Console.ReadLine());

            Console.WriteLine("+ - * / bu işlemlerden hangisini yapmak istiyosun");
            islem = char.Parse(Console.ReadLine());

            if (islem == '+')
            {
                int sonuc;
                sonuc = ilksayi + ikincisayi;
                Console.WriteLine("Toplamın sonucu: "+sonuc);
            }
            if (islem == '-')
            {
                int sonuc;
                sonuc = ilksayi - ikincisayi;
                Console.WriteLine(+sonuc);
            }
            if (islem == '*')
            {
                int sonuc;
                sonuc = ilksayi * ikincisayi;
                Console.WriteLine(+sonuc);
            }
            if (islem == '/')
            {
                double sonuc = (double)ilksayi / ikincisayi;
                Console.WriteLine(+sonuc);
            }
            */
            /*
            Console.Write("Birinci sayıyı giriniz: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz:");
            Console.WriteLine("1. Toplama");
            Console.WriteLine("2. Çıkarma");
            Console.WriteLine("3. Çarpma");
            Console.WriteLine("4. Bölme");

            Console.Write("Seçiminiz (1-4): ");
            int secim = Convert.ToInt32(Console.ReadLine());

            double sonuc = 0;

            switch (secim)
            {
                case 1:
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine($"Toplama Sonucu: {sonuc}");
                    break;

                case 2:
                    sonuc = sayi1 - sayi2;
                    Console.WriteLine($"Çıkarma Sonucu: {sonuc}");
                    break;

                case 3:
                    sonuc = sayi1 * sayi2;
                    Console.WriteLine($"Çarpma Sonucu: {sonuc}");
                    break;

                case 4:
                    if (sayi2 != 0)
                    {
                        sonuc = sayi1 / sayi2;
                        Console.WriteLine($"Bölme Sonucu: {sonuc}");
                    }
                    else
                    {
                        Console.WriteLine("Hata: Sıfıra bölme hatası!");
                    }
                    break;

                default:
                    Console.WriteLine("Geçersiz seçim. Lütfen 1-4 arasında bir sayı giriniz.");
                    break;
            }
            */

            int sonuc = 0;

            Console.WriteLine("Toplama işlemi için +");
            Console.WriteLine("Çıkarma işlemi için -");
            Console.WriteLine("Çarpma işlemim için *");
            Console.WriteLine("Bölme işlemi ,için /");
            Console.WriteLine();
            Console.Write("Yapmak istediğiniz işlemi seçin: ");
            char secim = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            Console.Write("1. Sayıyı giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2. Sayıyı giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case '+':
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine("Toplama işleminin sonucu {0}",sonuc);
                    break;
                case '-':
                    sonuc = sayi1 - sayi2;
                    Console.WriteLine("Toplama işleminin sonucu {0}", sonuc);
                    break;
                case '*':
                    sonuc = sayi1 * sayi2;
                    Console.WriteLine("Toplama işleminin sonucu {0}", sonuc);
                    break;
                case '/':
                    sonuc = sayi1 / sayi2;
                    Console.WriteLine("Toplama işleminin sonucu {0}", sonuc);
                    break;
                default:
                    Console.WriteLine("Hatalı bir işlem yaptınız. ");
                    break;
            }
            Console.ReadKey();
        }
    }
}
