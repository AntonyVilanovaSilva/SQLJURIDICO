using AdvocaciaEstado.Models.DAL;
using Microsoft.AspNetCore.Mvc;

namespace AdvocaciaEstado.Controllers
{
    public class EstadoController : Controller
    {
        public IActionResult Index()
        {
            EstadoDAO = new EstadoDAO();
            ViewBag.listaClientes = dados.getTodosClientes();
            return View();
        }
    }
}
