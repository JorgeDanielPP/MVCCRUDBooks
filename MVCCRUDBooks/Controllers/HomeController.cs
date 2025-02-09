using Microsoft.AspNetCore.Mvc;
using MVCCRUDBooks.Controllers.Data;
using MVCCRUDBooks.Models;
using System.Diagnostics;

namespace MVCCRUDBooks.Controllers
{
    public class HomeController : Controller
    {



        private readonly MVCCRUDBooksDbContext _db;
        public HomeController(MVCCRUDBooksDbContext db)
        {

            _db = db;
        }


        public IActionResult ShowMeSomething()
        {
            //   var item = new BooksController(_db);
            return View("ShowMeSomething");
        }

        public IActionResult Index()
        {

            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
