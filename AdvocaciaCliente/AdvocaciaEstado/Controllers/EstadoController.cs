using Microsoft.AspNetCore.Mvc;

namespace AdvocaciaEstado.Controllers
{
    public class EstadoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
