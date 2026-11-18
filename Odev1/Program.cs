// 1. Elemanları dışardan girilen 3x3 lük bir matrisi, matris biçiminde ekrana yazdırınız.

// 1.Satırın elemanlarını alıyoruz

/*
Console.Write("1.satır 1.eleman: ");
string? a1=Console.ReadLine();
Console.Write("1.satır 2.eleman: ");
string? a2=Console.ReadLine();
Console.Write("1.satır 3.eleman: ");
string? a3=Console.ReadLine();

// 2.Satırın elemanlarını alıyoruz
Console.Write("2.satır 1.eleman: ");
string? b1=Console.ReadLine();
Console.Write("2.satır 2.eleman: ");
string? b2=Console.ReadLine();
Console.Write("2.satır 3.eleman: ");
string? b3=Console.ReadLine();

// 3.Satırın elemanlarını alıyoruz
Console.Write("3.satır 1.eleman: ");
string? c1=Console.ReadLine();
Console.Write("3.satır 2.eleman: ");
string? c2=Console.ReadLine();
Console.Write("3.satır 3.eleman: ");
string? c3=Console.ReadLine();

Console.WriteLine("\nMatris:");
Console.WriteLine(a1 + "\t" + a2 + "\t" + a3);
Console.WriteLine(b1 + "\t" + b2 + "\t" + b3);
Console.WriteLine(c1 + "\t" + c2 + "\t" + c3);
*/


//  2. Çarpım tablosunu ekranda oluşturan kodları yazdırınız.
// Not: Döngü ifadeleri olmadan yalnızca ekrana yazdırma komutları ile yapınız.
/*
Console.WriteLine("1*1=1\t1*2=2\t1*3=3\t1*4=4\t1*5=5\t1*6=6\t1*7=7\t1*8=8\t1*9=9\t1*10=10");
Console.WriteLine("2*1=2\t2*2=4\t2*3=6\t2*4=8\t2*5=10\t2*6=12\t2*7=14\t2*8=16\t2*9=18\t2*10=20");
Console.WriteLine("3*1=3\t3*2=6\t3*3=9\t3*4=12\t3*5=15\t3*6=18\t3*7=21\t3*8=24\t3*9=27\t3*10=30");
Console.WriteLine("4*1=4\t4*2=8\t4*3=12\t4*4=16\t4*5=20\t4*6=24\t4*7=28\t4*8=32\t4*9=36\t4*10=40");
Console.WriteLine("5*1=5\t5*2=10\t5*3=15\t5*4=20\t5*5=25\t5*6=30\t5*7=35\t5*8=40\t5*9=45\t5*10=50");
Console.WriteLine("6*1=6\t6*2=12\t6*3=18\t6*4=24\t6*5=30\t6*6=36\t6*7=42\t6*8=48\t6*9=54\t6*10=60");
Console.WriteLine("7*1=7\t7*2=14\t7*3=21\t7*4=28\t7*5=35\t7*6=42\t7*7=49\t7*8=56\t7*9=63\t7*10=70");
Console.WriteLine("8*1=8\t8*2=16\t8*3=24\t8*4=32\t8*5=40\t8*6=48\t8*7=56\t8*8=64\t8*9=72\t8*10=80");
Console.WriteLine("9*1=9\t9*2=18\t9*3=27\t9*4=36\t9*5=45\t9*6=54\t9*7=63\t9*8=72\t9*9=81\t9*10=10");
Console.WriteLine("10*1=10\t10*2=20\t10*3=30\t10*4=40\t10*5=50\t10*6=60\t10*7=70\t10*8=80\t10*9=90\t10*10=10");

*/

// 3. Dışarıdan girilen kelimeleri yan yana yazdırınız.
/*
Console.Write("Kelime Giriniz: ");
string? kelime1=Console.ReadLine();
Console.Write("Kelime Giriniz: ");
string? kelime2=Console.ReadLine();

Console.WriteLine(kelime1 +" "+kelime2);

*/


// 4. Dışarıdan girilen ondalıklı sayıları virgülden sonra 1 basamaklı olarak yazdırınız.
/*
Console.Write("Ondalıklı bir sayı giriniz: ");
double sayi=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Sonuç:" + sayi.ToString("0.0"));
*/


// 5. Sistem saatini saat ve dakika cinsinden yazdırınız.
/*
int saat=DateTime.Now.Hour;
int dakika=DateTime.Now.Minute;

Console.WriteLine("Sistem Saati: " + saat + ":" + dakika);


*/


// 6. Sistem tarihini gün ve yıl yan yana olarak ekrana yazdırınız.

/*

int gun=DateTime.Now.Day;
int yıl=DateTime.Now.Year;

Console.WriteLine("Gün ve Yıl: " + DateTime.Now.ToString("dd/yyyy"));

*/

// 7. Dışarıdan girilen char tipindeki verinin 'E' olup olmadığını kontrol ediniz.


/*
Console.Write("Bir karakter giriniz: ");
char karakter=Convert.ToChar(Console.ReadLine());

Console.WriteLine("Girilen karakter 'E' mi?: " + (karakter=='E'));
*/





// 8. Dışarıdan girilen 3 sayıyı "birinci sayı = 4, ikinci sayı = 6 üçüncü sayı = 7
/*
Console.Write("1.sayıyı giriniz: ");
int sayi1=Convert.ToInt32(Console.ReadLine());

Console.Write("2.sayıyı giriniz: ");
int sayi2=Convert.ToInt32(Console.ReadLine());

Console.Write("3.sayıyı giriniz: ");
int sayi3=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("birinci sayı= " +sayi1+ " ikinci sayı= " +sayi2+ " üçüncü sayı= " +sayi3);

*/


// 9. Dışarıdan girilen sayının genişliğini 5 yaparak ekrana yazdırınız.
// Örneğin dışardan girilen sayı = 345 ise 00345 şeklinde yazdırılacak.
/*
Console.Write("Bir sayı giriniz: ");
int sayi=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sonuç= " + sayi.ToString("D5"));
*/

// 10. Dışarıdan girilen iki sayı ve bir string değeri aşağıdaki şekilde ekrana yazdırınız. 
//İki nokta üst üste işaretlerinin aynı sırada olmasına dikkat ediniz.
//1.Sayı   :  12
//2.Sayı   :  1234
//Adınız   :  Abdullah Yunus
/*
Console.Write("1.sayı: ");
int sayi1=Convert.ToInt32(Console.ReadLine());

Console.Write("2.sayı: ");
int sayi2=Convert.ToInt32(Console.ReadLine());

Console.Write("Adınız: ");
string? ad=Console.ReadLine();

Console.WriteLine("1.sayı\t: " + sayi1);
Console.WriteLine("2.sayı\t: " + sayi2);
Console.WriteLine("Adınız\t: " + ad);
*/