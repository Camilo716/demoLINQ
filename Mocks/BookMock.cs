namespace demoLINQ.Mocks;
using demoLINQ.Models;
using System.Text.Json;

public class BookMock
{
    private List<BookModel> _books = new List<BookModel>();

    public BookMock()
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