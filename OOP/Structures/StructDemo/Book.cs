using System;

namespace LearnCSharpInterface
{
    public struct Book
    {
        public string Author;
        public string Title;
        public int Copyright;

        public Book(string a, string t, int c)
        {
            Author = a;
            Title = t;
            Copyright = c;
        }

        public void ShowBook()
        {
            Console.WriteLine(Author + ", " + Title +
                              ", (c) " + Copyright);
        }
    }
}
