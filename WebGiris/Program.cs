

//2.GÜN
// yoruma alma  ::ctrl + k ardınfan ctrl+c   yorumu kladırma :: ctrl+k ardından ctrl+u

//string name = "Figen ";
//string soyad = "Aycil";

//Console.WriteLine(name);

//integer: tam sayılar için kullanılan veri tipidir.   
//int sayi1 = 10;
//int sayi2 = 20;
//Console.WriteLine(sayi1 + sayi2); //or
//int toplam = sayi1 + sayi2;
//Console.WriteLine(toplam);
  
//adlandırma sayı ve özel karakter ile başlanamaz. "_" kullanılabilir.değişkenin başında kullanırken bu private değişken olarak atanır.
//Constructor da dışarıdan değişken çağırınca da kullanılır.
//string tamAd = name + soyad;
//Console.WriteLine(tamAd);

//10 ile 20 sayısının toplamı 30 dur ekran çıktısı verme
//Console.WriteLine(sayi1 + " ile " + sayi2 + " sayısının toplamı " + toplam);

//string interpolation(dolar işareti ile sayıları metinsel ifade içinde sayı olarak görünmesini sağlar.
//Console.WriteLine($"{sayi1} ile {sayi2} sayısının toplamı {toplam} ");

//Console.WriteLine("iki sayının toplamı : " + (sayi1 + sayi2));

//int difference = sayi2 - sayi2;
//int multiply = sayi1 * sayi2;
//int divide = sayi1 / sayi2;
//Console.WriteLine($"{sayi1}- {sayi2}= {difference}");  // or Console.WriteLine($"{sayi1}- {sayi2}= {sayi1 +sayi2}")
//Console.WriteLine($"{sayi1}+ {sayi2}= {toplam}");
//Console.WriteLine($"{sayi1}* {sayi2} = {multiply}");
//Console.WriteLine($"{sayi1}/ {sayi2}= {divide}");

//get data from console
//Console.WriteLine("lütfen birinci sayıyı giriniz: ");
//int sayi1 = Convert.ToInt32(Console.ReadLine);

//KULLANICIDANad soyad ve yaşını al.Bilgileiri string interpolation yöntemi ile yazdır.

//Console.WriteLine("lütfen ADINIZI giriniz: ");
//string ad = Convert.ToString(Console.ReadLine()); //or string ad= Console.ReadLine());

//Console.WriteLine("lütfen soyadınızı giriniz: ");
//string soyad = Convert.ToString(Console.ReadLine());

//Console.WriteLine("lütfen yaşınızı giriniz: ");
//int yas = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(ad + soyad + $" {yas}");
//Console.WriteLine($" Adım {ad} soyadım {soyad} . Yaşım {yas} ");

//double : ondalıklı sayıları tutan veri tipidir.
//double number1 = 25.32;
//double number2 = 10.225;
//Console.WriteLine(number1 / number2);

//decimal veri tipi  daha hassas işlemler için kullanılır.

//float : ondalıklı sayılar için kullanılır.hassasiyeti double a daha azdır.
//float number3 =10.4f;
//Console.WriteLine(number3);

//diğer veri tiplerini kendin araştır.
//bool (doğruluk) ::  true ve ya false değerler alır.
//bool dogru = true;
//Console.WriteLine(dogru);
//bool yanlis = false;
//Console.WriteLine(yanlis);

//Karşılaştırma Oparatörleri(<, >, =, !=,<=,>= ), çıktısı boolean olmalıdır.
// < :: küçük
// > :: büyük
// <= :: küçük eşittir
// >= :: büyük eşittir
// == :: eşit midir?
// != :: eşit değil midir

//Console.WriteLine(3<5); (4 >= 6);
//Console.WriteLine(3 != 3);
//Console.WriteLine(3 == 4);
//Console.WriteLine(4 <= 4);
//Console.WriteLine(5 >= 5);
//Console.WriteLine(5 < 9);
//Console.WriteLine(6 > 6);
//Console.WriteLine(3 < 3);

