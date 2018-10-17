using _05.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05.Fiap.Web.MVC.Controllers
{
    public class BarController : Controller
    {
        private static List<Bar> _lista = new List<Bar>();

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_lista);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            List<string> cidades = new List<string>();
            cidades.Add("São Paulo");
            cidades.Add("Rio de Janeiro");
            //Enviar para a pagina a lista de cidades para o select
            ViewBag.listaCidades = new SelectList(cidades);
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Bar bar)
        {
            _lista.Add(bar);
            TempData["msg"] = "Bar cadastrado!";
            return RedirectToAction("Cadastrar");
        }
    }
}