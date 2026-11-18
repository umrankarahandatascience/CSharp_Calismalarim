/*
using System;
namespace Calisma
{
    class program
    {
        static void Main(string[] args)
        {
            Byte a = 100;
            int b = 500;
            double d = 2.5;

            // Sayıyı boş bir metin ("") ile toplayarak string'e dönüştürme
            string s1= a+ "";
            Console.WriteLine(s1);
            string s2 = b + "";
            Console.WriteLine(s2);

            // .ToString() fonksiyonunu kullanarak string'e dönüştürme
            string s3 = d.ToString();
            Console.WriteLine(s3);
            string s4 = b.ToString();
            Console.WriteLine(s4);
            Console.ReadLine();
        }
    }
}
*/

/*
using System;
namespace Calisma
{
    class program
    {
        static void Main(string[] args)
        {
            string s1="100";
            string s2="50,2";
            string s3="12";
            int a = Int32.Parse(s1);
            double b=Double.Parse(s2);
            byte c = byte.Parse(s3);
            Console.WriteLine(a+3);  // İşlemde kullanıyoruz
            Console.WriteLine(b+4);
            Console.WriteLine(c+2);
            Console.ReadLine();
        }
    }
}
*/

// int olan bişeyi byte değiştirmicez.


// bunu int e mi byte mi koyuyiyim  byte a; a=Byte.maxvalue/minvalue

/*
using System;
namespace Calisma
{
    class program
    {
        static int numara; // değişken tanımlama 
        static void degistir() // Fonksiyon tanımlama
        {
            numara = 5;
        }
        static void Main(string[] args)
        {
            numara = 7;
            Console.WriteLine(numara);
            degistir();
            Console.WriteLine(numara);
            Console.ReadLine();
        }
    }
}
*/

/*
using System;

namespace Calisma
{
    class Program
    {
        // Sınıf seviyesinde (tüm metotların erişebileceği) değişken
        static int numara;

        static void topla(int k)
        {
            numara = k;
        }

        static void Main(string[] args)
        {
            // Main içine özgü yerel (local) değişkenler
            int numara;
            numara = 7;
            Console.WriteLine(numara);

            int no;
            no=100;
            Console.WriteLine(no);

            Console.ReadLine();
        }
    }
}

*/



/*

int numara;
numara = 7;
    no = 200; // <--- HATA BURADA!
Console.WriteLine(numara);
int no;
no = 100;
Console.WriteLine(no);


Hatayı Neden Alır? (Konunun Mantığı)
C# kodları yukarıdan aşağıya (sıralı) derler ve çalıştırır.
no = 200; satırına gelindiğinde bilgisayar bakar: "Bu no da kim? Tipi ne? int mi, string mi?"
   
Değişken henüz tanımlanmadığı (declare edilmediği) için derleyici:
error CS0103: 'no' adı geçerli bağlamda yok (The name 'no' does not exist in the current context) hatası fırlatır.

Çünkü int no; tanımı daha alttaki satırda yapılmıştır. Bir değişkeni tanımlamadan önce ona değer atayamaz veya 
kullanamazsın.   


*/


using System;

namespace Calisma
{
    class Program
    {
        static int numara;
        static void degistir()
        {
            numara=5;
        }

        static void Main(string[] args)
        {
            int numara;
            numara = 7;

            // Önce tanımlıyoruz,sonra değer veriyoruz
            int no;
            no=200;

            Console.WriteLine(numara);  // Ekrana 7 yazar

            no=100; // Değeri güncellendi
            Console.WriteLine(no); // Ekrana 100 yazar

            Console.ReadLine();
        }
    }
}