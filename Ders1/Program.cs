/*
1. Console Nedir?
Mantık: Karşındaki siyah terminal (konsol) ekranının kendisidir.

C#'ta ekrana bir şey yazdırmak veya klavyeden bir şey okumak istediğimizde, bunu her zaman 
Console aracılığıyla yaparız. C#'a "Ben şu an terminalle konuşmak istiyorum" demenin yoludur.


2. Console.Write() ile Console.WriteLine() Farkı Nedir?
İkisi de ekrana yazı basar, aralarındaki tek fark imlecin nerede kaldığıdır:

Console.Write(...): Yazıyı yazar ve imleci yazının bittiği yerde (aynı satırda) bekletir. Alt satıra geçmez.

Neden kullanılır? Kullanıcıdan girdi isterken ("Adınızı giriniz: ") cevabın hemen o yazının yanına 
yazılması için kullanılır.

Console.WriteLine(...): Yazıyı yazar ve otomatik olarak bir alt satıra geçer (Line = Satır).

3. Console.ReadLine() Nedir?
Mantık: Python'daki input() fonksiyonunun C#'taki tam karşılığıdır.

Program bu satıra geldiğinde çalışmayı durdurur ve kullanıcının klavyeden bir şeyler yazıp 
Enter tuşuna basmasını bekler.

Altın Kural: Kullanıcı ne yazarsa yazsın (ister harf, ister 100 gibi bir sayı), Console.ReadLine() bunu 
her zaman bir metin (string) olarak okur.


4. Convert.ToInt32() Neden Var?
Madem klavyeden gelen her şey metin (string), o zaman bilgisayar "10" ile "20" girdilerimizi sayı değil 
iki kelime gibi görür. Toplamaya kalkarsan 10 + 20 = 30 yapmak yerine kelimeleri yapıştırıp "1020" yapar.

İşte bu yüzden Convert.ToInt32(...) kullanarak gelen o metni gerçek bir tam sayıya (int) çeviririz. 
Python'daki int(input(...)) yapısının birebir aynısıdır.
*/


/*
// İsim alma
Console.Write("Adınızı giriniz: ");
string ad=Console.ReadLine();

// Sayıları alma ve dönüştürme
Console.Write("1.sayıyı giriniz: ");
int sayi1=Convert.ToInt32(Console.ReadLine());

Console.Write("2.sayıyı giriniz: ");
int sayi2=Convert.ToInt32(Console.ReadLine());

// İşlem yapma
int toplam=sayi1+sayi2;

// Sonucu yazdırma
Console.WriteLine("Merhaba " +ad+ ", sayıların toplamı: " +toplam);
*/


/*
Console.Write("Adınızı giriniz: ");
Ekrana "Adınızı giriniz: " yazar. Write kullandığımız için imleç iki noktanın hemen sağında yanıp sönerek bekler, 
alt satıra atlamaz.

string ad = Console.ReadLine();
Kullanıcı adını yazıp Enter'a bastığı an girilen metin yakalanır ve ad isimli string değişkenine kaydedilir.

int sayi1 = Convert.ToInt32(Console.ReadLine());
Burada iç içe iki işlem var:

Önce içteki Console.ReadLine() çalışır, kullanıcının girdiği sayıyı metin olarak alır (örneğin "25").

Dıştaki Convert.ToInt32(...) bu "25" metnini alır ve matematiksel 25 tam sayısına dönüştürür.

Sonuç sayi1 adlı int kutusuna aktarılır.

int toplam = sayi1 + sayi2;
İki tam sayı matematiksel olarak toplanır ve toplam kutusuna atanır.

Console.WriteLine("Merhaba " + ad + ", sayıların toplamı: " + toplam);

+ işaretleri burada metinleri birleştirmeye yarar. Sonucu ekrana basar ve WriteLine olduğu için imleci 
bir sonraki satıra geçirerek programı tamamlar.


Console.Write vs Console.ReadLine Mantığı
Python'daki input("Adınızı giriniz: ") tek başına iki işi birden yapar:

Ekrana mesaj basar ("Adınızı giriniz: ").
Klavyeden veri girilmesini bekleyip onu değişkene kaydeder.

C#'ta bu görevler ayrılmıştır:
Console.Write() tek başına klavyeden veri alamaz. Sadece ekrana yazı basar. İmlecin orada kalması 
"kullanıcıdan veri beklemek" anlamına gelmez; sadece bir sonraki yazılacak şeyin alt satıra kaymaması için 
yan yana durmasını sağlar.   

Console.ReadLine() ise ekrana hiçbir şey yazamaz. Yalnızca kullanıcının klavyeden tuşlara basıp Enter'a 
basmasını bekler ve girilen veriyi hafızaya alır.   


Eğer Console.Write("Adınızı giriniz: ") satırını yazmazsan, terminal bomboş siyah bir ekranda bekler; 
kullanıcı ne girmesi gerektiğini anlayamaz.

Eğer Console.ReadLine() yazmazsan, ekranda yazı yazar ama program kullanıcıya bir şey sormadan anında 
bir sonraki satıra geçip biter.

Aynen öyle, mantığı tam on ikiden vurdun!
Python'daki input("Adınızı giriniz: ") tek başına hem soruyu ekrana yazar hem de klavyeden gelen cevabı yakalar. 
C#'ta ise bu iki görev birbirinden tamamen ayrılmıştır:

Soruyu Sorma: Console.Write("...") ekrana soruyu basar ve imleci cevabın yazılacağı yerde hazır tutar.

Cevabı Yakalama: Console.ReadLine() kullanıcının klavyeden yazdığı cevabı okuyup hafızadaki değişkene aktarır.
*/



