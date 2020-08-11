using Capa.Core.Entity;
using Capa.services.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Data.Repositorio
{
    public class RolesUsuariosRepository : Repository<RolesUsuarios>, IRolesUsuariosRepository
    {
        //Propiedades
        public DataContext Contexto { get { return Context as DataContext; } }
        //constructor
        public RolesUsuariosRepository(DataContext _context) : base(_context) { }


        //Metodos
        public RolesUsuarios GetRolesUsuariosPorId(int id)
        {
            return new RolesUsuarios();
        }

    }
}
