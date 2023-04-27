using demoLINQ.Models;
using System.Text.Json;

namespace demoLINQ.Querier;

public class Querier
{
    private List<BookModel> _books = new List<BookModel>();

    public Querier()
    {
        ImportDataFromJsonFile("./books.json");
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

    private void ImportDataFromJsonFile(string fileRoute)
    {
        using(StreamReader streamReader = new StreamReader("./books.json"))
        {
            string json = streamReader.ReadToEnd();

            var opt = new JsonSerializerOptions(){PropertyNameCaseInsensitive = true};

            _books = JsonSerializer.Deserialize<List<BookModel>>(json, opt);
        }
    }
}