// HOCANIN ANLATIĞI KISIM //

/*
using System;

Neden var? C# çok geniş bir dil ve içinde binlerce hazır komut barındırır. 
Bu komutlar kategorilere (kütüphanelere) ayrılmıştır.

Bize ne sağlıyor? Ekrana yazı basmamızı sağlayan Console aletinin asıl tam adı System.Console'dur. 
Başa using System; yazdığında C#'a şunu demiş olursun: "Ben bu sayfada System kütüphanesinin 
elemanlarını kullanacağım, her defasında önüne uzun uzun System. yazdırma."

Yazmazsak ne olur? Kodun hata verir; çalışması için aşağıdaki her satırda tek tek System.Console.Write yazman gerekir.


namespace Calisma
Neden var? namespace (isim alanı), projeni diğer projelerden ayıran ana çatıdır (büyük kutu).   

Bize ne sağlıyor? Yarın başka bir derste veya kütüphanede yine Program adında bir sınıf olursa, 
sistem "Bu hangi Program?" diye şaşırmaz; "Bu Calisma kutusunun içindeki Program" der.


class Program
Neden var? C# tamamen Nesne Yönelimli (OOP) bir dildir; bağımsız, havada gezen hiçbir koda izin vermez. 
Kod yazmak için mutlaka bir sınıf (class) açmak zorundasın.   

Bize ne sağlıyor? İlgili fonksiyonları bir arada tutan bir çalışma odası oluşturur.


static void Main(string[] args)
Neden var? Programın başlangıç kapısıdır.   

Bize ne sağlıyor? Bir projede yüzlerce satır kod veya onlarca sınıf olabilir. Bilgisayar dotnet run dediğinde 
dosyaya bakar ve doğrudan Main kapısını bulup onun içindeki ilk satırdan çalışmaya başlar.   

static: Bu kapının program başlar başlamaz hazır ve açık olmasını sağlar.   

void: Bu kapıdaki işler bitince geriye herhangi bir veri/sonuç döndürülmeyeceğini belirtir.   

string[] args: Dışarıdan programa parametre vermek için kullanılan bir dizidir 
(şimdilik standart kalıptır, dokunmuyoruz).


int a = 100, b = 200;
Aynı satırda iki ayrı tam sayı (int) kutusu tanımlanıp içlerine değerleri kondu.   

Console.Write("Sonuç");
Ekrana Sonuç yazar ve alt satıra geçmez, imleç kelimenin bittiği yerde bekler.   

Console.Write(1 + ".sayı");
1 sayısı ile ".sayı" metnini birleştirip 1.sayı yapar. Önceki satır alt satıra geçmediği için doğrudan onun 
yanına yapışır: Sonuç1.sayı.   

Console.WriteLine("Adınız");
Yanına Adınız yazar (Sonuç1.sayıAdınız) ve WriteLine olduğu için imleci bir alt satıra atar.   

Console.Write("a+b=" + (a + b));
İkinci satırda a+b= yazar. (a + b) parantez içinde olduğu için önce toplama yapılır (300) ve 
metnin yanına eklenir: a+b=300.


namespace (İsim Alanı) mantığını günlük hayattan bir örnekle somutlaştıralım:

Günlük Hayat Örneği: İsim ve Soyisim
Diyelim ki sınıfında adı "Ahmet" olan bir öğrenci var. Yan sınıfta da adı "Ahmet" olan başka bir öğrenci var.

Biri koridorda sadece "Ahmet!" diye seslense, iki sınıftan da Ahmetler bakar veya kimin çağrıldığı karışır.

Bu karışıklığı çözmek için ne yaparız? Soyadını söyleriz:
Yılmaz.Ahmet
Kaya.Ahmet

İşte C#'taki mantık birebir budur:
class Program dediğin şey o sınıfın adı (Ahmet) gibidir.

namespace Calisma dediğin şey ise o sınıfın soyadı ya da ailesi (Yılmaz) gibidir.

C# Kodunda Gerçekte Ne İşe Yarar?
C# çok büyük bir sistemdir. Microsoft'un kendi içinde yazdığı binlerce sınıfın arasında bile adı 
Program, Task veya Button olan sınıflar bulunabilir.

Eğer namespace olmasaydı:
Sen kendi projende bir class Program açtığında, C# derleyicisi "Benim kendi içimde de Program diye bir yer var, 
sen hangisini kastediyorsun?" deyip kafayı yer ve çakışma hatası verirdi.

Ama sen sınıfını bir namespace çatısı altına aldığında:

C# artık o sınıfın tam adresini şöyle kaydeder:
Calisma.Program

Böylece dünyanın herhangi bir yerindeki başka bir kütüphanede Ders.Program veya Oyun.Program olsa bile, 
senin yazdığın kod asla diğerleriyle karışmaz.

Özetle namespace, C#'ta aynı isimli sınıfların birbirine girmesini engelleyen bir soyisim ve adres etiketidir.

Çok yerinde ve harika bir soru! Eğer isim de soyisim de (Calisma.Program) birebir aynı olursa ne olur?

Böyle bir durumda iki farklı senaryo ortaya çıkar:

1. Senaryo: İkisi de Aynı Projenin İçindeyse
Eğer kendi projenin içinde bilerek veya yanlışlıkla iki tane Calisma.Program açarsan:

C# derleyicisi kırmızı alarm verir ve şu hatayı fırlatır:
"Calisma isim alanı içinde zaten Program adında bir sınıf tanımlı."

Çözüm: Kendi projende aynı isim alanına aynı sınıf adını iki kere veremezsin; birinin adını Program2 ya da 
isim alanını Calisma2 yapmak zorundasın.

2. Senaryo: Biri Dışarıdan Yüklediğin Bir Paketteyse (Daha Olası Durum)
Diyelim ki bir arkadaşın veya başka bir yazılımcı bir kütüphane yazmış, o da senin gibi 
Calisma.Program adını kullanmış ve sen o kütüphaneyi projene eklemişsin.

Yazılım dünyasında bu çakışmayı önlemek için şirketler ve geliştiriciler alt isim alanları (noktalı yapı) kullanırlar. 
Adresi sadece ilçe değil, "Ülke.Şirket.Proje" gibi genişletirler:

Seninki: Umran.Calisma.Program
Diğerininki: Microsoft.Calisma.Program

Peki ya buna rağmen dış kütüphanedeki ad da tamamen Calisma.Program olarak birebir çakışırsa? 
C# buna da bir çözüm üretmiştir:

Çözüm 1: Takma Ad (Alias) Vermek
En başa using yazarken o sınıfa özel bir takma ad verirsin:

using DisaridakiProgram = DigerKutuphane.Calisma.Program;
Böylece kodun içinde Program yazarsan seninki, DisaridakiProgram yazarsan dışarıdan gelen çalışır.

Çözüm 2: global:: Anahtarı
C#'ın en kök dizinini belirten global:: kelimesiyle derleyiciye kesin adres tarif edersin:
global::Calisma.Program

Kısacası; kendi projende aynı adresi iki kez kullanamazsın derleyici hata verir, dış kütüphanelerle çakışırsa da 
C# takma isim verme imkânı sunarak kilidi çözer.


# static void Main(string[] args) #

Günlük hayattan benzetmemiz şu olsun: Büyük bir fabrika veya bir bina.

Bir fabrikada üretim bantları, yemekhane, depolar, yüzlerce çalışan ve alet edevat bulunur. 
Ama fabrikanın çalışabilmesi için bir "Ana Giriş Kapısı" ve bu kapıyı açan bir "Şalter" gerekir.

İşte static void Main(string[] args) o fabrikanın ana giriş kapısıdır. Bilgisayar programı başlatınca 
diğer odalara bakmaz; doğrudan bu kapıdan içeri girer.

Şimdi bu kapının üstündeki 4 kelimelik tabelayı parça parça sökelim:

Main (Kapının Adı: "Ana Kapı")
Günlük Hayat: Bir binada onlarca kapı veya oda olabilir (Mutfak, Depo, Ofis). Ama binaya nereden girileceğini 
gösteren tabelada "Giriş / Ana Kapı" yazar.

C#'taki Görevi: Main İngilizce'de "Ana / Temel" demektir. C# programı çalıştırdığı an dosyada bin satır da 
olsa sadece bu kelimeyi arar. "Benim ilk açacağım yer burası" der.

static (Kapının Durumu: "Her Zaman Hazır ve Açık")
Günlük Hayat: Normalde bir ofisteki aletleri kullanmak için önce bir çalışanın gelip masayı açması, 
hazırlık yapması gerekir. Ama Ana Giriş Kapısı için kimseden izin alınmaz; bina oradaysa o kapı zaten 
dışarıya doğrudan açıktır, içeri girmek için bina içinde başka bir şey üretmen gerekmez.

C#'taki Görevi: C# Nesne Yönelimli olduğu için normalde bir şeyleri çalıştırmak için önce hafızada yer açıp 
nesne üretmek gerekir. Ama static dersen C#'a şunu demiş olursun: 
"Hiçbir ön hazırlık yapma, doğrudan bu kapıyı aç ve çalıştır."

void (Geriye Dönüş: "İşini Yap, Bana Bir Şey Getirme")
Günlük Hayat: Birine "Git marketten ekmek al" dersen, sana geri dönerken elinde ekmekle gelir (bir değer döndürür). 
Ama birine "Git kapıyı kapat" dersen, gider kapıyı kapatır ve döner; elinde sana vereceği bir nesne yoktur, 
sadece iş yapılmıştır.

C#'taki Görevi: void İngilizce'de "boş / hükümsüz" demektir. Yani: "Bu kapıdan gir, içerideki satırları sırayla 
çalıştır (ekrana yazı yaz, toplama yap) ama program bitince bana cebinde bir sonuç verisiyle dönmene gerek yok."

string[] args (Girişte Alınan Çanta: "Dışarıdan Verilen Talimatlar")
Günlük Hayat: Bir fabrikaya sabah giren işçilerin eline kapıda bazen bir liste veya evrak çantası verilir: 
"Bugün şu siparişleri üretin."

C#'taki Görevi: string[] bir metin listesi/dizisi demektir. args ise "arguments" (argümanlar) kelimesinin 
kısaltmasıdır. Programı terminalden çalıştırırken kapıdan içeriye fazladan bilgi/talimat sokmak istersen kullanılır. 
Şimdilik burayı hiç kullanmıyoruz, içi boş bir çanta gibi kapıda bekliyor.

Tek Cümlelik Özet
static void Main(string[] args):

"Program açılır açılmaz hiçbir ön hazırlığa gerek duymadan (static), geriye ekstra bir değer döndürmeden (void), 
dışarıdan gelebilecek olası talimat çantasıyla (string[] args), ilk çalıştırılacak olan Ana Giriş Kapısıdır (Main)."
*/

