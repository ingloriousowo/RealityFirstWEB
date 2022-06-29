using Microsoft.AspNetCore.Mvc;

namespace RealityFirst.Controllers
{
    public class EventoController : Controller
    {
        public IActionResult eventos()
        {
            return View();
        }

        public IActionResult ficha()
        {
            return View();
        }
    }
}
