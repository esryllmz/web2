

//int a = 10;
//int b = 20;
//static void Değistir(ref int a,ref int b)
//{
//    int c = a;
//    a = b;
//    b = c;
//}

//Değistir(ref a, ref b);

//Console.WriteLine(a);
//Console.WriteLine(b); 


//using System.Threading.Channels;



//DegerTurluOgrenci degerTurluOgrenci1=new DegerTurluOgrenci();

//degerTurluOgrenci1.Bastir(degerTurluOgrenci1);

//ReferansTurluOgrenci referansTurluOgrenci1=new ReferansTurluOgrenci();

//referansTurluOgrenci1.Bastir(referansTurluOgrenci1);


//struct DegerTurluOgrenci
//{

//    public string Isim { get; set; }

//    public void Bastir(DegerTurluOgrenci degerTurluOgrenci)

//    {
//        Console.WriteLine(degerTurluOgrenci.Isim);
//    }

//}

//class ReferansTurluOgrenci
//{
//    public string Isim { get; set; }

//    internal void Bastir(ReferansTurluOgrenci referansTurluOgrenci)
//    {
//        Console.WriteLine(referansTurluOgrenci.Isim);
//    }
//}


//strong referans


//MyClass obj= new MyClass();

//obj = null;
//Console.WriteLine("Gc çalışıor");
//GC.Collect();
//GC.WaitForPendingFinalizers();
//Console.WriteLine(obj);
//class MyClass
//{
//    public MyClass()
//    {
//        Console.WriteLine("Nesne oluşturuldu");
//    }
//}

//Console.WriteLine("Sayı giriniz:");
//int sayi=Convert.ToInt32(Console.ReadLine());
//int fakt= 1;


//        for (int i = 1; i <= sayi; i++)
//        {
//            fakt = i *fakt;

//        }



//Console.WriteLine(fakt);

//Console.WriteLine("Sayı giriniz:");
//int sayi = Convert.ToInt32(Console.ReadLine());
//bool asal = false;

//for (int i = 2; i < sayi; i++)
//{
//    if (sayi%i == 0)
//    {
//        asal = true;
//    }

//}

//if (asal==true)
//{
//    Console.WriteLine("Asal değil");
//}
//else
//{
//    Console.WriteLine("Asal");
//}

//Console.WriteLine("Sayı giriniz:");
//int sayi = Convert.ToInt32(Console.ReadLine());
//int basamak = 0;

//while (sayi > 0)
//{
//	basamak++;
//	sayi /= 10;
//}


//Console.WriteLine(basamak);


using System.Runtime.CompilerServices;

Random rnd = new Random();
int random = rnd.Next(0, 100);

while (true)
{
	
	Console.WriteLine("Sayı giriniz:");
	int tahmin = Convert.ToInt32(Console.ReadLine());


	if (tahmin<random)

	{ 
		Console.WriteLine("Sayı arttır");
	}
	else if (tahmin > random)
	{
		Console.WriteLine("Sayı azalt");
	}
	else
	{

        Console.WriteLine("Tebrikler");
		break;
    }
	


}




