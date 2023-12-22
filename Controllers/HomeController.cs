using Microsoft.AspNetCore.Mvc;
using NewSQLMVCAPP.Models;
using System.Diagnostics;

namespace NewSQLMVCAPP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyContext context;

        public HomeController(ILogger<HomeController> logger,MyContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            var productlist = context.Products.ToList();

            return View(productlist);
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
