using HandsOnMVCUsingModelWithViews.Models;

namespace HandsOnMVCUsingModelWithViews.Repositories
{
    public interface IBookRepository
    {
        List<Book> GetAllBooks();
        void AddBook(Book book);
    }
    public class BookRepository : IBookRepository
    {
        private static List<Book> books = new List<Book>()
        {
            new Book(){Id=324093,Title="Asp.net Core 10.0",Author="Microsoft",Price=2300}
        };
        public void AddBook(Book book)
        {
            books.Add(book); //add new book to list
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }
    }
}
