using Microsoft.AspNetCore.Mvc;
using SLNListaDB1.Models;
using SLNListaDB1.Models.DAL;
using System;
using System.Linq;

namespace SLNListaDB1.Controllers
{
    public class AlunoController : Controller
    {
        AlunoDAO dados1 = new AlunoDAO();
        public IActionResult Index()
        {
            
            ViewBag.listaAluno = dados1.getTodosAlunos();
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string nome, string sobrenome)
        {
            Aluno novoAluno = new Aluno();
            novoAluno.ALUNOME = nome;
            novoAluno.ALUSOBRENOME = sobrenome;
            dados1.insertAluno(novoAluno);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            ViewBag.AlunoAtualizar = dados1.getTodosAlunos().Where(x => x.ALUID == id).FirstOrDefault();
            return View();
        }
        [HttpPost]
        public IActionResult Atualizar(string codigo, string nome, string sobrenome)
        {

            Aluno atualizaAluno = new Aluno();
            atualizaAluno.ALUID = Convert.ToInt32(codigo);
            atualizaAluno.ALUNOME = nome;
            atualizaAluno.ALUSOBRENOME = sobrenome;
            dados1.updateAluno(atualizaAluno);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Apagar(string id)
        {

            Aluno atualizaAluno = new Aluno();
            atualizaAluno.ALUID = Convert.ToInt32(id);
            dados1.apagarAluno(atualizaAluno);

            return RedirectToAction("Index");
        }
    }
}
