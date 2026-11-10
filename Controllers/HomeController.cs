using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TranNgocKhanh_241230761.Models;

namespace TranNgocKhanh_241230761.Controllers
{
    public class HomeController : Controller
    {
        private readonly QlhangHoaContext _context;
        public HomeController(QlhangHoaContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var list = _context.HangHoas.Where(h => h.Gia >= 100).ToList();
            return View(list);
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