/*
using System;

namespace Ders1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=100, b=200;
            Console.Write("Sonuç ");
            Console.Write(1 + ".sayı ");
            Console.WriteLine("Adınız");
            Console.Write("a+b= " + (a+b));
        }

    }
}

*/

/*
Calisma Altındaki Üç Nokta (...) Nedir?
Anlamı: VS Code derleyicisinin hafif bir stil / düzen önerisidir. Kırmızı (hata) veya sarı (uyarı) değildir.

Neden Çıkar?
C#'ın modern sürümlerinde süslü parantezli namespace Calisma { ... } yazmak yerine, parantezleri kaldırıp 
tek satırda namespace Calisma; (File-scoped namespace) yazılması önerilir.   

Bazen de dosyanın bulunduğu klasör adı (Ders1) ile kodda tanımlanan isim alanının adı (Calisma) birebir 
aynı olmadığında editör kibarca bunu hatırlatır.   

Sorun Teşkil Eder mi? Kesinlikle hayır; hocanın klasik tarzına uygundur ve çalışmayı etkilemez.


0 references (0 Başvuru) Nedir?
Anlamı: "Bu sınıf veya kapı dosya içinde başka hiçbir kod tarafından çağrılmıyor / kullanılmıyor" demektir.   

Neden Çıkar?
Normal bir projede yazdığın bir fonksiyonu başka bir dosyadan veya sınıftan çağırıp kullanırsın. 
VS Code o zaman 1 reference, 5 references diye sayar.

Ancak class Program ve Main kapısını doğrudan biz çağırmayız; program başlarken onu bilgisayarın 
kendisi otomatik tetikler.   

Dolayısıyla VS Code'un kod içi sayaçta 0 references görmesi Main metodu için tamamen normal ve beklenen durumdur.
*/

