﻿using AdvocaciaCliente.Models;
using AdvocaciaCliente.Models.DAL;
using Microsoft.AspNetCore.Mvc;

namespace AdvocaciaCliente.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            ClienteDAO dados = new ClienteDAO();
            ViewBag.listaClientes = dados.getTodosClientes();
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Create(string idnome, string idendereco, string idnumero)
        {
            Cliente novoCliente = new Cliente();
            novoCliente.CLINOME = idnome;
            novoCliente.CLIENDERECO = idendereco;
            novoCliente.CLINUMEROENDERECO = idnumero;

            ClienteDAO dados = new ClienteDAO();
            bool result = dados.inserirCliente(novoCliente);
            if (result)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

        }



    }

}
    
