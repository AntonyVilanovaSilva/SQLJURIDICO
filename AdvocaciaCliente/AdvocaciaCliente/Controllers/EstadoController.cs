using AdvocaciaCliente.Models;
using AdvocaciaCliente.Models.DAL;
using Microsoft.AspNetCore.Mvc;

namespace AdvocaciaCliente.Controllers
{
    public class EstadoController : Controller
    {
        public IActionResult Index()
        {
            EstadoDAO dados = new EstadoDAO();
            ViewBag.listaClientes = dados.getTodosClientes();
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
       

        
    }
}
