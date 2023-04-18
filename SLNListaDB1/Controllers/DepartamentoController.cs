using Microsoft.AspNetCore.Mvc;
using SLNListaDB1.Models;
using SLNListaDB1.Models.DAL;
using System;
using System.Linq;

namespace SLNListaDB1.Controllers
{
    public class DepartamentoController : Controller
    {

        DepartamentoDAO dados6 = new DepartamentoDAO();
        public IActionResult Index()
        {
           
            ViewBag.listaDepartamento = dados6.getTodosDepartamentos();
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string nome, string funcionario)
        {
            Departamento novoDepartamento = new Departamento();
            novoDepartamento.DEPNOME = nome;
            novoDepartamento.DEPNUMEROFUNCIONARIO = funcionario;
            dados6.insertDepartamento(novoDepartamento);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            ViewBag.DepartamentoAtualizar = dados6.getTodosDepartamentos().Where(x => x.DEPID == id).FirstOrDefault();
            return View();
        }
        [HttpPost]
        public IActionResult Atualizar(string codigo, string nome, string funcionario)
        {

            Departamento atualizaFuncionario = new Departamento();
            atualizaFuncionario.DEPID = Convert.ToInt32(codigo);
            atualizaFuncionario.DEPNOME = nome;
            atualizaFuncionario.DEPNUMEROFUNCIONARIO = funcionario;
            dados6.updateDepartamento(atualizaFuncionario);

            return RedirectToAction("Index");
        }

    }
}
