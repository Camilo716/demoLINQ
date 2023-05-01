using demoLINQ.Models;
using System.Text.Json;

namespace demoLINQ.Stubs;

public class BookStub
{
    private List<BookModel> _books;

    public BookStub()
    {
        _books = new List<BookModel>();
        ImportDataFromJsonFile("./books.json");
    }

    public IEnumerable<BookModel> GetBooks()
    {
        return _books;
    }

    private void ImportDataFromJsonFile(string fileRoute)
    {
        using(StreamReader streamReader = new StreamReader("./books.json"))
        {
            string json = streamReader.ReadToEnd();

            var opt = new JsonSerializerOptions(){PropertyNameCaseInsensitive = true};

            _books = JsonSerializer.Deserialize<List<BookModel>>(json, opt) ?? new List<BookModel>();
;
        }
    }
}