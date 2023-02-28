using AspMvcJwt.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspMvcJwt.Controllers
{
    public class HomeController : Controller
    {
        ApplicationContext db = new ApplicationContext();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View("CreatePerson");
        }
        public async Task<IActionResult> CreatePersonData(Models.Person per)
        {
                db.Persons.Add(per);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
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