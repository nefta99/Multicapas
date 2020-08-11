using Capa.services.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.services
{
   public  interface IUnitOfWork: IDisposable
    {
        IUsuariosRepository UsuarioRoute { get; }
        int Complete();
    }
}
