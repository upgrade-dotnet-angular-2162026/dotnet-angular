using HandsOnMVCUsingEFCore.DataBase;
using HandsOnMVCUsingEFCore.Entities;

namespace HandsOnMVCUsingEFCore.Repositories
{
    public class BookRepository
    {
        private readonly AppDBContext _context;
        //Initiate Context object using DI
        public BookRepository(AppDBContext context)
        {
            _context = context;
        }

        //public BookRepository()
        //{
        //    _context= new AppDBContext();
        //}

        public void AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }
        public void UpdateBook(Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();
        }
        public void DeleteBook(int bookId)
        {
            Book ?book= _context.Books.FirstOrDefault(b=>b.Id==bookId);
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
        public Book? GetBook(int id)
        {
            var book = _context.Books.Find(id);
            return book;
        }
        public List<Book> GetBooks()
        {
            var books=_context.Books.ToList();
            return books;
        }

    }
}
