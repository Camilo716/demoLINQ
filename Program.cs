using demoLINQ.Queries;

var linqExecutor = new LinqExecutor();

var books = linqExecutor.getAllBooks();

foreach (var book in books)
{
    Console.WriteLine(book.Tittle);
    Console.WriteLine("-----");
}