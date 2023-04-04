using GestaoSala.DAL;
using Microsoft.AspNetCore.Mvc;

namespace GestaoSala.Controllers
{
    public class OCUPACAOController : Controller
    {
        OCUPACAODAO TBOCUPACAO = new OCUPACAODAO();
        public IActionResult Index()
        {
            ViewBag.listaOCUPACAO = TBOCUPACAO.getTodasAsOcupacoes();
            return View();
        }
    }
}
