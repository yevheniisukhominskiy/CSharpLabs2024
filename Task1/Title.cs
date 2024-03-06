using System;

namespace BookLibrary
{
    public class Title
    {
        private string title;

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public void Show()
        {
            Console.WriteLine(title);
        }
    }
}
