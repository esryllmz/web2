int telefonFiyat = 50000;
int bilgisayarFiyat=10000;
int klavyeFiyat = 1500;

Console.WriteLine("Kaç adet bilgisayar almak isiyorsunuz");
int bilgisayarAdet= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Kaç adet telefon almak isiyorsunuz");
int telefonAdet = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Kaç adet klavye almak isiyorsunuz");
int klavyeAdet = Convert.ToInt32(Console.ReadLine());


int toplamTelTutar = telefonFiyat * telefonAdet;
int toplamKlavyeTutar = klavyeFiyat * klavyeAdet;
int toplamBilgisayarTutar = bilgisayarFiyat * bilgisayarAdet;


int total = toplamTelTutar + toplamKlavyeTutar + toplamBilgisayarTutar;

if (total<20000)
{
    Console.WriteLine($"Toplam Ücret : {total}");

}
else if (total>= 20000 && total<30000)
{
    double indirimli = total - (total * 0.2);
    Console.WriteLine($"İndirimsiz ücret : {total}");
    Console.WriteLine($"İndirimli ücret : {indirimli}");
    Console.WriteLine($"Aradaki fark : {total - indirimli}");
    Console.WriteLine($"İndirim oranı: %20");
}
else if (total >= 30000 && total < 35000)
{
    double indirimli = total - (total * 0.3);
    Console.WriteLine($"İndirimsiz ücret : {total}");
    Console.WriteLine($"İndirimli ücret : {indirimli}");
    Console.WriteLine($"Aradaki fark : {total - indirimli}");
    Console.WriteLine($"İndirim oranı: %30");
}
else
{
    Console.WriteLine("Bakiye yetersiz!!!!");
}

