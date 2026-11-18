/*
1.Soru: x değişkenin en az 100 ve en çok 500 olma durumu için şart yazınız.

x >= 100 && x <= 500

2.Soru: x değişkeninin 100 hariç veya y değişkeninin 200 olma durumu için şart yazınız.

x !=100 || x ==200

3.Soru: x değişkeni en fazla 101 veya 300 den fazla olma durumu için şart yazınız.

x <= 101 || x > 300

4.Soru: x değişkeninin 120,300 ve 400 olmadığı durum için şart yazınız.

x != 120 && x != 300 && x != 400

5.Soru: x,300 ve daha az veya y,500 ve daha fazla olduğu durum için şart yazınız.

x <= 300 || y >= 500

6.Soru: 200 < x <= 500 durumu için şart yazınız.

x > 200 && x <= 500 

7.Soru: 20 <= x  ve  y > 50 durumu için şart yazınız.

x >= 20 && y > 50

8.Soru: if yapısı ile switch yapısı arasındaki benzerlikleri ve farklılıkları belirleyiniz.

kisi de belirli şartlara göre programın akışını yönlendiren karar yapılarıdır.

Hiçbir şart tutmadığında çalışan varsayılan blokları vardır 
(if yapısındaki else ile switch yapısındaki default aynı görevi görür).

Her switch yapısı, if - else if - else yapısına dönüştürülerek yazılabilir.

if yapısında <, >, <=, >= operatörleriyle aralık belirlenebilir; switch yapısında aralık belirlenemez, 
sadece eşitlik (==) kontrolü yapılır.

if yapısında her veri tipi (ondalıklı sayılar, mantıksal ifadeler vb.) sorgulanabilirken, 
switch yapısında yalnızca tam sayılar (int, byte) ve char tipi sorgulanır.

switch yapısında her durumdan sonra çıkış için break kullanmak zorunludur, if yapısında gerek yoktur.

if yapısı C# ve Python'da ortak olarak bulunurken, Python dilinde switch yapısı yoktur.   

*/


/*
// 9.Soru: Dışarıdan girilen bir sayının 1000 den büyük olup olmadığını ekrana yazdırınız.

using System;
namespace Calisma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            if (sayi > 1000)
            {
                Console.WriteLine("Sayı 1000'den büyüktür.");
            }
            else
            {
                Console.WriteLine("Sayı 1000'den büyük değildir.");
            }

            Console.ReadLine();
        }
    }
}
*/


/*
// 10. Dışarıdan girilen adı ve şifreye bakarak girişin başarılı olup olmadığını belirleyiniz. 
// Sisteme girişte geçerli kullanıcı adı 'Ahmet' ve şifre '54321' dir.

using System;

namespace Calisma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kullanıcı Adı: ");
            string ad = Console.ReadLine();

            Console.Write("Şifre: ");
            string sifre = Console.ReadLine();

            if (ad == "Ahmet" && sifre == "54321")
            {
                Console.WriteLine("Giriş Başarılı");
            }
            else
            {
                Console.WriteLine("Giriş Başarısız");
            }

            Console.ReadLine();
        }
    }
}
*/

/*
// 11.Soru: Geçme notunun 60 olduğu bir okulda dışardan girilen nota göre öğrencinin geçip kaldığını ekrana yazdırınız.

using System;

namespace Calisma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Notunuzu giriniz: ");

            int not = int.Parse(Console.ReadLine());

            if (not >= 60)
            {
                Console.WriteLine("Tebrikler geçtiniz.");
        }
            else
            {
                Console.WriteLine("Maalesef kaldınız.");
            }

            Console.ReadLine();
        }
    }
}
*/

/*
//  12.Soru: Bir GSM operatörü müşterilerinin kaç yıllık abone olduğuna bakarak onlara hediye internet verecektir.
// Abone süresi 1 yıldan düşükse 1GB, 1-2 yıl arası 3GB, 2-3 yıl arası 5GB ve 3 yıldan fazla süredir abone olanlara 8GB
// internet hediye edilmesi istenmektedir. Bu amaçla dışardan girilen abone süresine göre müşterinin kazanacağı 
// internet miktarını hesaplayınız.

using System;

namespace Calisma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç yıllık abone olduğunuzu giriniz: ");
            double yil = double.Parse(Console.ReadLine());

            if ( yil < 1)
            {
                Console.WriteLine("1GB hediye internet kazandınız.");
            }
            
            else if ( yil <= 2 )
            {
                Console.WriteLine("3GB hediye internet kazandınız.");
            }

            else if ( yil <= 3 )
            {
                Console.WriteLine("5GB hediye internet kazandınız.");
            }

            else
            {
                Console.WriteLine("8GB hediye internet kazandınız.");
            }

            Console.ReadLine();

        }
    }
}
*/

