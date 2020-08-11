using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Core.Entity
{
   public class RolesUsuarios
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int RoleId { get; set; }
        public Usuario Usuario { get; set; }
        public Roles Roles { get; set; }

    }
}
