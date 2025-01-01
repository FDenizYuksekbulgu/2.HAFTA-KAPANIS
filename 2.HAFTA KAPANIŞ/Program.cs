See https://aka.ms/new-console-template for more information


//1.SORU

Console.WriteLine("Merhaba\nNasılsın?\nİyiyim\nSen nasılsın?");

Console.WriteLine("-------------------------------------------------------------------------------");

//2.SORU:  Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız.
//Bunların değerlerini atayıp , ekrana yazdırınız.

int tamSayi = 10;
string metinselDeger = "Katerina Witt";

Console.WriteLine(tamSayi);
Console.WriteLine(metinselDeger);
Console.WriteLine("-------------------------------------------------------------------------------");

//3.SORU:  Rastgele bir sayı üretip , ekrana yazdırınız.
Random rastgele = new Random();

int rastgeleSayi = rastgele.Next(1, 1000);
Console.WriteLine($"Rastgele Sayi: {rastgeleSayi}");
Console.WriteLine("-------------------------------------------------------------------------------");

//4.SORU:Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
Random rastgele = new Random();
int rastgeleSayi = rastgele.Next(1, 1000);
int kalan = rastgeleSayi % 3;
Console.WriteLine($"Rastgele Seçilen Sayı: {rastgeleSayi}");
Console.WriteLine($"Seçilen Sayının 3'e bölümünden kalan: {kalan}");
Console.WriteLine("-------------------------------------------------------------------------------");

//5.SORU:Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.


Console.WriteLine("Lütfen yaşınızı giriniz: ");


if (int.TryParse(Console.ReadLine(), out int yas))
{
// Yaşa göre sonucu yazdıralım.
    if (yas > 18)
    {
        Console.WriteLine("+");
    }
    else
    {
        Console.WriteLine("-");
    }
}
else
{
    Console.WriteLine("Geçerli bir yaş giriniz.");

}
Console.WriteLine("-------------------------------------------------------------------------------");

//6.SORU: Ekrana 10 defa " Sen Vodafone gibi anı yaşarken,ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken, ben Turkcell gibi seni her yerde çekemem!");
}
Console.WriteLine("-------------------------------------------------------------------------------");

//7.SORU: Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.

Console.WriteLine("Lütfen ilk ismi giriniz: ");
string isim1 = Console.ReadLine();

Console.WriteLine("Lütfen ikinci ismi giriniz: ");
string isim2 = Console.ReadLine();

string gecici = isim1;
isim1 = isim2;
isim2 = gecici;

Console.WriteLine("İsimlerin yeni hali:");
Console.WriteLine("Birinci isim: " + isim1);
Console.WriteLine("İkinci isim: " + isim2);
Console.WriteLine("-------------------------------------------------------------------------------");

//8.SORU:  Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız.
//Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.

static void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma.");
}

BenDegerDondurmem();
Console.WriteLine("-------------------------------------------------------------------------------");

//9.SORU: İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.