/*
// 13.Soru: if yapısını kullanarak x değişkeninin 30 sayısına göre durumunu (büyük,küçük veya eşit) bulunuz.

using System;

namespace Calisma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" x değerini giriniz: ");
            int x = int.Parse(Console.ReadLine());

            if ( x > 30)
            {
                Console.WriteLine("Girdiğiniz x değeri 30 dan büyüktür.");
            }

            else if ( x < 30)
            {
                Console.WriteLine("Girdiğiniz x değeri 30 dan küçüktür.");
            }

            else
            {
                Console.WriteLine("Girdiğiniz x değeri 30 a eşittir.");
            }

            Console.ReadLine();
        }
    }
}
*/

/*
// 14.Soru: Suyun sıcaklığına göre maddenin hangi halinde(katı,sıvı,gaz) bulunacağını bulunuz.

using System;
namespace Calisma
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Suyun sıcakılığını giriniz: ");
            double sicaklik = double.Parse(Console.ReadLine());

            if ( sicaklik <= 0)
            {
                Console.WriteLine("Su katı haldedir.");
            }

            else if ( sicaklik < 100)
            {
                Console.WriteLine("Su sıvı haldedir.");
            }

            else
            {
                Console.WriteLine("Su gaz haldedir");
            }

            Console.ReadLine();
        }
    }
}
*/

/*
// 15.Soru: if yapısını kullanarak x=350 değişkeninin 100 - 200 arasında olup olmadığını bulunuz.

using System;
namespace Calisma
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 350;

            if ( x >= 100 && x <= 200)
            {
                Console.WriteLine(" x sayısı 100-200 arasındadır.");
            }

            else
            {
                Console.WriteLine("x sayısı 100-200 arasında değildir.");
            }

            Console.ReadLine();
        }
    }
}
*/


/*
// 16.Soru: if yapısını kullanarak x=350 değişkeninin 100-200 arasında değilse,200-300 arasında olup olmadığını 
// birleştirme operatörlerini(ve,veya...) kullanmadan bulunuz.

using System;
namespace Calisma
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 350;

            if ( x >= 100)
            {
                if ( x <= 200)
                {
                    Console.WriteLine(" x sayısı 100-200 arasındadır.");
                }
                else
                {
                    if ( x <= 300)
                    {
                        Console.WriteLine(" x sayısı 200-300 arasındadır.");
                    }
                    else
                    {
                        Console.WriteLine("x sayısı 300'den büyüktür.");
                    }
                }
            }
            else
            {
                Console.WriteLine(" x sayısı 100'den küçüktür.");
            }
            
            Console.ReadLine();
        }
    }
}
*/


/*
// 17.Soru: switch yapısını kullanarak dışardan girilen x değerlerine göre; x=1 ise ev sahibi kazandı, 
// x=2 ise misafir takım kazandı, x=0 ise berabere kaldı olarak değerlendirilen kodları yazınız.


using System;
namespace Calisma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Maç sonucu kodunu giriniz (1, 2 veya 0): ");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                Console.WriteLine("Ev sahibi kazandı.");
                break;

                case 2:
                Console.WriteLine("Misafir takım kazandı.");
                break;

                case 0:
                Console.WriteLine("Berabere kaldı.");
                break;

                default:
                Console.WriteLine("Geçersiz bir değer girdiniz.");
                break;
            }

            Console.ReadLine();
        }
    }
}
*/

/*
 // 18.Soru: switch yapısını kullanarak 0-100°C arasını soğuk,normal,sıcak ve çok sıcak olarak 
 // istediğiniz gibi derecelendirme yapınız.

 using System;
 namespace Calisma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sıcaklık değerini giriniz (0-100): ");
            int sicaklik = int.Parse(Console.ReadLine());

            switch (sicaklik)
            {
                case < 0:
                case > 100:
                Console.WriteLine("Lütfen 0 ile 100 arasında bir değer giriniz.");
                break;

                case <= 15:
                Console.WriteLine("Soğuk");
                break;

                case <=30:
                Console.WriteLine("Normal");
                break;

                case <= 50:
                Console.WriteLine("Sicak");
                break;

                default:
                Console.WriteLine("Çok Sıcak");
                break;
            }

            Console.ReadLine();
        }
    }
}
*/

