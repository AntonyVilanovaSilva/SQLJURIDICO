using Microsoft.AspNetCore.Mvc;
using SLNListaDB1.Models.DAL;

namespace SLNListaDB1.Controllers
{
    public class RecursoController : Controller
    {
        public IActionResult Index()
        {
            ResponsavelDAO dados5 = new ResponsavelDAO();
            ViewBag.listaRecurso = dados5.getTodosRecursos();
            return View();
        }
    }
}