/*

using System;
namespace Ders1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Double x;
            String s;
            s=Console.ReadLine();
            a=Convert.ToInt32(s);
            x=Double.Parse(s);
            Console.ReadLine();
            a=Convert.ToInt32(s);
        }
    }
}

*/

/*
Bilgisayar İçin Sayı ve Yazı Aynı Şey Değildir
Klavyeden tuşlara bastığında bilgisayar ne yazdığını bilmez.

Sen klavyeden 50 yazıp Enter'a bastığında, bilgisayar bunu matematiksel bir değer olan 50 olarak görmez.

Onu iki tane harf yan yana gelmiş gibi algılar: "50" (bir metin / string).

Metinlerle matematiksel işlem yapamazsın. Metin olan "50" ile "50"yi toplamaya kalkarsan sonuç 100 değil, 
yan yana yapışıp "5050" olur.

İşte bu yüzden klavyeden gelen metni matematiksel bir sayıya çevirmek zorundayız.

Değişkenleri Hazırlama
String s; → Metin saklamak için bir değişken açtık.
int a; → Tam sayı saklamak için bir değişken açtık.
Double x; → Virgüllü/ondalıklı sayı saklamak için bir değişken açtık.

Klavyeden Veriyi Alma
s = Console.ReadLine();
Program kullanıcıdan girdi bekler. Sen klavyeden 20 yazdın diyelim.
Console.ReadLine() bunu metin olarak okur ve s içine koyar.
Şu an s değişkeninin içinde metin olan "20" var.

Asıl Karışan Kısım: Convert ve Parse Nedir?
Elimizde bir metin var: "20". Biz bunu matematiksel bir sayı yapmak istiyoruz.
C# bize der ki:
"Bir metni sayıya dönüştürmek için iki farklı yolun var. İkisini de kullanabilirsin."
Hoca da sınıfta iki yolu birden gör diye ikisini alt alta yazdı.


Convert.ToInt32(s)
Görevi: Dönüştürme işlemi yapar.

Mantığı: Convert İngilizce'de "dönüştürmek" demektir. ToInt32 ise 
"32-bitlik bir tam sayıya (yani int türüne) dönüştür" demektir.

Ne yapar? Parantez içine verdiğin s metnini ("20") alır, onu gerçek matematiksel tam sayı olan 20 yapar ve 
a değişkenine kaydeder.

Python Karşılığı: Python'daki int("20") ile tamamen aynı iştir.

Double.Parse(s)
Görevi: Bu da dönüştürme işlemi yapar.

Mantığı: Parse kelimesi yazılımda "metni oku, içini tara ve çöz" demektir. 
Başına Double. koyduğumuz için anlamı şudur: "Metni oku ve onu ondalıklı bir sayı (double) olarak çöz."

Ne yapar? Parantez içindeki s metnini ("20") alır, içindeki rakamları inceler, geçerli bir sayı olduğunu anlar ve 
onu ondalıklı bir sayıya (20.0) çevirip x değişkenine kaydeder.

Python Karşılığı: Python'daki float("20") ile tamamen aynı iştir.


Özetle Aralarındaki Fark Nedir?
İkisi de metni alıp sayıya çevirir. Tek amaçları budur.

Eğer tam sayıya çevirmek istersen:
Convert.ToInt32(s) diyebilirsin.
Ya da int.Parse(s) diyebilirsin.

Eğer ondalıklı sayıya çevirmek istersen:
Convert.ToDouble(s) diyebilirsin.
Ya da hocanın yazdığı gibi Double.Parse(s) diyebilirsin.

Aralarındaki tek küçük teknik fark şudur:
Parse, sadece metinleri (string) dönüştürmek için tasarlanmıştır. Eğer kullanıcı hiçbir şey yazmazsa 
(içi boş kalırsa) program kızar ve hata verir.

Convert ise biraz daha esnektir; içi boş gelse bile hata vermek yerine onu 0 kabul eder.

Ama üniversite dersinde ve sınavlarda ikisi de aynı amaçla kullanılır: Klavyeden metin olarak gelen 
veriyi hesaplama yapabileceğimiz bir sayıya çevirmek.


Harika bir soru! Mantığı tam kalbinden yakaladın: "Ümran" yazısının rakamla hiçbir alakası yok.

Bu durumda bilgisayar sihirbazlık yapamaz ve her iki yöntem de çöker, ekrana kıpkırmızı 
bir hata (FormatException) fırlatır.

Kod Arkada Ne Yapar?
Diyelim ki klavyeden Ümran yazdın ve değişkenin içine bu metin girdi:
s = "Ümran";
Ardından şu iki satırdan biri çalıştı:
a = Convert.ToInt32(s);
x = Double.Parse(s);
Bilgisayar harfleri tek tek inceler:
İlk karaktere bakar: 'Ü'
Derleyici şunu der: "Bu bir rakam değil, eksi işareti değil, nokta değil; ben bunu nasıl sayı yapayım?!"
İşlemi yapamaz ve hemen çalışmayı durdurur.


Ekrana Gelen Hata Nedir?
Terminalde veya ekranda tam olarak şu teknik hata mesajını görürsün:
System.FormatException: The input string 'Ümran' was not in a correct format.

(Girdi dizesi doğru biçimde değildi.)

Yani program sonraki satırlara geçemez; tıpkı Python'da int("Ümran") yazdığında aldığın ValueError gibi 
program o anda patlar ve kapanır.


Gerçek Hayatta Yazılımcılar Bunu Nasıl Çözer?
İlerleyen derslerde hoca muhtemelen gösterecektir ama merakını gidermek için önden söyleyeyim:

Kullanıcının sayı yerine kendi adını yazıp programı patlatmasını engellemek için 
C#'ta int.TryParse veya double.TryParse adlı bir "güvenli deneme" yöntemi kullanılır.

Mantığı şudur:
"Bunu sayıya çevirmeyi bir dene. Çevirebiliyorsan sayı yap, ama içinde 'Ümran' gibi harfler varsa programı patlatma; 
bana sadece 'çeviremedim' de."

Özetle: Convert de olsa Parse de olsa, metnin içinde sadece ve sadece rakamlar (ve ondalık için virgül/nokta) 
bulunmak zorundadır; harf girilirse iki yöntem de anında hata verir.
*/


