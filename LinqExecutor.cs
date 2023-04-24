using demoLINQ.Models;
using System.Text.Json;

namespace demoLINQ.Queries;

public class LinqExecutor
{
    private List<BookModel> _books = new List<BookModel>();

    public LinqExecutor()
    {
        using(StreamReader streamReader = new StreamReader("books.json"))
        {
            string json = streamReader.ReadToEnd();
            //System.Console.WriteLine(json);

            var opt = new JsonSerializerOptions(){PropertyNameCaseInsensitive = true};

            _books = JsonSerializer.Deserialize<List<BookModel>>(json, opt);
        }
    }

    public IEnumerable<BookModel> getAllBooks()
    {
        return _books;
    }
}