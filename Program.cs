using demoLINQ.Querier;

var linqQuerier = new Querier();

var books = linqQuerier.getAllBooks();

foreach (var book in books)
{
    Console.WriteLine(book.Tittle);
    Console.WriteLine("-----");
}