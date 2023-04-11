using Microsoft.AspNetCore.Mvc;
using SLNListaDB1.Models.DAL;

namespace SLNListaDB1.Controllers
{
    public class ResponsavelController : Controller
    {
        public IActionResult Index()
        {
            ResponsavelDAO dados = new ResponsavelDAO();
            ViewBag.listaResponsavel = dados.getTodosResponsavel();
            return View();
        }
    }
}
