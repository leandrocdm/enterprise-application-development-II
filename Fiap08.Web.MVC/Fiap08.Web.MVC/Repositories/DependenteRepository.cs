using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap08.Web.MVC.Models;
using Fiap08.Web.MVC.Persistencia;

namespace Fiap08.Web.MVC.Repositories
{
    public class DependenteRepository : IDependenteRepository
    {
        private EscolaContext _context;

        public DependenteRepository(EscolaContext context)
        {
            _context = context;
        }

        public void Atualizar(Dependente dependente)
        {
            _context.Entry(dependente).State = EntityState.Modified;
        }

        public IList<Dependente> BuscarPor(Expression<Func<Dependente, bool>> filtro)
        {
            return _context.Dependentes.Include("Responsavel").Where(filtro).ToList();
        }

        public Dependente BuscarPorId(int codigo)
        {
            return _context.Dependentes.Find(codigo);
        }

        public void Cadastrar(Dependente dependente)
        {
            _context.Dependentes.Add(dependente);
        }

        public IList<Dependente> Listar()
        {
            return _context.Dependentes.Include("Responsavel").ToList();
        }

        public void Remover(int codigo)
        {
            var d = BuscarPorId(codigo);
            _context.Dependentes.Remove(d);
        }
    }
}