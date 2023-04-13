using Microsoft.AspNetCore.Mvc;
using SLNListaDB1.Models.DAL;

namespace SLNListaDB1.Controllers
{
    public class RecursoController : Controller
    {
        public IActionResult Index()
        {
            RecursoDAO dados5 = new RecursoDAO();
            ViewBag.listaRecurso = dados5.getTodosRecursos();
            return View();
        }
    }
}
