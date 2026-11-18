/*

// 1.Soru: Java ve C#'ta x = a++; işleminin eşdeğerini (aynı sonuç üreten), ++ operatörünü kullanmadan yapınız.

int a = 5;
int x;

x = a;
a = a + 1;

Console.WriteLine("x degeri: " + x);
Console.WriteLine("a degeri: " + a);
*/

/*
// 2.Soru: Java ve C#'ta x = --a; işleminin eşdeğerini (aynı sonuç üreten), -- operatörünü kullanmadan yapınız.

int a = 5;
int x;

a = a - 1;
x = a;

Console.WriteLine("x degeri: " + x);
Console.WriteLine("a degeri: " + a);
*/

/*
// 3.Soru: x=x+50; işleminde x'e bir başlangıç değeri vererek x'in eski ve yeni değerlerini ekrana yazdırınız.

int x = 20;

Console.WriteLine("x'in eski degeri: " + x);

x = x + 50;

Console.WriteLine("x'in yeni degeri: " + x);
*/

/*
// 5.Soru: 40 ile 100 sayısını hem ve hem de veya işlemlerine tabi tutarak sonucu yazdırınız.  

int sayi1 = 40;
int sayi2 = 100;

int veSonuc = sayi1 & sayi2;

int veyaSonuc = sayi1 | sayi2;

Console.WriteLine("40 & 100 (VE Sonucu): " + veSonuc);
Console.WriteLine("40 | 100 (VEYA Sonucu): " + veyaSonuc);
*/

/*
// 9.Soru: X = 10 + 20 , Y = X / 2 , T = Y - 3 , P = T * 2 işlemleri tek satırda yazınız

int P = (((10 + 20) / 2) - 3) * 2;

Console.WriteLine("P degeri: " + P);
*/

/*
// 10.Soru: X = 10 / 2 , Y = X + 5 , T = Y - 1 , P = T % 2  işlemleri tek satırda yazınız

int P = (((10 / 2) + 5) -1) % 2;

Console.WriteLine("P degeri: " + P);
*/

// 11.Soru: y = (3x/2).6z , y = ((2 + x)/5).(3^2) , x = ((3y + z)/5(y-3)).6t , x = (2x - 3)/4 - (x-5)/6 programlama diline aktarınız.

double x = 2;
double y = 4;
double z = 3;
double t = 5;

double y1 = (3*x / 2.0)*6*z;

double y2 = ((2 + x) / 5.0)*Math.Pow(3,2);

double x3 = ((3*y + z)/ (5.0*(y - 3)))*6*t;

double x4 = ((2*x - 3)/ 4.0) - ((x - 5) / 6.0);

Console.WriteLine("1. Formül: " + y1); 
Console.WriteLine("2. Formül: " + y2); 
Console.WriteLine("3. Formül: " + x3); 
Console.WriteLine("4. Formül: " + x4);