Console.WriteLine("Birinci sayıyı giriniz: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("İkinci sayıyı giriniz: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

int toplam = sayi1 + sayi2;
Console.WriteLine("Girilen sayıların toplamı: " + toplam);
Console.WriteLine("-------------------------------------------------------------------------------");

//10.SORU: Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.


Console.WriteLine("Lütfen true veya false giriniz: ");
bool kullaniciGirdisi = Convert.ToBoolean(Console.ReadLine());


string sonuc = DegeriDondur(kullaniciGirdisi);


Console.WriteLine("Sonuç: " + sonuc);
static string DegeriDondur(bool deger)
{
    if (deger)
    {
        return "Evet, doğru!";
    }
    else
    {
        return "Hayır, yanlış!";
    }
}
Console.WriteLine("-------------------------------------------------------------------------------");

//11.SORU:3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.

//Kullanıcıdan 3 kişinin yaşını alalım
Console.Write("1. kişinin yaşını giriniz: ");
int yas1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2. kişinin yaşını giriniz: ");
int yas2 = Convert.ToInt32(Console.ReadLine());

Console.Write("3. kişinin yaşını giriniz: ");
int yas3 = Convert.ToInt32(Console.ReadLine());

//En yaşlı olan kişinin yaşı bulunur.
int enYasli = EnYasliBul(yas1, yas2, yas3);


Console.WriteLine("En yaşlı kişinin yaşı: " + enYasli);


//En yaşlı olan kişinin yaşını döndüren metot
static int EnYasliBul(int yas1, int yas2, int yas3)
{
    //En yaşlıyı bulmak için Math.Max kullanıyoruz
    int enYasli = Math.Max(yas1, Math.Max(yas2, yas3));
    return enYasli;
}
Console.WriteLine("-------------------------------------------------------------------------------");

//12.SORU: Kullanıcıdan sınırsız sayıda sayı alıp,
//bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.


int enBuyuk = 0; //İlk en büyük değeri 0 kabul ederiz.
int sayi;

Console.WriteLine("Sayıları giriniz. İşlemi bitirmek için -5'e basınız: ");

while (true)
{
    Console.WriteLine("Bir sayı girin: ");
    sayi = Convert.ToInt32(Console.ReadLine());

    if (sayi == -5) //Kullanıcı -5 girerse döngü sonlanır.
    {
        break;
    }

    if (sayi > enBuyuk) //Eğer sayı mevcut en büyükten büyükse, güncelle
    {
        enBuyuk = sayi;
    }
}

Console.WriteLine("Girilen sayıların en büyüğü: " + enBuyuk);
Console.WriteLine("-------------------------------------------------------------------------------");

//13.SORU:Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.


//Kullanıcıdan iki isim alıyoruz.
Console.WriteLine("Birinci ismi girin: ");
string isim1 = Console.ReadLine();

Console.WriteLine("İkinci ismi girin: ");
string isim2 = Console.ReadLine();

//Yer değiştiren metodu çağırıyoruz.
YerDegistir(ref isim1, ref isim2);

//Yer değiştiren isimleri yazdırıyoruz
Console.WriteLine("Yer değiştiren isimler:");
Console.WriteLine("Birinci isim: " + isim1);
Console.WriteLine("İkinci isim: " + isim2);


// İsimlerin yerlerini değiştiren metotu yazalım.
static void YerDegistir(ref string isim1, ref string isim2)
{
    string gecici = isim1;
    isim1 = isim2;
    isim2 = gecici;
}
Console.WriteLine("-------------------------------------------------------------------------------");

//14.SORU: Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
//NOT:Girilen sayının tek mi olduğu sorgulanmıştır. Aynısı çift için de yapılabilir. 
//Ya da kullanıcı tel değilse çifttir yargısına ulaşabilir.

Console.WriteLine("Bir sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());



//Sayının tek mi çift mi olduğunu öğrenen metodu çağırıyoruz
bool sonuc = TekMi(sayi);

//Sonucu ekrana yazdıralım
Console.WriteLine("Girilen sayı tek mi? " + sonuc);


//Sayının tek mi çift mi olduğunu döndüren metot
static bool TekMi(int sayi)
{
    return sayi % 2 != 0; // Eğer sayı 2'ye bölünemiyorsa, tek demektir (true)
}
Console.WriteLine("-------------------------------------------------------------------------------");

//15.SORU: Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.

Console.WriteLine("Hız giriniz (km/saat): ");
double hiz = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Zaman giriniz (saat): ");
double zaman = Convert.ToInt32(Console.ReadLine());
//Yolu hesaplayan metodu çağırıyoruz
double yol = YoluHesapla(hiz, zaman);

Console.WriteLine("Gidilen yol: " + yol + " km");


static double YoluHesapla(double hiz, double zaman)
{
    return hiz * zaman;
}
Console.WriteLine("-------------------------------------------------------------------------------");

//16.SORU: Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.

Console.WriteLine("Dairenin yarıçapını giriniz: ");
double yariCap = Convert.ToDouble(Console.ReadLine());


//Alanı hesaplayan metodu çağırıyoruz
double alan = AlanHesapla(yariCap);
Console.WriteLine("Dairenin alanı: " + alan);


//Yarıçap bilgisiyle dairenin alanını hesaplayan metot
static double AlanHesapla(double yaricap)
{
    return Math.PI * yaricap * yaricap;
}
Console.WriteLine("-------------------------------------------------------------------------------");

//17.SORU:"Zaman bir GeRi SayIm" cümlesini alıp, hepsi büyük harf ve hepsi küçük harfle yazdırınız.

//Verilen cümleyi tanımlanır.
string cumle = "Zaman bir GeRi SayIm";

//Cümleyi büyük harfe dönüştürüp yazdıralım
Console.WriteLine(cumle.ToUpper());

//Cümleyi küçük harfe dönüştürüp yazdıralım
Console.WriteLine(cumle.ToLower());
Console.WriteLine("-------------------------------------------------------------------------------");

//18.SORU: "    Selamlar   " metnini bir değişkene atayıp, başındaki ve sonundaki boşlukları kalıcı olarak siliniz.

//Metni tanımlayalım.
string metin = "    Selamlar   ";

//Boşlukları temizleyip, sonucu aynı değişkene atayalım
metin = metin.Trim();

//Sonucu ekrana yazdıralım
Console.WriteLine(metin);
Console.WriteLine("-------------------------------------------------------------------------------");