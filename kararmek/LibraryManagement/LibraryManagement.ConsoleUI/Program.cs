// (Record) Kitap-> Id,Tittle, Description, PageSize,PublishDate,ISBN,Stok
// (Record) Author-> Id,Name, Surname, 
// (Class) Category-> Id,Name
//----------------------------
//Kitaplar Listesi oluşturunuz.
//Yazarlar Listesi oluşturunuz.
//Kategoriler Listesi oluşturunuz.
//-------------------------------------
//Yazarları ekrana bastıran kodu yazınız.
//Kitapları ekrana bastıran kodu yazınız.
//Kategorileri ekrana bastıran kodu yazınız.
//------------------------------------------
//Kitapları sayfa sayısına göre filtreleyen kodu yazınız.
//Kütüphanedeki tüm kitapların sayfa sayısı toplamını yazınız.
//Kitap başlığına göre filtreleyen işlemleri yapınız.
//Kitap ISBN numarasına göre ilgili kitabı getirinz.
//---------------------------------------------------
//Kitaplar listesine yeni bir kitap ekleyin, sonra listeyi ekran listesi olarak veriniz.(Verileri kullanıcıdan alınız.)
//Kitap eklerken ıd si veya ISBN numarası daha önceki kayıtlı kitapsa "Benzersiz bir kitap girmeniz gerekmektedir" yazısı veriniz.
//---------------------------------------------------------------------------------------------------------------------------------
//Kullanıcı ıd girince silme ve ekleme işlemi yapabilecek
//-------------------------------------------------------
//Kullanıcıdan ilk başta id değeri alıp arama yapınca eğer sistemde yoksa "İlgili id ye ait kitap bulunamadı " yazısını verecek
//Güncellenecek olan değerler kullanıcıdan alınacaktır.
//-----------------------------------------------------
//Kullanıcıdan bir kitap almasını isteyen kodu yaınız.
//Eğer o kitap stok da varsa alındı yazsın
// 1 tane varsa o kitap alınsın ve 0 olursa listeden silinsin.
//----------------------------------------------------
//***Prime Örnekler
//BookDetail adınd bir record oluşturup şu değerler listelenecek
//Kitap Id, Kitap Başlığı, Kitap Açıklaması, Kitap Sayfa Sayısı, ISBN,Yazar Adı, Kategori Adı
//--------------------------------------------------------------------------------------------
//Kullanıcıdan PageIndex ve PageSize değerleri alarak sayfalama desteği getiriniz.


using LibraryManagement.ConsoleUI;
using System.Threading.Channels;

List<Book> books = new List<Book>()
{
    new Book(1,"Germinal","Kömür Madeni",341, "2012 Myaıs","1111111111111"),
    new Book(2,"Suç ve Ceza","Raskolnikov'un Hayatı",315,"2010 Haziran","2222222222222"),
    new Book(3,"Kumarbaz","Bir Öğretmenin Hayatı",210,"2009 Ocak","3333333333333"),
    new Book(4,"Araba Sevdası","Arabayla alakası olmayan kitap",180,"1999 Ocak","4444444444444"),
    new Book(5,"Ateşten Gömlek","Kurtuluş Savaşını anlatan kitap", 120,"2001 Eylül","5555555555555"),
    new Book(6,"Kaşağı","Okunmaması gereken bir kitap",95,"1993 Ocak","666666666666"),
    new Book(7,"28 Şampiyonluk","Hayal ürünüdür",350,"1907 Ocak","777777777777"),
    new Book(8,"16 Yıl Şampiyonluk","Hayal ürünüdür",255,"1905 Eylül","88888888888888"),
    new Book(9,"Ali Arı","Uyanık CEO hikayesi", 551,"20 Haziran","999999999999")
};

List<Author>  authors= new List<Author>()
{
    new Author(1,"Emile","Zola"),
    new Author(2,"Fyodor","Dostoyevski"),
    new Author(3,"Recaizade Mahmut","Ekrem"),
    new Author(4,"Halide Edib","Adıvar"),
    new Author(5,"Ömer","Seyfettin"),
    new Author(6,"Ali","Koç"),
    new Author(7,"Vız Vız","Ali"),
  
   

};

List<Category> categories = new List<Category>()
{
    new Category(1,"Dünya Klasikleri"),
    new Category(2,"Türk Klasikleri"),
    new Category(3,"Bilim Kurgu"),
   

};

Console.WriteLine();
Console.WriteLine("Kitaplar Listesi");
Console.WriteLine();
foreach (var item in books)
{
    Console.WriteLine(item);
    Console.WriteLine();
};
Console.WriteLine("Yazarlar Listesi ");
Console.WriteLine();
foreach (var item in authors)
{
    Console.WriteLine(item);
};
Console.WriteLine("Kategoriler Listesi ");
Console.WriteLine();
foreach (var item in categories)
{
    Console.WriteLine(item);
};

GetAllBooks();
GetAllCategories();
GetAllAuthors();
//GetAllBooksByPageSize();
PageSizeTotalCalculator();
//GetAllBooksByTittleFilter();
//GetBookByISBN();
GetAllBooks();
//AddBook();
//Add();
//AddCategory();
AddAuthor();

