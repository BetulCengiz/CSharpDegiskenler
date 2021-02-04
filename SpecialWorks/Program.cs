using System;

namespace SpecialWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            //>> String Veri Tipi


            //string ad,soyad,meslek,sehir;
            //Console.WriteLine("sırayla giriniz");
            //ad = Console.ReadLine();
            //soyad = Console.ReadLine();
            //meslek= Console.ReadLine();
            //sehir = Console.ReadLine();
            //Console.WriteLine("Ad: {0} Soyad: {1} Meslek: {2} Şehir: {3} ",ad,soyad,meslek,sehir );


            //>> Integer veri tipi (tam sayılar)

            //>>
            //int a, b, c;
            //a = 90;
            //b = 23;
            //c = a / b;
            //Console.WriteLine(c);
            //>> Int virgülden sonrasını dikkate almaz 3,91 sayısını 3'e yuvarlar

            //int sayi1,sayi2,toplam;
            //sayi1 = 5;
            //sayi2 = 7;
            //toplam = sayi1 + sayi2;
            //Console.WriteLine(toplam);

            //string ad, soyad, numara;
            //int sinav1, sinav2, sinav3, proje, ortalama;
            //sinav1 = 78;
            //sinav2 = 50; 
            //sinav3 = 80;
            //proje = 84;
            //ortalama = (sinav1 + sinav2 + sinav3 + proje) / 4;
            //Console.WriteLine("Ad giriniz: ");
            //ad = Console.ReadLine();
            //Console.WriteLine("SoyAd giriniz: ");
            //soyad = Console.ReadLine();
            //Console.WriteLine("Numara giriniz: ");
            //numara = Console.ReadLine();
            //Console.WriteLine("Ad: {0} Soyad: {1} Numara: {2} Ortalama = {3} ",ad,soyad,numara,ortalama);


            //>> Klavyeden sayı girme ve Convert


            //int sayi1, sayi2, toplam;
            //Console.WriteLine("******Toplama İşlemi******");
            //Console.WriteLine("Birinci sayıyı giriniz");
            //sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("İkinci sayıyı giriniz");
            //sayi2 = Convert.ToInt32(Console.ReadLine());
            //toplam = sayi1 + sayi2;
            //Console.WriteLine("Toplam: " + toplam);


            //>> Double Veri Tipi


            double sinav1, sinav2, sinav3, proje, ortalama;
            string ad, soyad, numara;
            //numara bir etiket olduğu için ve sayısal işlemlerde kullanmayacağımız için string olarak tanımlayabiliriz.
            Console.WriteLine("****Öğrenci Not Hesaplama****");
            Console.WriteLine("****Öğrenci Bilgileri****");
            Console.WriteLine("Adınız: ");
            ad = Console.ReadLine();
            Console.WriteLine("Soyadınız: ");
            soyad = Console.ReadLine();
            Console.WriteLine("Numaranız: ");
            numara = Console.ReadLine();
            Console.WriteLine("****Öğrenci Not Bilgileri****");
            Console.WriteLine("Birinci notu giriniz: ");
            sinav1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("İkinci notu giriniz: ");
            sinav2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Üçüncü notu giriniz: ");
            sinav3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Proje notu giriniz: ");
            proje = Convert.ToDouble(Console.ReadLine());
            ortalama = (sinav1 + sinav1 + sinav3 + proje) / 4;
            Console.WriteLine("Ortalamanız: "+ ortalama);


        }
    }
}