/*
using System;
namespace Ders1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Türkiye");
            Console.Write("Fenerbahçe");
            Console.WriteLine("Deneme");
        }
    }
}

*/


/*

"Kaçış Karakterleri" (Escape Sequences)

Mantığı Nedir? Neden Böyle Şeylere İhtiyaç Duyarız?
C#'ta çift tırnak "" arasına yazdığın her şey metindir. Fakat bilgisayara klavyede doğrudan basamayacağın 
komutları (örneğin alt satıra in, sekme boşluğu bırak, çift tırnak işaretinin kendisini ekrana bas) 
metin içinde nasıl anlatırsın?   

İşte bu yüzden ters eğik çizgi \ (Backslash) kullanılır.

Ters çizgi, C#'a şunu söyler:

"Dikkat et! Arkamdan gelen harfi normal bir yazı gibi ekrana basma; onun gizli bir görevi var, o görevi yerine getir!"


\n (New Line - Yeni Satır):
Görevi: İmleci anında bir alt satıra atar. Metnin neresine koyarsan koy, oradan itibaren yazı aşağıya geçer.   

\t (Tab - Sekme Boşluğu):
Görevi: Klavyedeki Tab tuşuna basmış gibi 4 veya 8 karakterlik geniş bir düzenli boşluk bırakır. 
Tablo gibi hizalı yazılarda kullanılır.   

\b (Backspace - Geri Silme):
Görevi: Klavyedeki silme (Backspace) tuşu gibidir. İmleci bir karakter geriye alır ve oradaki karakterin 
üstüne yazar/siler.   

\\ (Ters Eğik Çizgi):
Görevi: Tek bir \ yazarsan C# bunu komut sanıp hata verebilir. Ekrana gerçekten tek bir \ işareti basmak 
istiyorsan yan yana iki tane \\ yazarsın.   


\" (Çift Tırnak):
Görevi: C#'ta metinler zaten çift tırnakla başlayıp biter. Metnin tam ortasında "Ali 'merhaba' dedi" gibi 
çift tırnak görünmesini istersen \" şeklinde yazarsın. C# bunu metnin bitişi değil, ekrana basılacak 
tırnak işareti olarak anlar.   

\r (Carriage Return - Satır Başı):
Görevi: Daktilo mantığıdır. İmleci bulunduğu satırın en başına götürür. Eğer satırın başında yazı varsa, 
sonra gelen harfler baştaki harflerin üzerine yazılır.   

\uXXXX (Unicode Karakteri):
Görevi: Klavyede olmayan özel simgeleri (örneğin tescilli marka  
R
◯
 , telif hakkı  
c
◯
 , derece işareti °) basmak için 4 haneli özel onaltılık (hex) kodunu çalıştırmayı sağlar.   

Tahtadaki kodda hoca \u00AE yazmış: Bu kod tescilli marka simgesidir (®).   


*/


