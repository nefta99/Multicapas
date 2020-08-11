using Capa.Core.Entity;
using Capa.services.Repositorio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Data.Repositorio
{
   public  class UsuariosRepository : Repository<Usuario>, IUsuariosRepository
    {

        public UsuariosRepository(DataContext _context) : base(_context) { }
        public DataContext Contexto { get { return Context as DataContext; } }


        public Usuario GetUsuarioPorId(int id)
        {
            Usuario user =
                (from qry in Contexto.UsuarioConexion.Where(o => o.Id == id) select qry).FirstOrDefault();
            return user;
        }

        public int AgregaUser(string nombre, string pwd)
        {
            DataContext context = new DataContext();
            var datos = context.Database.SqlQuery<int>("AgregarUsuario @nombre, @password",
                                                                            new SqlParameter("@nombre", nombre),
                                                                            new SqlParameter("@password", pwd)).FirstOrDefault();
            return datos;
        }
    }
}
