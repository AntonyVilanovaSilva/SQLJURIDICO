using Microsoft.AspNetCore.Mvc;
using SLNListaDB1.Models.DAL;

namespace SLNListaDB1.Controllers
{
    public class CategoriaController : Controller
    {
        public IActionResult Index()
        {
            ResponsavelDAO dados4 = new ResponsavelDAO();
            ViewBag.listaCategoria = dados4.getTodosCategorias();
            return View();
        }
    }
}
