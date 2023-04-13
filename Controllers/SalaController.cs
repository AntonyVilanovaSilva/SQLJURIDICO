using Microsoft.AspNetCore.Mvc;
using SLNListaDB1.Models;
using SLNListaDB1.Models.DAL;

namespace SLNListaDB1.Controllers
{
    public class SalaController : Controller
    {
        SalaDAO dados3 = new SalaDAO();

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.listaSala = dados3.getTodosSalas();
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        } 

        [HttpPost]
        public IActionResult Create(string descricao, string numero)
        {
            Sala novasala = new Sala();
            novasala.SALADESCRICAO = descricao;
            novasala.SALANUMERO = numero;
            dados3.insertSala(novasala);

            return RedirectToAction("Index");
        }

    }
}
