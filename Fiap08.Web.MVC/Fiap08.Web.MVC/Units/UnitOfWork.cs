using Fiap08.Web.MVC.Persistencia;
using Fiap08.Web.MVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap08.Web.MVC.Units
{
    public class UnitOfWork : IDisposable
    {
        private EscolaContext _context = new EscolaContext();

        //propfull
        private IResponsavelRepository _responsavelRepository;

        public IResponsavelRepository ResponsavelRepository
        {
            get
            {
                if (_responsavelRepository == null)
                {
                    _responsavelRepository = new ResponsavelRespository(_context);
                }
                return _responsavelRepository;
            }
        }

        //Liberar a conexão com o banco de dados
        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }

    }
}