/*

using System;
namespace Ders1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Türkiye\r");
            Console.Write("Fenerbahçe\"");
            Console.WriteLine("Kayıtlı Marka\u00AE");
        }
    }
}

*/



/*

Console.WriteLine("Türkiye\r");
Türkiye yazar, ardından \r ile satırın en başına döner. Fakat ardından WriteLine 
çalıştığı için yine de alt satıra geçer.   

Console.Write("Fenerbahçe\"");
Ekrana Fenerbahçe" basar (tırnak işaretiyle birlikte). Write olduğu için alt satıra geçmez, 
imleç tırnağın dibinde bekler.   

Console.WriteLine("Deneme\'");
Hemen yanına yapışır: Fenerbahçe"Deneme' olur ve alt satıra geçer.   

Console.WriteLine("Kayıtlı Marka\u00AE");
\u00AE kodu sayesinde ekrana Kayıtlı Marka® yazar.

*/


/*

using System;
namespace Ders1
{
    class program
    {
        static void Main(string[] args)
        {
            int a=2;
            Console.WriteLine("example\u0040.btu.edu.tr");
            Console.WriteLine(a + "'nın karesi = " + a*a);
            Console.WriteLine("Pi sayısı = \t" + 3.14159265);
            Console.Write(784 + "\n");
            Console.Write("Merhaba\nTürkiye");
            Console.ReadLine();
        }
    }
}

*/

/*

using System;
namespace Ders1
{
    class program
    {
        static void Main(string[] args)
        {
            double i=6543.124;
            int a=8762;
            Console.WriteLine("A değişkeni ={0} dir", a);
            Console.WriteLine("{0:C} dir", i);
            Console.WriteLine("{0:D} dir", a);
            Console.WriteLine("{0:E} dir", i);
            Console.WriteLine("{0:F} dir", i);
            Console.WriteLine("{0:G} dir", a);
            Console.WriteLine("{0:N} dir", a);
            Console.WriteLine("{0:X} dir", a);
            Console.WriteLine("{0:x} dir", a);
            Console.WriteLine("{0:D5} dir", a);     // Belirli basamağa tamamlama (D5)
            Console.WriteLine("{0:E} ve {1:E} dir", i, a);   // Birden fazla değişken indeksleme ({0} ve {1})

            Console.ReadLine();
        }
    }
}
*/


