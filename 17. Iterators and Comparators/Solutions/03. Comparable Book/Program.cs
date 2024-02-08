using IteratorsAndComparators;

// Example Usage
Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
Book bookThree = new Book("The Documents in the Case", 1930);
Book bookFour = new Book("The Lovely Bones", 2002, "Alice Sebold");

Library libraryOne = new Library();
Library libraryTwo = new Library(bookOne, bookTwo, bookThree, bookFour);

foreach (var book in libraryOne) Console.WriteLine(book);
foreach (var book in libraryTwo) Console.WriteLine(book);