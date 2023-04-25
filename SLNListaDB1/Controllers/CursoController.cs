using Microsoft.AspNetCore.Mvc;
using SLNListaDB1.Models;
using SLNListaDB1.Models.DAL;
using System;
using System.Linq;

namespace SLNListaDB1.Controllers
{
    public class CursoController : Controller
    {
        CursoDAO dados2 = new CursoDAO();
        public IActionResult Index()
        {
            
            ViewBag.listaCurso = dados2.getTodosCursos();
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string descricao, string area)
        {
            Curso novoCurso = new Curso();
            novoCurso.CUDESCRICAO = descricao;
            novoCurso.CUAREA = area;
            dados2.insertCurso(novoCurso);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            ViewBag.CursoAtualizar = dados2.getTodosCursos().Where(x => x.CUID == id).FirstOrDefault();
            return View();
        }
        [HttpPost]
        public IActionResult Atualizar(string codigo, string descricao, string area)
        {

            Curso atualizaCurso = new Curso();
            atualizaCurso.CUID = Convert.ToInt32(codigo);
            atualizaCurso.CUDESCRICAO = descricao;
            atualizaCurso.CUAREA = area;
            dados2.updateCurso(atualizaCurso);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Apagar(string id)
        {

            Curso atualizaCurso = new Curso();
            atualizaCurso.CUID = Convert.ToInt32(id);
            dados2.apagarCurso(atualizaCurso);

            return RedirectToAction("Index");
        }
    }
}
