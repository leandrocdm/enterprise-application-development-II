using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public IList<Dependente> BuscarPor(Expression<Func<Dependente, bool>> filtro)
        {
            throw new NotImplementedException();
        }

        public Dependente BuscarPorId(int codigo)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Dependente dependente)
        {
            throw new NotImplementedException();
        }

        public IList<Dependente> Listar()
        {
            throw new NotImplementedException();
        }

        public void Remover(int codigo)
        {
            throw new NotImplementedException();
        }
    }
}