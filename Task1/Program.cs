using BookLibrary;
using System;

class Program
{
    static void Main()
    {
        Book myBook = new Book();

        myBook.SetTitle("The Great Gatsby");
        myBook.SetAuthor("F. Scott Fitzgerald");
        myBook.SetContent("A story about the American Dream.");

        myBook.ShowBookDetails();

        Console.ReadLine();
    }
}
