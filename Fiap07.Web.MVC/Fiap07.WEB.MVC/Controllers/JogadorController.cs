using Fiap07.Web.MVC.Models;
using Fiap07.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap07.Web.MVC.Controllers
{
    public class JogadorController : Controller
    {
        private BrasfootContext _context = new BrasfootContext();

        [HttpGet]
        public ActionResult Buscar(int? codigo)
        {
            //Pesquisa os jogadores pelo time
            var lista = _context.Jogadores.Include("Time")
                  .Where(j => j.TimeId == codigo || codigo == null).ToList();
            CarregarComboTimes();
            //Página e a lista de jogadores
            return View("Listar", lista);
        }

        [HttpGet]
        public ActionResult Listar()
        {
            CarregarComboTimes();
            var lista = _context.Jogadores.Include("Time").ToList();
            return View(lista);
        }

        [HttpPost]
        public ActionResult Cadastrar(Jogador jogador)
        {
            _context.Jogadores.Add(jogador);
            _context.SaveChanges();
            TempData["msg"] = "Jogador cadastrado!";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            CarregarComboTimes();
            return View();
        }

        private void CarregarComboTimes()
        {
            //Buscar os times cadastrados no banco 
            var lista = _context.Times.ToList();
            //Enviar através da ViewBag os times
            ViewBag.churros = new SelectList(lista, "TimeId", "Nome");
        }
    }
}