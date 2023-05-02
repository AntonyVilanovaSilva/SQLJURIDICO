using Microsoft.AspNetCore.Mvc;
using Raspagem_Web_Scraping.D_ataA_ccessI_ayer;
using Raspagem_Web_Scraping.Models;
using System.Diagnostics;

namespace Raspagem_Web_Scraping.Controllers
{
    public class HomeController : Controller
    {
        private readonly DAL_Curso _cursosContext;
        public HomeController(DAL_Curso cursosContext)
        {
            _cursosContext = cursosContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            await _cursosContext.Preparar_Cursos();
            return View(_cursosContext.Pegar_Cursos());
        }

        [HttpPost]
        public IActionResult Curso(string pesquisa)
        {
            var curso = _cursosContext.Pegar_Curso
    }
}