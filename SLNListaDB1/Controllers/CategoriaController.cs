using Microsoft.AspNetCore.Mvc;
using SLNListaDB1.Models.DAL;

namespace SLNListaDB1.Controllers
{
    public class CategoriaController : Controller
    {
        public IActionResult Index()
        {
            Categoria_RecursoDAO dados4 = new Categoria_RecursoDAO();
            ViewBag.listaCategoria = dados4.getTodosCategorias();
            return View();
        }
    }
}
