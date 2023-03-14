using AdvocaciaCliente.Models.DAL;
using Microsoft.AspNetCore.Mvc;

namespace AdvocaciaCliente.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            ClienteDAO dados = new ClienteDAO();
            ViewBag.listaClientes = dados.getTodosClientes();
            return View();
        }
    }
}
