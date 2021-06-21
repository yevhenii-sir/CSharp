namespace Exercise
{
    public class Book
    {
        public string NameBook { get; private set; }
        public string AuthorBook { get; private set; }

        public Book(string nameBook, string authorBook)
        {
            NameBook = nameBook;
            AuthorBook = authorBook;
        }
    }
}
