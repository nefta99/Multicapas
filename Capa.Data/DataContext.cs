using Capa.Core.Entity;
using Capa.Data.EntityMap;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Data
{
    public class DataContext: DbContext
    {
        public DataContext():base("name= ServicioBecarioV2")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new RolesMap());
            modelBuilder.Configurations.Add(new RolesUsuariosMap());

        }
        public virtual DbSet<Usuario> UsuarioConexion { get; set; }
        public virtual DbSet<Roles> RolesConexion { get; set; }
        public virtual DbSet<RolesUsuarios> RolesUsuariosConexion { get; set; }
    }
}
