using Microsoft.AspNetCore.Mvc;

namespace HuskyNZ.Controllers
{
    public class about : Controller
    {
        public IActionResult index()
        {
            return View();
        }
    }
}
