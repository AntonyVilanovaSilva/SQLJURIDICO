using AdvocaciaCliente.Models.DAL;
using Microsoft.AspNetCore.Mvc;

namespace AdvocaciaCliente.Controllers
{
    public class CategoriaDocumentoController1 : Controller
    {
        public IActionResult Index()
        {
            CategoriaDocumentoDAO tipo = new CategoriaDocumentoDAO();
            ViewBag.listaDocumentos = tipo.GetALlCategoriaDocumento();
            return View();
        }
    }
}
