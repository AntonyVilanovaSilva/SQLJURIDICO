using Microsoft.AspNetCore.Mvc;
using SLNListaDB1.Models;
using SLNListaDB1.Models.DAL;
using System;
using System.Linq;

namespace SLNListaDB1.Controllers
{
    public class RecursoController : Controller
    {
        RecursoDAO dados5 = new RecursoDAO();
        public IActionResult Index()
        {
            
            ViewBag.listaRecurso = dados5.getTodosRecursos();
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string descricao, string quantidade, string categoria)
        {
            Recurso novoRecurso = new Recurso();
            novoRecurso.RECDESCRICAO = descricao;
            novoRecurso.RECQUANTIDADE = quantidade;
            novoRecurso.RECCODIGOCATEGORIA = categoria;
            dados5.insertRecurso(novoRecurso);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            ViewBag.recursoAtualizar = dados5.getTodosRecursos().Where(x => x.RECID == id).FirstOrDefault();
            return View();
        }
        [HttpPost]
        public IActionResult Atualizar(string codigo, string descricao, string quantidade,string categoria)
        {

            Recurso atualizaRecurso = new Recurso();
            atualizaRecurso.RECID = Convert.ToInt32(codigo);
            atualizaRecurso.RECDESCRICAO = descricao;
            atualizaRecurso.RECQUANTIDADE = quantidade;
            atualizaRecurso.RECCODIGOCATEGORIA = categoria;
            dados5.updateRecurso(atualizaRecurso);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Apagar(string id)
        {

            Recurso atualizaRecurso = new Recurso();
            atualizaRecurso.RECID = Convert.ToInt32(id);
            dados5.apagarRecurso(atualizaRecurso);

            return RedirectToAction("Index");
        }
    }
}
