using Microsoft.AspNetCore.Mvc;
using SLNListaDB1.Models;
using SLNListaDB1.Models.DAL;
using System;
using System.Linq;

namespace SLNListaDB1.Controllers
{
    public class SerieController : Controller
    {
        SerieDAO dados7 = new SerieDAO();
        [HttpGet]
        public IActionResult Index()
        {
            
            ViewBag.listaSerie = dados7.getTodosSerie();
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string nome, string episodio)
        {
            Serie novaserie = new Serie();
            novaserie.SERNOME = nome;
            novaserie.SEREPISODIO = episodio;
            dados7.insertSerie(novaserie);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            ViewBag.serieAtualizar = dados7.getTodosSerie().Where(x => x.SERID== id).FirstOrDefault();
            return View();
        }
        [HttpPost]
        public IActionResult Atualizar(string codigo, string descricao,string episodio)
        {

            Serie atualizaSerie = new Serie();
            atualizaSerie.SERID = Convert.ToInt32(codigo);
            atualizaSerie.SERNOME = descricao;
            atualizaSerie.SEREPISODIO = descricao;

            dados7.updateSerie(atualizaSerie);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Apagar(string id)
        {

            Serie atualizaSerie = new Serie();
            atualizaSerie.SERID = Convert.ToInt32(id);
            dados7.apagarSerie(atualizaSerie);

            return RedirectToAction("Index");
        }
    }
}
