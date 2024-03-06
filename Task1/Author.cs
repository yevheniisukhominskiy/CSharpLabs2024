using System;

namespace BookLibrary
{
    public class Author
    {
        private string author;

        public void SetAuthor(string author)
        {
            this.author = author;
        }

        public void Show()
        {
            Console.WriteLine(author);
        }
    }
}
