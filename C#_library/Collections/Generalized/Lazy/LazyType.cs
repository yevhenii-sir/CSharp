using System;

namespace LearnCSharpOther
{
    class Library
    {
        private string[] books = new string[99];

        public void GetBook()
        {
            Console.WriteLine("Выдаем книгу читателю.");
        }
    }

    class Reader
    {
        private Lazy<Library> _library = new Lazy<Library>();

        public void ReadBook()
        {
            _library.Value.GetBook();
            Console.WriteLine("Читаем бумажную книгу");
        }

        public void ReadEBook()
        {
            Console.WriteLine("Читаем книгу на компютере");
        }
    } 
    
    static class LazyType
    {
        static void Main(string[] args)
        {
            Reader reader = new Reader();
            reader.ReadEBook();
            reader.ReadBook();
        }
    }
}
