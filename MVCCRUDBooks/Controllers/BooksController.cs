using Microsoft.AspNetCore.Mvc;

namespace MVCCRUDBooks.Controllers
{
    public class BooksController: Controller
    {
        public BooksController() 
        {
        
        }
        public ActionResult index()
        {
            return View();
        }
    }
}
