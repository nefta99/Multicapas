using Capa.Core.Entity;
using Capa.services.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Data.Repositorio
{
   public class RolesRepository : Repository<Roles>, IRolesRepository
    {
        public RolesRepository(DataContext _context) : base(_context) { }
        public DataContext Contexto { get { return Context as DataContext; } }
        public Roles GetRolesPorId(int r)
        {

            return new Roles();
        }
    }
}
