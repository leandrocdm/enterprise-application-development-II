using Fiap.NAC.Correcao.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fiap.NAC.Correcao.Repository;

namespace Fiap.NAC.Correcao.Units
{
    public class UnitOfWork : IDisposable
    {
        private BarContext _context = new BarContext();

        private IBebidaRepository _bebidaRepository;

        public IBebidaRepository BebidaRepository
        {
            get
            {
                if (_bebidaRepository == null)
                {
                    _bebidaRepository = new BebidaRepository(_context);
                }
                return _bebidaRepository;
            }
        }


        public void Salvar()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}