using demoLINQ.Data;
using demoLINQ.Models;

var linqQuerier = new BookDataAccess();

var AllBooks = linqQuerier.GetAllBooks();
var BooksAfter2000 = linqQuerier.GetBooksPublishedAfterYear(2000);
var InActionsMore200Pages = linqQuerier.GetBooksWithMoreThan200pagesAndContainsInAction();

PrintValues(AllBooks);

void PrintValues(IEnumerable<BookModel> booksList)
{
    Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Tittle", "Pages #", "Published Date");
    foreach(var item in booksList)
    {
        Console.WriteLine("{0,-60} {1, 15} {2, 15}", item.Tittle, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}