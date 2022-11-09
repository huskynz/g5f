using Microsoft.AspNetCore.Mvc;

namespace HuskyNZ.Controllers
{
    public class live : Controller
    {
        public IActionResult index()
        {
            return View();
        }
    }
}
