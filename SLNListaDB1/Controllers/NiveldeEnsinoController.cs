using Microsoft.AspNetCore.Mvc;
using SLNListaDB1.Models.DAL;

namespace SLNListaDB1.Controllers
{
    public class NiveldeEnsinoController : Controller
    {
        public IActionResult Index()
        {
            NiveldeEnsinoDAO dados8 = new NiveldeEnsinoDAO();
            ViewBag.listaNiveldeEnsino = dados8.getTodosNiveldeEnsino();
            return View();
        }
    }
}
