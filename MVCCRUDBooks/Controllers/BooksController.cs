using Microsoft.AspNetCore.Mvc;
using MVCCRUDBooks.Controllers.Data;
using MVCCRUDBooks.Models;

namespace MVCCRUDBooks.Controllers
{
    public class BooksController : Controller
    {
        private readonly MVCCRUDBooksDbContext _db;
        public BooksController(MVCCRUDBooksDbContext db)
        {
            _db = db;

        }
        public ActionResult index()
        {
            var vm = new BooksViewModel();
            var info = _db.Books.ToList();

            vm.AllBooks = info;

            return View(vm);
        }
    }
}
