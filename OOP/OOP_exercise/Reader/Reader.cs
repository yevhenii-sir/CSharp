using System;

namespace Exercise
{
    public class Reader
    {
        private string _fio;
        private string _cardNumber;
        private string _dateBirth;
        private string _phoneNumb;

        public Reader(string fio) : 
            this(fio, "?", "?", "?") {}

        public Reader(string fio, string cardNumber) : 
            this(fio, cardNumber, "?", "?") {}

        public Reader(string fio, string cardNumber, string dateBirth) : 
            this(fio, cardNumber, dateBirth, "?") {}

        public Reader(string fio, string cardNumber, string dateBirth, string phoneNumb)
        {
            _fio = fio;
            _cardNumber = cardNumber;
            _dateBirth = dateBirth;
            _phoneNumb = phoneNumb;
        }
        
        public void TakeBook(int numbBooks)
        {
            Console.WriteLine($"{_fio} взял {numbBooks} книги.");
        }

        public void TakeBook(params string[] books)
        {
            if (books.Length > 0)
            {
                Console.Write($"{_fio} взял книги: ");
                ShowBooks(books);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"{_fio} не взял книги!");
            }
        }

        public void TakeBook(params Book[] books)
        {
            if (books.Length > 0)
            {
                Console.Write($"{_fio} взял книги: ");
                ShowBooks(books);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"{_fio} не взял книги!");
            }
        }
        
        public void ReturnBook(int numbBooks)
        {
            Console.WriteLine($"{_fio} вернул {numbBooks} книги.");
        }

        public void ReturnBook(params string[] books)
        {
            if (books.Length > 0)
            {
                Console.Write($"{_fio} вернул книги: ");
                ShowBooks(books);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"{_fio} не вернул книги!");
            }
        }

        public void ReturnBook(params Book[] books)
        {
            if (books.Length > 0)
            {
                Console.Write($"{_fio} вернул книги: ");
                ShowBooks(books);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"{_fio} не вернул книги!");
            }
        }

        private void ShowBooks(string[] books)
        {
            foreach (var book in books)
            {
                Console.Write($"\"{book}\" ");
            }
        }

        private void ShowBooks(Book[] books)
        {
            foreach (var book in books)
            {
                Console.Write($"\"{book.NameBook}\" ");
            }
        }
    }
}
