using demoLINQ.Models;
using demoLINQ.Mocks;

namespace demoLINQ.Data;

public class BookDataAccess
{
    private List<BookModel> _books;
    private List<AnimalModel> _animals;
    
    public BookDataAccess()
    {
        var BookMock = new BookMock();
        var AnimalMock = new AnimalMock();

        _books = BookMock.GetBooks().ToList();
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