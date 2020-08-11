using Capa.Core.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Data.EntityMap
{
    public class RolesMap : EntityTypeConfiguration<Roles>
    {
        public RolesMap()
        {
            ToTable("Roles", "dbo");
            HasKey(p => p.Id);
            Property(p => p.Nombre).HasMaxLength(30).IsRequired();
            
        }
    }
}
