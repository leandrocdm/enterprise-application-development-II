using Fiap08.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Fiap08.Web.MVC.Repositories
{
    public interface IDependenteRepository
    {
        void Cadastrar(Dependente dependente);
        void Atualizar(Dependente dependente);
        void Remover(int codigo);
        Dependente BuscarPorId(int codigo);
        IList<Dependente> Listar();
        IList<Dependente> BuscarPor(Expression<Func<Dependente,bool>> filtro);
    }
}