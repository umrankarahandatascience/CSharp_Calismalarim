/*
using System;
namespace Calisma
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -100, mutlak_deger;
            mutlak_deger = a;
            
            if (a < 0)
            {
                mutlak_deger = (-1)*a;
            }

            Console.WriteLine(mutlak_deger);
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
        static void Main(string[] args)
        {
            int a = 100;

            if (a > 0)
            {
                Console.WriteLine("Pozitif");
            }
            else
            {
                Console.WriteLine("Negatif");
            }

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
        static void Main(string[] args)
        {
            int a = 50;

            if (a >= 90)
            {
                Console.WriteLine("A");
            }
            else if (a >= 80)
            {
                Console.WriteLine("B");
            }
            else if (a >= 70)
            {
                Console.WriteLine("C");
            }
            else if (a >= 60)
            {
                Console.WriteLine("D");
            }
            else if (a >= 50)
            {
                Console.WriteLine("E");
            }
            else
            {
                Console.WriteLine("F");
            }

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
        static void Main(string[] args)
        {
            int a = 500;

            if (a >= 10 && a <= 50)
            {
                Console.WriteLine("Aralıkta");
            }
            else
            {
                Console.WriteLine("Aralık Dışı");
            }

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
        static void Main(string[] args)
        {
            int numara = 7;

            if (numara == 7)
            {
                int not = 100;
                Console.WriteLine(not);

                numara ++;
                Console.WriteLine(numara);
            }

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
        static void Main(string[] args)
        {
            byte gun = 2;

            switch (gun)
            {
                case 1:
                Console.WriteLine("Pazartesi");
                break;

                case 2:
                Console.WriteLine("Salı");
                break;

                case 3:
                Console.WriteLine("Çarşamba");
                break;

                case 4:
                Console.WriteLine("Perşembe");
                break;

                case 5:
                Console.WriteLine("Perşembe");
                break;

                case 6:
                Console.WriteLine("Cumartesi");
                break;

                case 7:
                Console.WriteLine("Pazar");
                break;

                default:
                Console.WriteLine("Yanlış Gün Numarası ");
                break;
            }

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
        static void Main(string[] args)
        {
            char malzeme = 'A';
            byte kdv;

            switch (malzeme)
            {
                case 'A':
                case 'B':
                case 'C':

                kdv = 1;
                break;

                case 'D':
                case 'E':
                case 'F':
                
                kdv = 8;
                break;

                case 'G':
                case 'H':

                kdv = 18;
                break;

                default:
                kdv = 25;
                break;
            }

            Console.WriteLine("KDV = %" + kdv);
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
        static void Main(string[] args)
        {
            int a = 100, b;
            b = (a == 10) ? 40 : 20;

            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
*/

/*
using System;
namespace Calisma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tutar = 0;

            Console.Write("Tutarı Gir: ");
            tutar = Int32.Parse(Console.ReadLine());

            if (tutar < 500)
            {
                tutar += 20;
            }

            Console.WriteLine("Toplam Tutar = " + tutar);
            Console.ReadLine();
        }
    }
}
*/

using System;
namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sifre = "";
            string isim = "";

            Console.Write("İsim : ");
            isim = Console.ReadLine();

            Console.Write("Şifre : ");
            sifre = Console.ReadLine();

            if (isim == "Emin" && sifre == "123")
            {
                Console.Write("Giriş Başarılı");
            }
            else
            {
                Console.Write("Giriş Başarısız");
            }

            Console.ReadLine();
        }
    }
}