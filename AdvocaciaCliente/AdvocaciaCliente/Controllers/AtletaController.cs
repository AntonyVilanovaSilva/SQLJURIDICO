using AdvocaciaCliente.Models.DAL;
using Microsoft.AspNetCore.Mvc;

namespace AdvocaciaCliente.Controllers
{
    public class AtletaController : Controller
    {
        public IActionResult Index()
        {
            AtletaDAO dados = new AtletaDAO();
            ViewBag.listaAtleta = dados.getTodosAtletas();
            return View();
        }
    }
}
