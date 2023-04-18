using Microsoft.AspNetCore.Mvc;
using SLNListaDB1.Models;
using SLNListaDB1.Models.DAL;
using System;
using System.Linq;

namespace SLNListaDB1.Controllers
{
    public class FuncionarioController : Controller
    {
        FuncionarioDAO dados8 = new FuncionarioDAO();
        public IActionResult Index()
        {
            
            ViewBag.listaFuncionario = dados8.getTodosFuncionario();
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string nome, string entrada, string departamento)
        {
            Funcionario novoFuncionario = new Funcionario();
            novoFuncionario.FUNOME = nome;
            novoFuncionario.FUNDATADEENTRADA = entrada;
            novoFuncionario.FUNCODIGODEPARTAMENTO = departamento;
            dados8.insertFuncionario(novoFuncionario);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            ViewBag.FuncionarioAtualizar = dados8.getTodosFuncionario().Where(x => x.FUNID == id).FirstOrDefault();
            return View();
        }
        [HttpPost]
        public IActionResult Atualizar(string codigo, string nome, string entrada,string departamento)
        {

            Funcionario atualizaFuncionario = new Funcionario();
            atualizaFuncionario.FUNID = Convert.ToInt32(codigo);
            atualizaFuncionario.FUNOME = nome;
            atualizaFuncionario.FUNDATADEENTRADA = entrada;
            atualizaFuncionario.FUNCODIGODEPARTAMENTO = departamento;
            dados8.updateFuncionario(atualizaFuncionario);

            return RedirectToAction("Index");
        }
    }
}
