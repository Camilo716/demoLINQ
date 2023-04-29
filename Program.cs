using demoLINQ.Data;
using demoLINQ.Views;

var bookDataAccess = new BookDataAccess();
var AllBooks = bookDataAccess.GetAllBooks();
var BooksAfter2000 = bookDataAccess.GetBooksPublishedAfterYear(2000);
var InActionsMore200Pages = bookDataAccess.GetBooksWithMoreThan200pagesAndContainsInAction();


var animalDataAccess = new AnimalDataAccess();
var GreenAnimalWithStartWithVowel = animalDataAccess.GetGreenAnimalsWhichNameStartWithVocal();

var consoleUI = new ConsoleUI();
consoleUI.PrintAnimals(GreenAnimalWithStartWithVowel);
//consoleUI.PrintBooks(AllBooks);