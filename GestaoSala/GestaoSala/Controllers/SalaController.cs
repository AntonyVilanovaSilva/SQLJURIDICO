using GestaoSala.DAL;
using Microsoft.AspNetCore.Mvc;

namespace GestaoSala.Controllers
{
    public class SalaController : Controller
    {
        SALADAO tbSala = new SALADAO();
        public IActionResult Index()
        {
            ViewBag.listasalas = tbSala.getTodasAsSalas();
            return View();
        }
    }
}
