﻿using demoLINQ.Data;
using demoLINQ.Views;

var bookDataAccess = new BookDataAccess();
var AllBooks = bookDataAccess.GetAllBooks();
var BooksAfter2000 = bookDataAccess.GetBooksPublishedAfterYear(2000);
var InActionsMore200Pages = bookDataAccess.GetBooksByMinimumOfPages(200, "in action");
var PythonBooks = bookDataAccess.GetBooksByCategory("Python");
var BooksWithMore450pages = bookDataAccess.GetBooksByMinimumPages(450);
var MostRecentlyJavaBooks = bookDataAccess.GetMostRecentlyBooks(7, "Java");
var Books3and4WithMore400Pages = bookDataAccess.Get3And4BooksByMinimumOfPages(400);
int BooksBetween100And200Pages = bookDataAccess.GetNumberOfBooksByPagesInRange(100,200);

var animalDataAccess = new AnimalDataAccess();
var GreenAnimalWithStartWithVowel = animalDataAccess.GetGreenAnimalsWhichNameStartWithVowel();
var AllAnimalsOrderedByName = animalDataAccess.GetAnimalsOrderedByName();

var consoleUI = new ConsoleUI();
System.Console.WriteLine(BooksBetween100And200Pages);
// consoleUI.PrintBooks(PythonBooks);
// consoleUI.PrintAnimals(AllAnimalsOrderedByName);