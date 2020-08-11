using Capa.Core.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Data.EntityMap
{
    public  class UsuarioMap: EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            ToTable("Usuario", "dbo");
            HasKey(p => p.Id);
            Property(p => p.Nombre).HasMaxLength(30).IsRequired();
            Property(p => p.Password).HasMaxLength(30).IsRequired();
        }
       
    }
}
