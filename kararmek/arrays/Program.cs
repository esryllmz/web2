

////string[] sehirler = { "Malatya", "Adana", "İstanbul", "Aydın", "İstanbul" };

////for (int i = 0;i < sehirler.Length; i++)
////{
////    Console.WriteLine(sehirler[i]);

////}
////foreach (string sehir in sehirler) 

////{
////    Console.WriteLine(sehir);
////}

////Console.WriteLine($"şehirler diisi kaç elemanlıdır: {sehirler.Length}");

//int[] sayilar = {20,1,2,6,8,9,4,22,0,-5,-55,-14,14 };


////Array.Sort(sayilar);
////Array.Reverse(sayilar); 


////foreach (var say in sayilar)
////{
////    Console.WriteLine(say);
////}


////sayılar dzisinde 4 ten büyük olan sayıları ekrana yazıdıran kod

//foreach (int x in sayilar)
//{
//    if (x >4)
//    {
//        Console.WriteLine(x);
//    }
//}

//Console.WriteLine("2.yöntem Lambda Expression");

//int[] filteredNumbers = Array.FindAll(sayilar,x=> x>4);

//Array.ForEach(filteredNumbers,x=> Console.WriteLine(x) );


//Console.WriteLine("3.Yöntem");

//Array.ForEach(sayilar,x=>
//{
//    if (x > 4) 
//    { 
//        Console.WriteLine(x);
//    }

//});

//// ülkeler dizisi oluştur. {"Almanya","Uganda","Zimbabwe","İngiltere"}
//// dizinin içerisinde A veya a harfi geçenleri listele

//string[] ülkeler = { "Almanya", "Uganda", "Zimbabwe", "İngiltere" ,"Polonya","Arnavutluk","Türkiye"};

//Array.ForEach(ülkeler, x =>
//{
//    //if (x.Contains("A") || x.Contains("a"))
//    //{
//    //    Console.WriteLine(x);
//    //}


//    if (x.Contains("a",StringComparison.InvariantCultureIgnoreCase)
//    {
//        Console.WriteLine(x);
//    }
//});


////{10,36,45,12,54,88,55,1,3,7,9}

////1.görev: bütün elemanları toplayan kodu yazınız.
////2.görev: bu dizinin aritmetik ortalamasını hesaplayınız.
////3.görev: bu dizide en büyük elemanı bulan kodu yazınız.
////4.görev: bu dizide en küçük elemanı bulan kodu yazınız.


int[] sayilar = { 10, 36, 45, 12, 54, 88, 55, 1, 3, 7, 9 };

int toplam = 0;

foreach (int i in sayilar)
{
    toplam = toplam +i;
    
}
Console.WriteLine($"Dizinin elemanları toplamı: {toplam}");

int arit = toplam / sayilar.Length;

Console.WriteLine($"Dizinin aritmetik ortalaması: {arit}");


int enBuyuk = sayilar[0];

for (int i = 0; i < sayilar.Length; i++)
{

    if (sayilar[i]>enBuyuk) {


        enBuyuk = sayilar[i];
    }
    
} ;
Console.WriteLine($"Dizideki en büyük sayı: {enBuyuk}");

int enKucuk = 0;

for (int i = 0; i < sayilar.Length; i++)
{

    if (sayilar[i] < enKucuk)
    {


        enKucuk = sayilar[i];
    }

};
Console.WriteLine($"Dizideki en büyük sayı: {enKucuk}");