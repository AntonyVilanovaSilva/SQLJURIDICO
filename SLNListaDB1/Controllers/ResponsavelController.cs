using Microsoft.AspNetCore.Mvc;
using SLNListaDB1.Models;
using SLNListaDB1.Models.DAL;
using System;
using System.Linq;

namespace SLNListaDB1.Controllers
{
    public class ResponsavelController : Controller
    {
        ResponsavelDAO dados8 = new ResponsavelDAO();
        public IActionResult Index()
        {
            
            ViewBag.listaResponsavel = dados8.getTodosResponsavel();
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        

        [HttpPost]
        public IActionResult Create(string nome, string idade)
        {
            Responsavel novoResponsavel = new Responsavel();
            novoResponsavel.RESNOME = nome;
            novoResponsavel.RESIDADE = idade;
            dados8.insertResponsavel(novoResponsavel);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            ViewBag.responsavelAtualizar = dados8.getTodosResponsavel().Where(x => x.RESID == id).FirstOrDefault();
            return View();
        }
        [HttpPost]
        public IActionResult Atualizar(string codigo, string nome, string idade)
        {

            Responsavel atualizaRecurso = new Responsavel();
            atualizaRecurso.RESID = Convert.ToInt32(codigo);
            atualizaRecurso.RESNOME = nome;
            atualizaRecurso.RESIDADE = idade;
            dados8.updateResponsavel(atualizaRecurso);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Apagar(string id)
        {

            Responsavel atualizaResponsavel = new Responsavel();
            atualizaResponsavel.RESID = Convert.ToInt32(id);
            dados8.apagarResponsavel(atualizaResponsavel);

            return RedirectToAction("Index");
        }
    }
}
