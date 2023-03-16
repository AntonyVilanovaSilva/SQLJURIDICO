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
        public IActionResult Create(string idnome, string idendereco, string idnumero)
        {
            Estado novoEstado = new Estado();
            novoEstado.ESTADODESCRIÇÃO = idnome;
            novoEstado.ESTSIGLA = idendereco;
           

            EstadoDAO dados = new EstadoDAO();
            bool result = dados.inserirCliente(novocliente);
            if (result)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

        }
    }
}
