using Capa.Core.Entity;
using Capa.Core.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.services.Repositorio
{
    public interface IRolesUsuariosRepository /*: IRepository<RolesUsuarios>*/
    {
        List<ResultadoRolesUsuarioVistaModelo> GetRolesUsuariosPorId(int id);
    }
}
