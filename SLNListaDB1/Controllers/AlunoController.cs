using Microsoft.AspNetCore.Mvc;
using SLNListaDB1.Models.DAL;

namespace SLNListaDB1.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            ResponsavelDAO dados1 = new ResponsavelDAO();
            ViewBag.listaAluno = dados1.getTodosAlunos();
            return View();
        }
    }
}
