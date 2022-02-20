using ControleContatos.Models;
using ControleContatos.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;


namespace ControleContatos.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;
        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }
        public IActionResult Index()
        {
            List<ContatoModel> contatos = _contatoRepositorio.BuscarTodos();
            return View(contatos);
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar(int id)
        {
            ContatoModel contato = _contatoRepositorio.ListarPorId(id);
            return View(contato);
        }
        public IActionResult Apagar(int id)
        {
            ContatoModel contato = _contatoRepositorio.ListarPorId(id);
            return View(contato);
        }
        public IActionResult ApagarConf(int id)
        {
            _contatoRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }
        //Passar o parametro ContatoModel
        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            contato = _contatoRepositorio.Adicionar(contato);
            return RedirectToAction("Index");
        }
        public IActionResult Atualizar(ContatoModel contato)
        {
            contato = _contatoRepositorio.Atualizar(contato);
            return RedirectToAction("Index");
        }
    }
}
