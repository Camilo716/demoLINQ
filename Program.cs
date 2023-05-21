using demoLINQ.Data;
using demoLINQ.Views;

var bookDataAccess = new BookDataAccess();
var AllBooks = bookDataAccess.GetAllBooks();
var BooksAfter2000 = bookDataAccess.GetBooksPublishedAfterYear(2000);
var InActionsMore200Pages = bookDataAccess.GetBooksByMinimumOfPages(200, "in action");
var PythonBooks = bookDataAccess.GetBooksByCategory("Python");
var BooksWithMore450pages = bookDataAccess.GetBooksByMinimumPages(450);
var MostRecentlyJavaBooks = bookDataAccess.GetMostRecentlyBooks(7, "Java");
var Books3and4WithMore400Pages = bookDataAccess.Get3And4BooksByMinimumOfPages(400);
long BooksBetween100And200Pages = bookDataAccess.GetNumberOfBooksByPagesInRange(100,200);
DateOnly OldestPublishDate = bookDataAccess.GetOldestPublishDate();
int HighestPageCount = bookDataAccess.GetHighestPageCount();
var LowePageCountBook = bookDataAccess.GetLowestPageCountBook();
int TotalBooksPages = bookDataAccess.GetTotalBooksPages();
string booksTittlesAfter2010 = bookDataAccess.GetBooksTittlesAfterYear(2010);
double TittlesLengthAverage = bookDataAccess.GetTittlesLengthAverage();
var BooksGroupedByYear = bookDataAccess.GetBooksGroupedByYear(2000); 
var BooksDictionary = bookDataAccess.GetBooksDictionaryByInitialLetter();

var animalDataAccess = new AnimalDataAccess();
var GreenAnimalWithStartWithVowel = animalDataAccess.GetGreenAnimalsWhichNameStartWithVowel();
var AllAnimalsOrderedByName = animalDataAccess.GetAnimalsOrderedByName();
var AnimalsGroupedByColor = animalDataAccess.GetAnimalsGroupedByColor();


var consoleUI = new ConsoleUI();
// consoleUI.PrintBooksIGroupingInt(BooksGroupedByYear);
// consoleUI.PrintAnimalsIGroupingString(AnimalsGroupedByColor);
consoleUI.PrintBooksILookupChar(BooksDictionary, 'M');
// consoleUI.PrintBooks(PythonBooks);
// consoleUI.PrintAnimals(AllAnimalsOrderedByName);