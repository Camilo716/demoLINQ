using demoLINQ.Models;
using demoLINQ.Stubs;

using System.Text.Json;

namespace demoLINQ.Querier;

public class Querier
{
    private List<BookModel> _books;
    
    public Querier()
    {
        var booksStub = new BooksStub();

        _books = booksStub.GetBooks().ToList();
    }

    public IEnumerable<BookModel> GetAllBooks()
    {
        return _books;
    }

    public IEnumerable<BookModel> GetBooksPublishedAfterYear(int year)
    {
        return _books.Where(b => b.PublishedDate.Year >= year);
    }
    
    public IEnumerable<BookModel> GetBooksWithMoreThan200pagesAndContainsInAction()
    {
        return _books.Where(b => b.PageCount > 200 && b.Tittle.ToLower().Contains("in action"));
    }
}