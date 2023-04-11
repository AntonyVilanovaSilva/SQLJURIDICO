using Microsoft.AspNetCore.Mvc;
using SLNListaDB1.Models.DAL;

namespace SLNListaDB1.Controllers
{
    public class FuncionarioController : Controller
    {
        public IActionResult Index()
        {
            ResponsavelDAO dados8 = new ResponsavelDAO();
            ViewBag.listaFuncionario = dados8.getTodosFuncionario();
            return View();
        }
    }
}
