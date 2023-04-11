using Microsoft.AspNetCore.Mvc;
using SLNListaDB1.Models.DAL;

namespace SLNListaDB1.Controllers
{
    public class NiveldeEnsinoController : Controller
    {
        public IActionResult Index()
        {
            ResponsavelDAO dados8 = new ResponsavelDAO();
            ViewBag.listaNiveldeEnsino = dados8.getTodosNiveldeEnsino();
            return View();
        }
    }
}
