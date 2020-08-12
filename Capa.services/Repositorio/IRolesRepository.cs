using Capa.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.services.Repositorio
{
   public  interface IRolesRepository : IRepository<Roles>
    {
        Roles GetRolesPorId(int p_id);

    }
}
