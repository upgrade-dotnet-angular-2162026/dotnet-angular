using Microsoft.AspNetCore.Mvc;
using HandsOnMVCUsingModelWithViews.Repositories;
using HandsOnMVCUsingModelWithViews.Models;
namespace HandsOnMVCUsingModelWithViews.Controllers
{
    public class BookController : Controller
    {
        private IBookRepository bookRepository;
        public BookController()
        {
            bookRepository= new BookRepository();
        }
        //show the book details
        public IActionResult Index()
        {
            var books = bookRepository.GetAllBooks();
            return View(books);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book book)
        {
            //adding book details to system
            bookRepository.AddBook(book);
            return RedirectToAction("Index");
        }
    }
}
