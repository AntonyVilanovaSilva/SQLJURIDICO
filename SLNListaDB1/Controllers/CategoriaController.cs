using Microsoft.AspNetCore.Mvc;
using SLNListaDB1.Models;
using SLNListaDB1.Models.DAL;
using System;
using System.Linq;

namespace SLNListaDB1.Controllers
{
    public class CategoriaController : Controller
    {
        Categoria_RecursoDAO dados4 = new Categoria_RecursoDAO();
        public IActionResult Index()
        {
           
            ViewBag.listaCategoria = dados4.getTodosCategorias();
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string descricao, string nome)
        {
            CategoriaRecurso novoCategoria = new CategoriaRecurso();
            novoCategoria.CATDESCRICAO = descricao;
            novoCategoria.CATNOME = nome;
            dados4.insertCategoriaRecurso(novoCategoria);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            ViewBag.CategoriaAtualizar = dados4.getTodosCategorias().Where(x => x.CATID == id).FirstOrDefault();
            return View();
        }
        [HttpPost]
        public IActionResult Atualizar(string codigo, string descricao, string nome)
        {

            CategoriaRecurso atualizaCategoriaRecurso = new CategoriaRecurso();
            atualizaCategoriaRecurso.CATID = Convert.ToInt32(codigo);
            atualizaCategoriaRecurso.CATDESCRICAO = descricao;
            atualizaCategoriaRecurso.CATNOME = nome;
            dados4.updateCategoriaRecurso(atualizaCategoriaRecurso);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Apagar(string id)
        {

            CategoriaRecurso atualizaCategoriaRecurso = new CategoriaRecurso();
            atualizaCategoriaRecurso.CATID = Convert.ToInt32(id);
            dados4.apagarCategoriaRecurso(atualizaCategoriaRecurso);

            return RedirectToAction("Index");
        }
    }
}
