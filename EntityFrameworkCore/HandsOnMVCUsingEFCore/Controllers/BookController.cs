using HandsOnMVCUsingEFCore.Entities;
using HandsOnMVCUsingEFCore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnMVCUsingEFCore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _repo;
        //public BookController()
        //{
        //    _repo=new BookRepository();
        //}
        //created BookRepository object using DI
        public BookController(BookRepository repo)
        {
            _repo = repo;
        }
        [Route("Books/GetAllBooks")]
        public IActionResult Index()
        {
            var books = _repo.GetBooks();
            return View(books);
        }
        [Route("Books/GetBook/{id}")]
        public IActionResult Details(int id)
        {
            var book=_repo.GetBook(id);
            return View(book);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book book)
        {
            _repo.AddBook(book);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            _repo.DeleteBook(id);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var book= _repo.GetBook(id);
            return View(book);
        }
        [HttpPost]
        public IActionResult Edit(Book book)
        {
            _repo.UpdateBook(book);
            return RedirectToAction("Index");
        }
    }
}