/*
Format Belirteçleri (Format Specifiers) ve Yer Tutucular ({0}).

C#'ta değişkenleri ekrana basarken sürekli + ile yapıştırmak yerine, süslü parantez içine {0} koyup virgülden 
sonra değişkenin adını yazabiliriz. İki nokta üst üste (:) koyup yanına eklediğimiz harf ise sayının 
nasıl biçimlendirileceğini belirler.

Görseldeki iki değişkenimiz:
double i = 6543.124;
int a = 8762;


Satır Satır Format Belirteçlerinin Görevleri
Console.WriteLine("A değişkeni ={0} dir", a);
{0} → İlk sıradaki değişkeni (a) olduğu gibi buraya yerleştirir.
Biçimlendirme yoktur, doğrudan 8762 yazar.


Console.WriteLine("{0:C} dir", i);
C (Currency - Para Birimi): Sayıyı para formatına çevirir. Binlik basamak ayırıcı (nokta) ve para sembolü koyar.
Çıktı: ₺6.543,12 (veya sistem diline göre para simgesiyle).


Console.WriteLine("{0:D} dir", a);
D (Decimal - Tam Sayı Formatı): Sadece tam sayılarda (int) çalışır. Sayıyı standart onluk tabanda 
tam sayı olarak gösterir.

Çıktı: 8762.


Console.WriteLine("{0:E} dir", i);
E (Exponential - Bilimsel Gösterim): Sayıyı üslü bilimsel formatta yazar (10 üzeri şeklinde).
Çıktı: 6,543124E+003 (yani 6.543124×10 
3
 ).


 Console.WriteLine("{0:F} dir", i);
F (Fixed-point - Sabit Noktalı): Sayıyı virgülden sonra standart 2 basamak kalacak şekilde yuvarlar.
6543.124 sayısının sonundaki 4 atılır, çıktı: 6543,12 olur.


Console.WriteLine("{0:G} dir", a);
G (General - Genel Biçim): Sayının türüne göre en sade ve en okunabilir formatı derleyici kendisi seçer.
Çıktı: 8762.


Console.WriteLine("{0:N} dir", a);
N (Number - Sayı Formatı): Sayıya binlik ayırıcı ve virgülden sonra iki sıfır ekler.
Çıktı: 8.762,00 olur.


Console.WriteLine("{0:X} dir", a);
X (Hexadecimal - Onaltılık Taban): Sayıyı 16'lık tabana dönüştürür ve harfleri BÜYÜK yazar.
8762 sayısının 16'lık tabandaki karşılığı: 223A.


Console.WriteLine("{0:x} dir", a);
x (Küçük Hexadecimal): Yine 16'lık tabana çevirir ama harfleri küçük yazar.
Çıktı: 223a.

Console.WriteLine("{0:D5} dir", a); 

Belirli Genişlikte Basamak Tamamlama: {0:D5}
Mantığı Nedir?
D belirteci yalnızca tam sayılar (int, long vb.) ile çalışır ve İngilizce Decimal (Onluk tam sayı) kelimesinden gelir.

Yanına bir rakam yazdığımızda (örneğin 5), derleyiciye şunu söyleriz:
"Bu sayıyı ekrana basarken toplamda en az 5 basamak yer kaplasın. Eğer sayının kendi basamak sayısı 5'ten azsa, 
eksik kalan sol kısmı 0 ile tamamla."

Bizim Örneğimizde:
a = 8762 sayısı 4 basamaklıdır.
Biz {0:D5} dediğimiz için derleyici sola 1 tane 0 ekler.
Ekran Çıktısı: 08762 dir

Peki Sayı Zaten 5 Basamaktan Büyük Olsaydı?
Örneğin sayı 123456 olsaydı ve biz {0:D5} deseydik, sayı kesinlikle kırpılmaz veya bozulmazdı; 
doğrudan 123456 yazılırdı.

Console.WriteLine("{0:E} ve {1:E} dir", i, a);

Birden Fazla Değişkeni İndeksle Biçimlendirme: {0:E} ve {1:E}
Mantığı Nedir?
C#'ta metin içine dışarıdan değer aktarırken sıfır tabanlı indeksleme (zero-based indexing) kullanılır.

Console.WriteLine("...", i, a); ifadesinde virgülden sonra gelen değişkenler sırayla numaralandırılır:
0. indeks → i
1. indeks → a

Süslü parantez içine yazdığımız ilk sayı hangi değişkeni alacağını, iki noktadan (:) sonraki harf ise 
o değişkene hangi kuralın uygulanacağını belirtir.

Biçim Belirteci (E - Exponential):
E, sayıyı bilimsel/üslü gösterim (Exponential) biçiminde yazar 
(sayıyı 1.0 ile 9.99 arasına getirip yanına 10'un kuvvetini E+xxx şeklinde ekler).

Bizim Örneğimizde:
{0:E} → İlk değişken olan i = 6543.124 değerini alır: 6,543124E+003
{1:E} → İkinci değişken olan a = 8762 değerini alır: 8,762000E+003
Ekran Çıktısı: 6,543124E+003 ve 8,762000E+003 dir
*/

/*
using System;

namespace Ders1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=2;

            Console.WriteLine("example\u0040.btu.edu.tr");
            Console.WriteLine(a + " 'nın karesi = " + a*a);
            Console.WriteLine("Pi Sayısı = \t" + 3.14159265);
            Console.Write(784 + "\n");
            Console.Write("Merhaba\nTürkiye");

            Console.ReadLine();
        }
    }
}
*/

/*

\n : Alt satır (New Line)   

\t : Tab boşluğu (Geniş boşluk)   

\b : Backspace (Bir önceki karakteri silme/geri alma)   

\\ : Ters eğik çizgi (Kod içinde tek başına \ hata vermesin diye \\ yazılarak tek bir \ gösterilir)   

\uXXXX : Hex Unicode karakteri çağırma

*/

