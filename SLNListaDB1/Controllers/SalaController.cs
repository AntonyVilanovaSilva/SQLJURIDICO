using Microsoft.AspNetCore.Mvc;
using SLNListaDB1.Models.DAL;

namespace SLNListaDB1.Controllers
{
    public class SalaController : Controller
    {
        public IActionResult Index()
        {
            ResponsavelDAO dados3 = new ResponsavelDAO();
            ViewBag.listaSala = dados3.getTodosSalas();
            return View();
        }
    }
}
