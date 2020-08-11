using Capa.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.services.Repositorio
{
    public interface IUsuariosRepository : IRepository<Usuario>
    {
        Usuario GetUsuarioPorId(int id);
        int AgregaUser(string nombre, string pwd);
    }
}
