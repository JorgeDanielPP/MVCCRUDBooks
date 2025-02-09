using Microsoft.AspNetCore.Mvc;
using MVCCRUDBooks.Controllers.Data;

namespace MVCCRUDBooks.Controllers
{
    public class BooksController: Controller
    {
        private readonly MVCCRUDBooksDbContext _db;
        public BooksController(MVCCRUDBooksDbContext db)
        {
            _db = db;
            
        }
        public ActionResult index()
        {
            var info = _db.Books.ToList();

            return View();
        }
    }
}
