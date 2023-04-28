namespace demoLINQ.Stubs;
using demoLINQ.Models;
using System.Text.Json;

public class BooksStub
{
    private List<BookModel> _books = new List<BookModel>();

    public BooksStub()
    {
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

            _books = JsonSerializer.Deserialize<List<BookModel>>(json, opt);
        }
    }
}