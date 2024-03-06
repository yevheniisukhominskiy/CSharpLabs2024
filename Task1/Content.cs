using System;

namespace BookLibrary
{
    public class Content
    {
        private string content;

        public void SetContent(string content)
        {
            this.content = content;
        }

        public void Show()
        {
            Console.WriteLine(content);
        }
    }
}
