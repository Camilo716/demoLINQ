namespace demoLINQ.Views;
using demoLINQ.Models;

public class ConsoleUI
{
    public void PrintBooks(IEnumerable<BookModel> booksList)
    {
        Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Tittle", "Pages #", "Published Date");
        foreach(var book in booksList)
        {
            Console.WriteLine("{0,-60} {1, 15} {2, 15}", book.Tittle, book.PageCount, book.PublishedDate.ToShortDateString());
        }
    }

    public void PrintBooksIGroupingInt(IEnumerable<IGrouping<int,BookModel>> booksList)
    {
        foreach(var group in booksList)
        {            
            Console.WriteLine("{0,-100}\n", GetHorizontalDivider(100));
            Console.WriteLine($"Grupo: {group.Key}");
            Console.WriteLine
            (
                "{0,-60} {1, 15}  {2, 15}\n",
                "Titulos", "N. Paginas", "Fecha publicacion"
            );

            foreach(var book in group)
            {
                Console.WriteLine
                (
                    "{0,-60} {1, 15} {2, 15}",
                    book.Tittle,book.PageCount,book.PublishedDate.Date.ToShortDateString()
                ); 
            }
        }
    }

    public void PrintAnimalsIGroupingString(IEnumerable<IGrouping<string, AnimalModel>> animalsList)
    {
        foreach (var group in animalsList)
        {
            Console.WriteLine("{0,-100}\n", GetHorizontalDivider(100));
            Console.WriteLine($"GRUPO: COLOR {group.Key.ToUpper()}\n");

            foreach (var animal in group)
            {
                System.Console.WriteLine
                (
                    "{0, -100}",
                    animal.Name
                );
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

    public void PrintBooksILookupChar(ILookup<char, BookModel> booksList, char letter)
    {
        Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
        foreach(var item in booksList[letter])
        {
                Console.WriteLine("{0,-60} {1, 15} {2, 15}",item.Tittle,item.PageCount,item.PublishedDate.Date.ToShortDateString()); 
        }
    }

    private string GetHorizontalDivider(int horizontalLenght)
    {
        string divider = "";

        for (int i = 0; i < horizontalLenght; i++)
        {
            divider += "-";
        }
        
        return divider;
    }
}