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

    public void PrintBooksIGroupingInt(IEnumerable<IGrouping<int,BookModel>> ListadeLibros)
    {
        foreach(var grupo in ListadeLibros)
        {
            Console.WriteLine("");
            Console.WriteLine($"Grupo: { grupo.Key }");
            Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
            foreach(var item in grupo)
            {
                Console.WriteLine("{0,-60} {1, 15} {2, 15}",item.Tittle,item.PageCount,item.PublishedDate.Date.ToShortDateString()); 
            }
        }
    }

    public void PrintAnimals(IEnumerable<AnimalModel> animalsList)
    {
        Console.WriteLine("{0,-30} {1, 15}\n", "Name", "Color");

        foreach(var animal in animalsList)
        {
            Console.WriteLine("{0,-30} {1, 15}", animal.Name, animal.Color);
        }
    }
}