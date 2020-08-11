﻿using Capa.Core.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Data.EntityMap
{
    public class RolesUsuariosMap : EntityTypeConfiguration<RolesUsuarios>
    {
        public RolesUsuariosMap() { 
            ToTable("RolesUsuarios", "dbo");
            HasKey(p => p.Id);
        }
    }
}
