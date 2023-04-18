using Microsoft.AspNetCore.Mvc;
using SLNListaDB1.Models;
using SLNListaDB1.Models.DAL;
using System;
using System.Linq;

namespace SLNListaDB1.Controllers
{
    public class NiveldeEnsinoController : Controller
    {
        NiveldeEnsinoDAO dados7 = new NiveldeEnsinoDAO();
        public IActionResult Index()
        {
            
            ViewBag.listaNiveldeEnsino = dados7.getTodosNiveldeEnsino();
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string nome, string descricao)
        {
           NiveldeEnsino novoNiveldeEnsino = new NiveldeEnsino();
            novoNiveldeEnsino.NIENOME = nome;
            novoNiveldeEnsino.NIENDESCRICAO = descricao;
            dados7.insertNiveldeEnsino(novoNiveldeEnsino);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            ViewBag.NiveldeEnsinoAtualizar = dados7.getTodosNiveldeEnsino().Where(x => x.NIENID == id).FirstOrDefault();
            return View();
        }
        [HttpPost]
        public IActionResult Atualizar(string codigo, string nome, string descricao)
        {

            NiveldeEnsino atualizaNiveldeEnsino = new NiveldeEnsino();
            atualizaNiveldeEnsino.NIENID = Convert.ToInt32(codigo);
            atualizaNiveldeEnsino.NIENOME = nome;
            atualizaNiveldeEnsino.NIENDESCRICAO = descricao;
            dados7.updateNiveldeEnsino(atualizaNiveldeEnsino);

            return RedirectToAction("Index");
        }
    }
}
