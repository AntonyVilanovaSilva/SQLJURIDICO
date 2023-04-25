using Microsoft.AspNetCore.Mvc;
using SLNListaDB1.Models;
using SLNListaDB1.Models.DAL;
using System;
using System.Linq;

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

        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            ViewBag.salaAtualizar = dados3.getTodosSalas().Where(x => x.SALAID == id).FirstOrDefault();
            return View();
        }
        [HttpPost]
        public IActionResult Atualizar(string codigo, string descricao, string numero)
        {

            Sala atualizaSala = new Sala();
            atualizaSala.SALAID = Convert.ToInt32(codigo);
            atualizaSala.SALADESCRICAO = descricao;
            atualizaSala.SALANUMERO = numero;
            dados3.updateSala(atualizaSala);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Apagar(string id)
        {

            Sala atualizaSala= new Sala();
            atualizaSala.SALAID = Convert.ToInt32(id);
            dados3.apagarSala(atualizaSala);

            return RedirectToAction("Index");
        }

    }
}
