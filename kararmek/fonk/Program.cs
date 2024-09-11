
using System;
using System.Reflection;

//Info();

//Info2("esra");

//Info3("Berk","Aydın",25);

//Info3(age: 26, surname: "Gören", name: "Sena");
////değer döndürmeyen parametresiz metodlar
////ekran çıktısı olarak benim adım büşra

//void Info()
//{
//    Console.WriteLine("benim adım büşra");
//}

//void Info2(string name)
//{
//    Console.WriteLine($"benim adım {name}");

//}

//void Info3(string name,string surname,int age)
//{
//    Console.WriteLine($"adım: {name}, soyadım: {surname}, yaşım: {age}");

//}

////MeyveYazdir(string meyveAdi,double fiyat, double kg);



//MeyveYazdir("Elma", 25, 1);
//MeyveYazdir("Armut", 20, 2);

//void MeyveYazdir(string meyveAdi, double fiyat, double kg)
//{
//    Console.WriteLine($"meyve: {meyveAdi}, fiyat: {fiyat}, miktar: {kg}");

//}

//değer döndüren metodlar

//Console.WriteLine(toplam);

//int toplam = Topla(25,36);
//int Topla(int sayi1, int sayi2) {

//    return sayi1+sayi2;
//}

// 2 sayının çarpımını ekran çıktısı olarak veren kodu yaz

//Result(25, 2);
//void Result(int sayi1,int sayi2)
//{
//    int carpim = Carpim(sayi1, sayi2);
//    EkranaYazdir(sayi1, sayi2, carpim);

//}


//void EkranaYazdir(int sayi1, int sayi2, int carpim)

//{
//    Console.WriteLine($"{sayi1} * {sayi2} = {carpim}");

//}

//int Carpim(int num1, int num2)
//{
//    return num1 * num2;

//}


// kullanıcıdan 3 tane sınav notu al
// 1. sınav, 2. sınav,3. sınav, Not Ortalamanız

//NotYazdir(sinav1,sinav2,sinav3)

//NotYazdir(sinav1,sinav2,sinav3) ->
// double ortalama= OrtalamaHesapla(sinav1,sinav2,sinav3);
// EkranaYazdir(sinav1,sinav2,sinav3)



//Console.WriteLine("1. sınav notunuz: ");
//int sinav1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("2. sınav notunuz: ");
//int sinav2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("3. sınav notunuz: ");
//int sinav3 = Convert.ToInt32(Console.ReadLine());


//NotYazdir(sinav1, sinav2, sinav3);

//void NotYazdir(int sinav1, int sinav2, int sinav3)
//{
//    double ortalama= ortalamaHesapla (sinav1,sinav2,sinav3);
//    EkranaYazdir(sinav1, sinav2, sinav3,ortalama);

//}


//void EkranaYazdir(int sinav1, int sinav2, int sinav3, double ortalama)

//{

//    Console.WriteLine($"1.Sınav:{sinav1}");
//    Console.WriteLine($"2.Sınav:{sinav2}");
//    Console.WriteLine($"3.Sınav:{sinav3}");

//    Console.WriteLine($"Not Ortalamanız: {sinav1} + {sinav2} + {sinav3} = {ortalama}");

//}

//double ortalamaHesapla (int num1, int num2, int num3)
//{
//    return (num1 + num2 + num3 ) /3;

//}


//Console.WriteLine(Faktoriyel(5));
//Console.WriteLine(Permutasyon(22,5));
//Console.WriteLine(Kombinasyon(22,5));
//Console.WriteLine(Topla(5,5,5,5,5,5,5));
//int Faktoriyel(int n)

//{
//   int total = 1;
//   for (int i = 1; i <= n; i++)
//    {
//        total = total * i;
//    }
//   return total;
//}

//int Permutasyon(int n,int r)
//{
//    return Faktoriyel(n) / Faktoriyel(n - r);
//}

//int Kombinasyon(int n,int r)
//{
//    return Permutasyon(n,r) * Faktoriyel(r);

//}

//int Topla(params int [] sayilar)
//{
//    int toplam = 0;
//    foreach (var sayi in sayilar)
//    {
//        toplam= toplam + sayi;
//    }

//    return toplam;  
//}
//int bolum;
//int kalan;

//Bolme(10, 3, out bolum,out kalan);
//void Bolme(int bolunen,int bolen, out int bolum,out int kalan)
//{
//    bolum = bolunen / bolen;
//    kalan = bolunen % bolen;
//}

//Console.WriteLine("10 / 3 = "+bolum);
//Console.WriteLine("10 / 3 = " + kalan);


//"MeRhAbAlAr"->merhabalar, MERHABALAR
string metin = "MeRhAbAlAr";
string kucukharf;
string buyukharf;


void Cevir( string metin ,out string kucukharf, out string buyukharf)
{
   
    kucukharf = metin.ToLower();
    buyukharf = metin.ToUpper();

}
Cevir(metin,out buyukharf, out kucukharf);

Console.WriteLine(metin);
Console.WriteLine(kucukharf);
Console.WriteLine(buyukharf); 

