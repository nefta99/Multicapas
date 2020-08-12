using Capa.Core.Entity;
using Capa.services.Repositorio;
using Capa.Core.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Data.Repositorio
{
    public class RolesUsuariosRepository : Repository<RolesUsuarios>, IRolesUsuariosRepository
    {
        //Propiedades
        public DataContext Contexto {
            get {
                return Context as DataContext;
            }
        }
        //constructor
        public RolesUsuariosRepository(DataContext _context) : base(_context) { }


        //Metodos
        public List<ResultadoRolesUsuarioVistaModelo> GetRolesUsuariosPorId(int id)
        {
            List <ResultadoRolesUsuarioVistaModelo > lruvm = new List<ResultadoRolesUsuarioVistaModelo>();
            ResultadoRolesUsuarioVistaModelo x;
             lruvm = (
                     from r in Contexto.RolesConexion
                     join ru in Contexto.RolesUsuariosConexion on r.Id equals ru.RolId
                     join u in Contexto.UsuarioConexion on ru.UsuarioId equals u.Id
                     where r.Id == id
                     //Aqui hacemos la conversion para que pasen los valores a la clase resultado 
                     //que se imprime en la vista
                     select new ResultadoRolesUsuarioVistaModelo()
                     {
                         Nombre = u.Nombre, Password=u.Password, Rol=r.Nombre                       
                     }
                      ).ToList();
            
            //foreach (var temp in s)
            //{
            //    x = new ResultadoRolesUsuarioVistaModelo();
            //    x.Nombre =temp.Nombre;
            //    x.Password = temp.Password;
            //    x.Rol = temp.Rol;
            //    lruvm.Add(x);
            //}
            return lruvm;

        }

    }
}
