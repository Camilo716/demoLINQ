using demoLINQ.Data;
using demoLINQ.Views;

var bookDataAccess = new BookDataAccess();
var AllBooks = bookDataAccess.GetAllBooks();
var BooksAfter2000 = bookDataAccess.GetBooksPublishedAfterYear(2000);
var InActionsMore200Pages = bookDataAccess.GetBooksByMinimuPagesAndKeyWord(200, "in action");
var PythonBooks = bookDataAccess.GetBooksByCategory("Python");


var animalDataAccess = new AnimalDataAccess();
var GreenAnimalWithStartWithVowel = animalDataAccess.GetGreenAnimalsWhichNameStartWithVowel();


var consoleUI = new ConsoleUI();
consoleUI.PrintBooks(PythonBooks);
Console.WriteLine(bookDataAccess.AnyBookWasPublishedInYear(2005));
//consoleUI.PrintAnimals(GreenAnimalWithStartWithVowel);