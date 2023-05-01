using demoLINQ.Data;
using demoLINQ.Views;

var bookDataAccess = new BookDataAccess();
var AllBooks = bookDataAccess.GetAllBooks();
var BooksAfter2000 = bookDataAccess.GetBooksPublishedAfterYear(2000);
var InActionsMore200Pages = bookDataAccess.GetBooksByMinimuPages(200, "in action");
var PythonBooks = bookDataAccess.GetBooksByCategory("Python");
var BooksWithMore450pages = bookDataAccess.GetBooksByMinimumPages(450);

var animalDataAccess = new AnimalDataAccess();
var GreenAnimalWithStartWithVowel = animalDataAccess.GetGreenAnimalsWhichNameStartWithVowel();
var AllAnimalsOrderedByName = animalDataAccess.GetAnimalsOrderedByName();

var consoleUI = new ConsoleUI();
//consoleUI.PrintBooks(BooksWithMore450pages);
consoleUI.PrintAnimals(AllAnimalsOrderedByName);