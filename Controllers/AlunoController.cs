using Microsoft.AspNetCore.Mvc;
using SLNListaDB1.Models.DAL;

namespace SLNListaDB1.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            AlunoDAO dados1 = new AlunoDAO();
            ViewBag.listaAluno = dados1.getTodosAlunos();
            return View();
        }
    }
}
