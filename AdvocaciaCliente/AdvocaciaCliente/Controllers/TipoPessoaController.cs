using AdvocaciaCliente.Models;
using AdvocaciaCliente.Models.DAL;
using Microsoft.AspNetCore.Mvc;

namespace AdvocaciaCliente.Controllers
{
    public class TipoPessoaController : Controller
    {
        public IActionResult Index()
        {
           TipoPessoaDAO tipos = new TipoPessoaDAO();
            ViewBag.listaTipos = tipos.GetALlTipoPessoas();
            return View();
        }
        
        public IActionResult Exibir(string id)
        {
            TipoPessoaDAO tipos = new TipoPessoaDAO();
            ViewBag.pessoa = tipos.getTipoPessoa(id);
            return View();
        }

        public IActionResult Editar(string id)
        {
            TipoPessoaDAO tipos = new TipoPessoaDAO();
            ViewBag.pessoa = tipos.getTipoPessoa(id);
            return View();
        }
        public IActionResult Editar(string codigo, string descricao)
        {
            TipoPessoaDAO tipos = new TipoPessoaDAO();
            TipoPessoa pessoa = new TipoPessoa();
            pessoa.TIPID = Convert.ToInt32(codigo);
            pessoa.TIPDESCRICAO = descricao;

            tipos.updateTipoPessoa(codigo, pessoa);

            return RedirectToAction("Index");
        }
    }
}
