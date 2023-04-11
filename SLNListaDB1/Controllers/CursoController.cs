using Microsoft.AspNetCore.Mvc;
using SLNListaDB1.Models.DAL;

namespace SLNListaDB1.Controllers
{
    public class CursoController : Controller
    {
        public IActionResult Index()
        {
            ResponsavelDAO dados2 = new ResponsavelDAO();
            ViewBag.listaCurso = dados2.getTodosCursos();
            return View();
        }
    }
}
