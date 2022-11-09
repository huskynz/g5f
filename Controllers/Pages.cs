using hunzg5_0.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace hunzg5_0.Controllers
{
    public class Pages : Controller
    {
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult toc()
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