void GetAllBooks()
{
    PrintAyirac("Kitapları listele:");

    foreach (var item in books)
    {
        Console.WriteLine(item);
        Console.WriteLine();
    };
}
void GetAllCategories()
{

    PrintAyirac("Kategorileri listele:");

    foreach (var item in categories)
    {
        Console.WriteLine(item);
    };
}
void GetAllAuthors()
{
    PrintAyirac("Yazarları listele:");
    
    foreach (var item in authors)
    {
        Console.WriteLine(item);
    };
}
void PrintAyirac(string metin)
{
    Console.WriteLine(metin);
    Console.WriteLine("--------------------------------");
}
void GetAllBooksByPageSize()
{
    PrintAyirac("Sayfa Sayısına göre filtreleme");

    Console.WriteLine("Lütfen minimum değeri giriniz: ");
    int min=Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen maximum değeri giriniz: ");
    int max = Convert.ToInt32(Console.ReadLine());

    foreach (Book book in books)
    {
        if (book.PageSize <=max && book.PageSize>=min)
        {
            Console.WriteLine(book);
        }
    }

}
void PageSizeTotalCalculator()
{
    PrintAyirac("Toplam Sayfa Sayısı");
    Console.WriteLine(books.Sum(x => x.PageSize));
    Console.WriteLine();
}
void GetAllBooksByTittleFilter()
{
    Console.WriteLine("Kitap Başlığını giriniz:");
    string text= Console.ReadLine();

    foreach(Book book in books)

    {
        if (book.Title.Contains(text,StringComparison.CurrentCultureIgnoreCase))
        {
            Console.WriteLine(book);
        }
    }
}
void GetBookByISBN()
{
    Console.WriteLine("Lütfen ISBN numarasını giriniz:");
    string isbn = Console.ReadLine();

    foreach(Book book in books)

    {
        if (book.ISBN == isbn)
        {
            Console.WriteLine(book);
        }
    }
}
void Add(Book book)

{
    PrintAyirac("Kitap Ekleme: ");
    Console.WriteLine("Lütfen kitap id sini giriniz: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen kitap başlığını giriniz: ");
    string title = Console.ReadLine();

    Console.WriteLine("Lütfen kitap Açıklamasını giriniz: ");
    string description = Console.ReadLine();

    Console.WriteLine("Lütfen kitap sayfasını giriniz: ");
    int pageSize = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen kitap Yayımlanma Tarihini giriniz: ");
    string publishDate = Console.ReadLine();

    Console.WriteLine("Lütfen kitap ISBN numarasını giriniz: ");
    string isbn = Console.ReadLine();


    //Book book = new Book(id, title, description, pageSize, publishDate, isbn);

    bool isUnique = true;

    foreach (Book item in books)
    {
        if (item.Id==id || item.ISBN==isbn )
        {
            isUnique = false;
            break;
        }
    }

    if (!isUnique)
    {
        Console.WriteLine("Girmiş olduğunuz kitap benzersiz değildir.");
    }

    books.Add(book);

    foreach(Book item in books)
    {
        Console.WriteLine(item);
    }
}
Book GetBookInputs2()
{
    Console.WriteLine("Lütfen kitap id sini giriniz: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen kitap başlığını giriniz: ");
    string title = Console.ReadLine();

    Console.WriteLine("Lütfen kitap Açıklamasını giriniz: ");
    string description = Console.ReadLine();

    Console.WriteLine("Lütfen kitap sayfasını giriniz: ");
    int pageSize = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen kitap Yayımlanma Tarihini giriniz: ");
    string publishDate = Console.ReadLine();

    Console.WriteLine("Lütfen kitap ISBN numarasını giriniz: ");
    string isbn = Console.ReadLine();

    Book book = new Book(id, title, description, pageSize, publishDate, isbn);
    return book;
}
bool AddBookValidator(Book book)
{
    bool isUnique = true;

    foreach (Book item in books)
    {
        if (item.Id == book.Id || item.ISBN == book.ISBN)
        {
            isUnique = false;
            break;
        }
    }

    return isUnique;
}
void AddBook()
{
   
    Book book = GetBookInputs2();

    bool isUnique = AddBookValidator(book);

    if (!isUnique)
    {
        Console.WriteLine("Girmiş olduğunuz kitap Benzersiz değil.");
        return;
    }
    books.Add(book);
   
}

void AddCategory()
{

    Category category = GetCategoryInputs();

    bool isUnique = AddCategoryValidator(category);

    if (!isUnique)
    {
        Console.WriteLine("Girmiş olduğunuz Kategori Benzersiz değil.");
        return;
    }
    categories.Add(category);
   
    GetAllCategories();

}


bool AddCategoryValidator(Category category)
{
    bool isUnique = true;

    foreach (Category item in categories)
    {
        if (item.Id == category.Id || item.Name== category.Name)
        {
            isUnique = false;
            break;
        }
    }

    return isUnique;
}


 Category GetCategoryInputs()
{
    Console.WriteLine("Lütfen kategori id giriniz: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen kategori adı giriniz: ");
    string name = Console.ReadLine();


    Category category = new Category(id, name);
    return category;
}

void AddAuthor()
{

    Author author = GetAuthorInputs();

    bool isUnique = AddAuthorValidator(author);

    if (!isUnique)
    {
        Console.WriteLine("Girmiş olduğunuz Yazar Benzersiz değil.");
        return;
    }
    authors.Add(author);

    GetAllAuthors();

}


bool AddAuthorValidator(Author author)
{
    bool isUnique = true;

    foreach (Author item in authors)
    {
        if (item.Id == author.Id  )
        {
            isUnique = false;
            break;
        }
    }

    foreach (Author item in authors)
    {
        if (item.Name == author.Name && item.Surname == author.Surname)
        {
            isUnique = false;
            break;
        }
    }

    return isUnique;
}


Author GetAuthorInputs()
{
    Console.WriteLine("Lütfen yazar id giriniz: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen yazar adı giriniz: ");
    string name = Console.ReadLine();

    Console.WriteLine("Lütfen yazar soyadı giriniz: ");
    string surnname = Console.ReadLine();

    Author author = new Author(id, name,surnname);
    return author;
}

