using System;

namespace Exercise
{
    static class ReaderDemo
    {
        static void Main(string[] args)
        {
            Reader[] readers =
            {
                new Reader("Cиренко Е.О.", "74554"),
                new Reader("Ляшенко Р.И.", "14542", "27.07.2002"),
                new Reader("Журба О.С.", "93213", 
                    "13.03.2003", "+380646235874")
            };

            Book[] books =
            {
                new Book("Песни о паскале", "Деревенец Олег"),
                new Book("С# 4.0", "Гиберт Шилтд"),
                new Book("Turbo Pascal","Культин Никита")
            };
            
            readers[0].TakeBook(books[0], books[1]);
            readers[1].TakeBook(books[0], books[1], books[2]);
            readers[2].TakeBook(books[1]);
            
            Console.WriteLine();
            
            readers[0].TakeBook("С# 7.0", "C# 5.0");
            
            Console.WriteLine();
            
            readers[1].ReturnBook(books[0], books[2]);
        }
    }
}
