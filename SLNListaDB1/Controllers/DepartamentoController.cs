using Microsoft.AspNetCore.Mvc;
using SLNListaDB1.Models.DAL;

namespace SLNListaDB1.Controllers
{
    public class DepartamentoController : Controller
    {
        public IActionResult Index()
        {
           DepartamentoDAO dados6 = new DepartamentoDAO();
            ViewBag.listaDepartamento = dados6.getTodosDepartamentos();
            return View();
        }
    }
}
