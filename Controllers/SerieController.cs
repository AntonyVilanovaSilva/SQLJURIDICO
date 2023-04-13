using Microsoft.AspNetCore.Mvc;
using SLNListaDB1.Models;
using SLNListaDB1.Models.DAL;

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
    }
}
