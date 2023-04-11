using Microsoft.AspNetCore.Mvc;
using SLNListaDB1.Models.DAL;

namespace SLNListaDB1.Controllers
{
    public class SerieController : Controller
    {
        public IActionResult Index()
        {
            ResponsavelDAO dados7 = new ResponsavelDAO();
            ViewBag.listaSerie = dados7.getTodosSerie();
            return View();
        }
    }
}