/*
using System;

namespace Ders1
{
    class Program
    {
        static void Main(string[] args)
        {
            double i = 6543.124;
            int a = 8762;

            Console.WriteLine("A değişkeni ={0} dir", a);
            Console.WriteLine("{0:E2}", i);
            Console.WriteLine("{0:F1}", a);
            Console.WriteLine("{0:G6}", i);
            Console.WriteLine("{0:N6}", i);
            Console.WriteLine("{0:X6}", a);
            Console.WriteLine("{0:x4}", a);

            Console.ReadLine();
        }
    }
}
*/

/*
C (Currency): Para birimi formatına çevirir.
D (Decimal): Tam sayıyı yazar; yanındaki sayı kadar basamağa tamamlayıp eksikse soluna sıfır ekler (örn. D5).
E (Exponential): Bilimsel/üslü gösterim yapar (6,54E+003).
F (Fixed-point): Sabit ondalıklı yazar; yanındaki sayı virgülden sonraki basamak sayısını belirler (örn. F1).
G (General): Sayıyı en sade/kompakt haliyle gösterir; yanındaki sayı toplam anlamlı basamak adedini belirler.
N (Number): Binlik basamak ayırıcı (nokta/virgül) ekleyerek yazar; yanındaki sayı ondalık basamağı ayarlar (örn. N5).
X / x (Hexadecimal): Tam sayıyı 16'lık tabana çevirir; büyük X harfleri büyük, küçük x küçük yazar; 
yanındaki sayı toplam hane genişliğini belirler (örn. X6).
*/

/*
using System;

namespace Ders1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime tz = DateTime.Now;

            Console.WriteLine("Tarih ve Saat = {0}", tz);
            Console.WriteLine("Tarih = {0:d}", tz);
            Console.WriteLine("Uzun Tarih Saat = {0:f}", tz);
            Console.WriteLine("Gün Ay = {0:m}", tz);
            Console.WriteLine("Saat = {0:T}", tz);
            Console.WriteLine("Ay Yıl = {0:y}", tz);

            Console.ReadLine();
        }
    }
}
*/


/*
Bu kodda DateTime tz = DateTime.Now; komutuyla bilgisayarın o anki güncel tarih ve saat bilgisi 
tz değişkenine atanıyor. Ardından gelen format harfleri ekrana ne yazdırılacağını belirliyor:   

{0} (Varsayılan Gösterim):
Tarih ve saati sistemin standart kısa formatında birlikte basar.   
Çıktı: Tarih ve Saat = 1.10.2026 15:21:20
   
{0:d} (Kısa Tarih - short Date):
Sadece gün, ay ve yılı kısa formatta (sayılarla) yazar, saat bilgisini atar.   
Çıktı: Tarih = 1.10.2026

{0:f} (Tam/Uzun Tarih ve Kısa Saat - Full date/short time):
Günü yazıyla, ayı yazıyla ve haftanın gününü de belirterek saatiyle birlikte yazar.   
Çıktı: Uzun Tarih Saat = 1 Ekim 2026 Perşembe 15:21
   

{0:m} (Ay ve Gün - Month/day):
Yıl bilgisini atarak yalnızca gün ve ay adını gösterir.   
Çıktı: Gün Ay = 1 Ekim
   

{0:T} (Uzun Saat - long Time):
Tarihi atar; sadece saat, dakika ve saniyeyi gösterir.   
Çıktı: Saat = 15:21:20

{0:y} (Ay ve Yıl - Year/month):
Günü atar; sadece ay adını ve yılı gösterir.   
Çıktı: Ay Yıl = Ekim 2026
*/


using System;

namespace Ders1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            double x;
            string s;

            Console.Write("Tam Sayı Giriniz : ");
            s = Console.ReadLine();
            a = Convert.ToInt32(s);
            Console.WriteLine("Girdiğiniz Tam Sayı : {0}", a);

            Console.Write("Adınız : ");
            s = Console.ReadLine();
            Console.Write("Adınız : {0} mış\n", s);

            Console.Write("Pi Sayısını Giriniz : ");
            s = Console.ReadLine();
            x = Double.Parse(s);
            Console.WriteLine("Pi Sayısı : {0}", x);

            Console.ReadLine();
        }
    }
}



/*
Bu kodda kullanıcıdan klavyeden veri alma (Console.ReadLine()) ve bu verileri 
uygun türlere dönüştürme (tip dönüşümü) işleniyor:   

Console.ReadLine() Temel Kuralı: Klavyeden ne girilirse girilsin veriyi her zaman string (metin) olarak okur.   

Tam Sayıya Çevirme (Convert.ToInt32):
Okunan metni (s) int türüne dönüştürmek için Convert.ToInt32(s) kullanılır ve a değişkenine atanır.   

Metin Olarak Kullanma:
İsim okunurken zaten metin olduğu için hiçbir dönüştürme yapılmadan doğrudan s olarak ekrana yazdırılır.   

Ondalıklı Sayıya Çevirme (Double.Parse):
Okunan metni (s) double türüne dönüştürmek için Double.Parse(s) yöntemi kullanılır ve x değişkenine aktarılır.   

Kısacası: Metin girdilerini sayısal işlemler için kullanabilmek adına Convert.ToInt32() veya Double.Parse() gibi 
dönüştürücüler şarttır.
*/