/*
// 19.Soru: Dışarıdan girilen tutara ve cins verisine göre toplam tutarı belirleyiniz.
// Bir malın cinsi A ise %10,değilse %1 indirim uygulanacaktır.

using System;
namespace Calisma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tutarı giriniz: ");
            double tutar = double.Parse(Console.ReadLine());

            Console.Write("Malın cinsini giriniz: ");
            string cins = Console.ReadLine();

            double toplamTutar;

            if (cins == "A" || cins == "a")
            {
                toplamTutar = tutar - (tutar *0.10);
            }
            else
            {
                toplamTutar = tutar - (tutar *0.01);
            }

            Console.WriteLine("Ödenecek toplam tutar: " + toplamTutar);
            Console.ReadLine();
        }
    }
}
*/


/*
// 20.Soru: Bir öğrencinin sözlü notunun olup olmadığını x mantıksal değişkeni ile belirlenmektedir. 
// a. X=ture ise sözlü olmuştur.  b. X=false ise sözlü olmamıştır.  
// Buna göre bir öğrencinin sözlü olup olmadığını ekrana tek satır şart ifadesi ile yazdırınız.

using System;
namespace Calisma
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = true;

            Console.WriteLine(x ? "Sözlü olmuştur." : "Sözlü olmamıştır.");

            x = false;
            Console.WriteLine(x ? "Sözlü olmuştur." : "Sözlü olmamıştır.");

            Console.ReadLine();
        }
    }
}



// 21.Soru: Tek satır şart yapısını kullanarak geçme notu 60 olan bir okulda dışardan girilen notun 
// geçip kaldığını belirleyiniz.

using System;
namespace Calisma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Notunuzu giriniz: ");
            int not = int.Parse(Console.ReadLine());

            Console.WriteLine(not >= 60 ? "Tebrikler geçtiniz." : "Maalesef kaldınız.");

            Console.ReadLine();
        }
    }
}
*/

/*
// 22.Soru: Tek satır şart yapısını kullanarak x değişkeninin 30 değerine göre durumunu (büyük,küçük veya eşit) bulunuz.

using System;
namespace Calisma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x değerini giriniz: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(x > 30 ? "30'dan büyüktür." : (x < 30 ? "30'dan küçüktür." : "30'a eşittir."));

            Console.ReadLine();
        }
    }
}
*/

/*
// 23.Soru: Dışarıdan girilen 3 sayıdan en az birisinin pozitif olup olmadığını bulunuz.

using System;
namespace Calisma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1.sayıyı giriniz: ");
            int s1 = int.Parse(Console.ReadLine());

            Console.Write("2.sayıyı giriniz: ");
            int s2 = int.Parse(Console.ReadLine());

            Console.Write("3.sayıyı giriniz: ");
            int s3 = int.Parse(Console.ReadLine());

            if (s1 > 0 || s2 > 0 || s3 > 0)
            {
                Console.WriteLine("Girilen sayılardan en az birisi pozitiftir.");
            }
            else
            {
                Console.WriteLine("Girilen sayılardan hiçbiri pozitif değildir.");
            }

            Console.ReadLine();
        }
    }
}
*/

/*
// 24.Soru: Dışardan girilen 3 sayıdan en büyük 15 kaç sayı girildiğini bulunuz.

using System;
namespace Calisma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1.sayıyı giriniz: ");
            int s1 = int.Parse(Console.ReadLine());

            Console.Write("2.sayıyı giriniz: ");
            int s2 = int.Parse(Console.ReadLine());

            Console.Write("3.sayıyı giriniz: ");
            int s3 = int.Parse(Console.ReadLine());

            int sayac = 0;

            if (s1 <= 15)
            {
                sayac++;
            }

            if (s2 <= 15)
            {
                sayac++;
            }

            if (s3 <= 15)
            {
                sayac ++;
            }

            Console.WriteLine("En büyük 15 olan " + sayac + " adet sayı girildi.");

            Console.ReadLine();
        }
    }
}
*/


// 25.Soru: Dışarıdan girilen sıra numarasına karşılık gelen alfabedeki harfi yazdırınız.

using System;
namespace Calisma
{
    class Program
    {
        static void Main(string[] args)
        {
            string alfabe = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";

            Console.Write("Harf sıra numarasını giriniz (1-29): ");
            int sira = int.Parse(Console.ReadLine());

            if (sira >= 1 && sira <= 29)
            {
                Console.WriteLine(sira + ".harf: " + alfabe[sira - 1]);
            }
            else
            {
                Console.WriteLine("Lütfen 1 ile 29 arasında bir sayı giriniz.");
            }

            Console.ReadLine();
        }
    }
}