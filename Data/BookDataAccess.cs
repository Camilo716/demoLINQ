using demoLINQ.Models;
using demoLINQ.Stubs;

namespace demoLINQ.Data;

public class BookDataAccess
{
    private List<BookModel> _books;
    
    public BookDataAccess()
    {
        var BookStub = new BookStub();
        var AnimalStub = new AnimalStub();

        _books = BookStub.GetBooks().ToList();
    }

    public IEnumerable<BookModel> GetAllBooks()
    {
        return _books;
    }

    public IEnumerable<BookModel> GetBooksPublishedAfterYear(int year)
    {
        return _books.Where(b => b.PublishedDate.Year >= year);
    }
    
    public IEnumerable<BookModel> GetBooksByMinimumOfPages(int minimumPages, string KeyWord)
    {
        return _books.Where(b => b.PageCount > minimumPages && b.Tittle.ToLower().Contains(KeyWord.ToLower()));
    }
    
    public IEnumerable<BookModel> GetBooksByMinimumPages(int minimumPages)
    {
        return _books.Where(b => b.PageCount > minimumPages).OrderByDescending(b => b.PageCount);
    }

    public bool AllBooksHasState()
    {
        return _books.All(b => !String.IsNullOrEmpty(b.Status));
    }

    public bool AnyBookWasPublishedInYear(int year)
    {
        return _books.Any(b => b.PublishedDate.Year == year);
    }

    public IEnumerable<BookModel> GetBooksByCategory(string categoryBook)
    {
        var booksFilteredByCategory = _books.Where(b => b.Categories.Contains(categoryBook));

        var booksOrderedByTittle = booksFilteredByCategory.OrderByDescending(b => b.Tittle);
        
        return booksOrderedByTittle;
    }   

    public IEnumerable<BookModel> GetMostRecentlyBooks(int numberOfBooksToGet, string categoryBook)
    {
        var booksFilteredByCategory = _books.Where(b => b.Categories.Contains(categoryBook));

        var booksOrderedByDate = booksFilteredByCategory.OrderBy(b => b.PublishedDate);

        var mostRecentlyBooks = booksOrderedByDate.Take(numberOfBooksToGet);

        return mostRecentlyBooks;
    }

    public IEnumerable<BookModel> Get3And4BooksByMinimumOfPages(int minimumPages)
    {
        var first4Books = _books.Where(b => b.PageCount >= minimumPages).Take(4);
        
        var books3And4 = first4Books.Skip(2);

        return books3And4;
    }

    public IEnumerable<object> GetTittleAndPageCount()
    {
        var first3Books = _books.Take(3);

        var tittleAndPageCount = first3Books.Select(p => new {p.Tittle , p.PageCount});

        return tittleAndPageCount;
    }

    // Operadores de Agregación
    public long GetNumberOfBooksByPagesInRange(int minRange, int maxRange)
    {
        return _books.LongCount(b => b.PageCount>=minRange && b.PageCount<=maxRange);
    }

    public DateOnly GetOldestPublishDate()
    {
        return  DateOnly.FromDateTime(_books.Min(b => b.PublishedDate));
    }

    public int GetHighestPageCount()
    {
        return _books.Max(b => b.PageCount);
    }

    public BookModel? GetLowestPageCountBook()
    {
        return _books
            .Where(b => b.PageCount > 0)
            .MinBy(b => b.PageCount);
    }

    public BookModel? GetNewestBook()
    {
        return _books.MaxBy(b => b.PageCount);
    }
}