using Fiap06.Web.MVC.Models;
using Fiap06.Web.MVC.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap06.Web.MVC.Controllers
{
    public class AnimalController : Controller
    {
        private PetshopContext _context = new PetshopContext();


        [HttpGet]
        public ActionResult Cadastrar()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Animal animal)
        {
            _context.Animais.Add(animal);
            _context.SaveChanges();
            TempData["msg"] = "Animal cadastrado!";
            return RedirectToAction("Cadastrar");
        }
    }
}