//// Mantıksal oparatörler : (&&) -> ve  (||) -> veya
//Console.WriteLine((3<5 || 5!=6)&& 3!=0);
////                      true  and true ::true
////var keyword  herhangi bir değer alır string int boolean  farketmiyor.
//var deneme = ((3 < 5 || 5 != 6) && 3 != 0);
////değişkenin tipini öğrenme
//Console.WriteLine(deneme.GetType());

////Ternary operatör : koşul bırakarak işlem yapma

////kulanıcıdan yaş değişkenini alıp yaş>=18 ise ehliyet alabilir yazısı çıksın aksi takdirde  ehliyet alamsın desin.
//Console.WriteLine("yaşınızı giriniz :");
//int age = Convert.ToInt32(Console.ReadLine());

//string ehliyet = age >= 18 ? "Ehliyet alabilir." : "Ehliyet alamaz";
//Console.WriteLine(ehliyet);


////kullanıcıdan sayı değeri al.eğer sayı 10'dan >= ise ekram çıktısı olarak sayı "sayı 10 dan büyük eşittir yazdır." aksi durumda sayı küçüktür yazdır.

//Console.WriteLine("sayı  giriniz :");
//int number = Convert.ToInt32(Console.ReadLine());

//string ehliyet = number >= 10 ? "Sayı 10'dan büyüktür veya  eşittr." : "Sayı 10'dan küçüktür.";
//Console.WriteLine(ehliyet);

// Karar Mekanizmaları : (if-else)

//if - else
//kulanıcıdan yaş değişkenini alıp yaş>=18 ise ehliyet alabilir yazısı çıksın aksi takdirde  ehliyet alamsın desin.

//Console.WriteLine("yaşınızı giriniz :");
//int age = Convert.ToInt32(Console.ReadLine());

//if (age>=18)
//{
//    Console.WriteLine("ehliyet alabilir ");
//}else
//{
//    Console.WriteLine("ehliyet alamaz");
//}

// debuglama yöntemi

//kullanıcı adı: admin
//parola : 12345
//konsoldan kullanıcıdan kullanıcı adı ve parola alalım. pAROLA HATALIYSA PAROLA HATALIDIR. KULLANICI ADI HATAYLISA KULLANICI ADI HATALIDIR.. AKSŞİ DURUMDA GİRİŞ BAŞARILI BİR ŞEKİLDE EKRAN ÇIKTISI VERİLSİN.

//string username = "admin";
//string password = "12345";

//Console.WriteLine("lütfen kullanıcı adınızı giriniz : ");
//string inputUsername = Console.ReadLine();

//Console.WriteLine("parolanızı giriniz");
//string inputPassword = Console.ReadLine();

//if(inputUsername!=username && inputPassword != password)
//{
//    Console.WriteLine("Kullanıcı adı veya parola hatalıdır.");
//}

//else
//{
//    Console.WriteLine("Giriş başarılıdır.");
//}


//kullanıcıdan bir puan al ve puanaı hangiharflendirmeye denk geldiğini gösteren if else bloğunu ytaz.
// 50< d 60< c 70<b


Console.WriteLine("lütfen puanını gir:");
int puan =Convert.ToInt32(Console.ReadLine());
if (puan < 50)
{
    Console.WriteLine("kaldınız");
    return;
}
else if (puan > 50)
{
    Console.WriteLine("d");
}
else if (puan > 60 || puan<70)
{
    Console.WriteLine("c");
}
else if ( puan>=70 ||puan <80)
{
    Console.WriteLine("b"); 
}else if (puan >=80 || puan <90)
{
    Console.WriteLine("a");
}
else if (puan >= 90 ||puan <100)
{
    Console.WriteLine("a+");
}
else if (puan==100)
{
    Console.WriteLine("s");
}
else
{
    Console.WriteLine("1 ile 100 arasında değer giriniz: ");
}
