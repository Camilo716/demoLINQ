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

    public IEnumerable<BookModel> getAllBooks()
    {
        return _books;
    }
    
    private void ImportDataFromJsonFile(string fileRoute)
    {
        using(StreamReader streamReader = new StreamReader("./books.json"))
        {
            string json = streamReader.ReadToEnd();
            //System.Console.WriteLine(json);

            var opt = new JsonSerializerOptions(){PropertyNameCaseInsensitive = true};

            _books = JsonSerializer.Deserialize<List<BookModel>>(json, opt);
        }
    }
}