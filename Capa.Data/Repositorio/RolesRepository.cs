using Capa.Core.Entity;
using Capa.Data;
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
        public Roles GetRolesPorId(int p_id)
        {
            // Roles rol = (from qry in Contexto.RolesConexion.Where(o => o.Id == r) select qry).FirstOrDefault();
            Roles rol = (   from qry in Contexto.RolesConexion
                            where qry.Id == p_id
                            select qry
                         ).FirstOrDefault();
            return rol;
        }
    }
}
