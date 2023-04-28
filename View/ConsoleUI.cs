namespace demoLINQ.Views;
using demoLINQ.Models;

public class ConsoleUI
{
    public void PrintBooks(IEnumerable<BookModel> booksList)
    {
        Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Tittle", "Pages #", "Published Date");
        foreach(var item in booksList)
        {
            Console.WriteLine("{0,-60} {1, 15} {2, 15}", item.Tittle, item.PageCount, item.PublishedDate.ToShortDateString());
        }
    }
}