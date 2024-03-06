using System;

namespace BookLibrary
{
    public class Book
    {
        private Title title;
        private Author author;
        private Content content;

        public Book()
        {
            this.title = new Title();
            this.author = new Author();
            this.content = new Content();
        }

        public void SetTitle(string title)
        {
            this.title.SetTitle(title);
        }

        public void SetAuthor(string author)
        {
            this.author.SetAuthor(author);
        }

        public void SetContent(string content)
        {
            this.content.SetContent(content);
        }

        public void ShowBookDetails()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Title: ");
            title.Show();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Author: ");
            author.Show();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Content: ");
            content.Show();
            Console.ResetColor();
        }
    }
}
