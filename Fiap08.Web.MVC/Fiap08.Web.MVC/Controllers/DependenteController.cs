using Fiap08.Web.MVC.Models;
using Fiap08.Web.MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap08.Web.MVC.Controllers
{
    public class DependenteController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_unit.DependenteRepository.Listar());
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            var lista = _unit.ResponsavelRepository.Listar();
            ViewBag.responsaveis =
                new SelectList(lista, "ResponsavelId", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Dependente dep)
        {
            _unit.DependenteRepository.Cadastrar(dep);
            _unit.Salvar();
            TempData["msg"] = "Dependente cadastrado!";
            return RedirectToAction("Cadastrar");
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}