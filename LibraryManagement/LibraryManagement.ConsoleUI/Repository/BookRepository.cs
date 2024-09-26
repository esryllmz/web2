

using LibraryManagement.ConsoleUI.Models;
using LibraryManagement.ConsoleUI.Models.Dtos;
using System.Linq;
using System.Security.Cryptography;

namespace LibraryManagement.ConsoleUI.Repository;

public class BookRepository:BaseRepository
{
    private List<Book> books;

    private List<Author> authors;

    private List<Category> categories;
    public BookRepository()
    {
        books = Books();
        categories = Categories;
        authors = Authors;
        
    }



    public List<Book> GetAll()
    {
        return books;

    }

    public List<Book> GetAllBooksByPageSize(int min, int max)
    {
        //Geleneksel Yöntem
        //List<Book> filteredBooks= new List<Book>();

        //foreach (Book book in books)
        //{
        //    if (book.PageSize <= max && book.PageSize >= min)
        //    {
        //        filteredBooks.Add(book);
        //    }
        //}

        //return filteredBooks;


        //LINQ Geleneksel
        //List<Book> result = (from b in books
        //                    where b.PageSize <= max && b.PageSize <= min
        //                    select b).ToList();
        //return result;


        List<Book> result = books.Where(b => b.PageSize <= max && b.PageSize <= min).ToList();
        return result;


    }

    public double PageSizeTotalCalculator()
    {
        double total = books.Sum(book => book.PageSize);
        return total;


    }

    public List<Book> GetAllBooksTittleContains(string text)

    {
        //List<Book> filteredBooks = new List<Book>();

        //foreach (Book book in books)
        //{

        //    if(book.Title.Contains(text,StringComparison.InvariantCultureIgnoreCase))
        //    {
        //        filteredBooks.Add(book);
        //    }


        //}

        //return filteredBooks;


        List<Book> result = books.Where(b => b.Title.Contains(text, StringComparison.InvariantCultureIgnoreCase)).ToList();
        return result;

    }

    public Book? GetBookByISBNFilter(string isbn)

    {

        Book book1 = null;

        foreach (Book item in books)
        {
            if (item.ISBN == isbn)
            {
                book1 = item;

            }

        }
        //if (book1 == null)

        //{
        //    return null;
        //}

        //return book1;

        return book1 is null ? null : book1;



        //Book book= (from b in books where b.ISBN Isbn==isbn select b).FirstorDefault();
        //return book;
    }

    public Book Add(Book created)
    {
        books.Add(created);
        return created;
    }

    public Book? GetById(int id)
    {
        Book? book1 = null;

        foreach (Book book in books)
        {
            if (book.Id == id)
            {
                book1 = book;
            }
        }

        if (book1 == null)

        {
            return null;
        }

        return book1;

    }

    public Book? Remove(int id)

    {

        Book? deletedBook = GetById(id);

        if (deletedBook is null)
        {
            return null;

        }

        return deletedBook;
    }

    public List<Book> GetAllOrderByTittle()
    {
        List<Book> orderedBooks = books.OrderBy(x=>x.Title).ToList();
        return orderedBooks;
    }

    public List<Book> GetAllOrderByDesceningTittle()
    {
        List<Book> orderedBooks = books.OrderByDescending(x => x.Title).ToList();

        return orderedBooks;
    }

    public List<Book> GetBookMaxPageSize()
    {
        List<Book> maxBooks = books.OrderByDescending(x => x.PageSize).ToList();
        //List<Book> maxBooks = books.OrderBy(x => x.PageSize).LastOrDefault();
        return maxBooks;

    }

    public List<Book> GetBookMinPageSize()
    {
        List<Book> minBooks = books.OrderBy(x => x.PageSize).ToList();
        //List<Book> maxBooks = books.OrderByDescending(x => x.PageSize).LastOrDefault();
        return minBooks;
    }

    //public List<BookDetailDto> GetDetails()
    //{
    //    var result =
    //        from b in books
    //        join c in categories
    //        on b.CategoryId equals c.Id
    //        select new BookDetailDto(
    //            Id: b.Id,
    //            CategoryName: c.Name,
    //            "",
    //            Title: b.Title,
    //            Description: b.Description,
    //            PageSize: b.PageSize,
    //            PublishDate: b.PublishDate,
    //            ISBN: b.ISBN
    //            );

    //    return result.ToList();
    //}

    //public List<BookDetailDto> GetDetailsV2()
    //{
    //    List<BookDetailDto> details =
    //        books.Join(categories,

    //        b => b.CategoryId,
    //        c => c.Id,
    //        (book, category) => new BookDetailDto(
    //            Id: book.Id,
    //            CategoryName: category.Name,
    //            "",
    //            Title: book.Title,
    //            Description: book.Description,
    //            PageSize: book.PageSize,
    //            PublishDate: book.PublishDate,
    //            ISBN: book.ISBN
    //            )
    //        ).ToList();

    //    return details;
    //}

    //public List<BookDetailDto> GetAllAuthorAndBookDetails()
    //{
    //    var result =
    //        from b in books
    //        join c in categories on b.CategoryId equals c.Id
    //        join a in authors on b.AuthorId equals a.Id

    //        select new BookDetailDto(
    //            Id: b.Id,
    //            Title: b.Title,
    //            CategoryName: c.Name,
    //            AuthorName: $"{a.Name} {a.Surname}",
    //            Description: b.Description,
    //            PageSize: b.PageSize,
    //            PublishDate: b.PublishDate,
    //            ISBN: b.ISBN
    //            );

    //    return result.ToList();
    //}

    public List<BookDetailDto> GetAllDetailsByCategorId(int categoryId)
    {

        var result =
            from b in books
            where b.CategoryId == categoryId
            join c in categories on b.CategoryId equals c.Id
            join a in authors on b.AuthorId equals a.Id
           
            

        select new BookDetailDto(
                Id: b.Id,
                Title: b.Title,
                CategoryName:c.Name,
                AuthorName: $"{a.Name} {a.Surname}",
                Description: b.Description,
                PageSize: b.PageSize,
                PublishDate: b.PublishDate,
                ISBN: b.ISBN
                );

        return result.ToList();

    }




}



   
