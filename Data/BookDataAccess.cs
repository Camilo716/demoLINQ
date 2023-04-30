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
    
    public IEnumerable<BookModel> GetBooksByMinimuPagesAndKeyWord(int minimumPages, string KeyWord)
    {
        return _books.Where(b => b.PageCount > minimumPages && b.Tittle.ToLower().Contains(KeyWord.ToLower()));
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
        return _books.Where(b => b.Categories.Contains(categoryBook)).OrderBy(b => b.Tittle); 
    }

}