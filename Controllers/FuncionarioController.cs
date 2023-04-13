using Microsoft.AspNetCore.Mvc;
using SLNListaDB1.Models.DAL;

namespace SLNListaDB1.Controllers
{
    public class FuncionarioController : Controller
    {
        public IActionResult Index()
        {
            FuncionarioDAO dados8 = new FuncionarioDAO();
            ViewBag.listaFuncionario = dados8.getTodosFuncionario();
            return View();
        }
    }
}
