using Capa.Data.Repositorio;
using Capa.services;
using Capa.services.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Data
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly DataContext _context;
        public int Complete() { return _context.SaveChanges(); }
        public void Dispose() { _context.Dispose(); }

        public UnitOfWork(DataContext context)
        {
            _context = context;
            UsuarioRoute = new UsuariosRepository(_context);
        }

        public IUsuariosRepository UsuarioRoute { get; private set; }
    }
}
