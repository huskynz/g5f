using Microsoft.AspNetCore.Mvc;

namespace HuskyNZ.Controllers
{
    public class downloads : Controller
    {
        public IActionResult index()
        {
            return View();
        }
    }
}
