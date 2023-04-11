using Microsoft.AspNetCore.Mvc;
using SLNListaDB1.Models.DAL;

namespace SLNListaDB1.Controllers
{
    public class DepartamentoController : Controller
    {
        public IActionResult Index()
        {
            ResponsavelDAO dados6 = new ResponsavelDAO();
            ViewBag.listaDepartamento = dados6.getTodosDepartamentos();
            return View();
        }
    }
}
