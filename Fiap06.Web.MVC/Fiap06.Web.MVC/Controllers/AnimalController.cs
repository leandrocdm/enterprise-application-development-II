using Fiap06.Web.MVC.Models;
using Fiap06.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap06.Web.MVC.Controllers
{
    public class AnimalController : Controller
    {
        private PetshopContext _context = new PetshopContext();

        [HttpGet]
        public ActionResult Pesquisar(string nome)
        {
            //Pesquisar os animais pelo nome
            var lista = _context.Animais
                .Where(a => a.Nome.Contains(nome)).ToList();
            //retornar para a página Listar.cshtml 
            //com a lista de animais "filtrado"
            return View("Listar", lista);
        }

        [HttpPost]
        public ActionResult Excluir(int id)
        {
            //Busca o animal pelo código
            var animal = _context.Animais.Find(id);
            //Remove o animal do banco
            _context.Animais.Remove(animal);
            //Commit
            _context.SaveChanges();
            //Mensagem de sucesso
            TempData["msg"] = "Animal excluido";
            //Retorna para a lista
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Alterar(Animal animal)
        {
            _context.Entry(animal).State = EntityState.Modified;
            _context.SaveChanges();
            TempData["msg"] = "Animal atualizado!";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Alterar(int id)
        {
            //buscar o animal no banco de dados
            var animal = _context.Animais.Find(id);
            //retorna a página com os dados do animal
            return View(animal);
        }

        [HttpGet]
        public ActionResult Listar()
        {
            //Recupera os animais cadastrados no banco 
            var lista = _context.Animais.ToList();
            //Retorna a tela com a lista de animais
            return View(lista);
        }

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
            TempData["msg"] = "Cadastrado com sucesso!";
            return RedirectToAction("Cadastrar");
        }
    }
}