using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.Core.Entity;
using Capa.Core.VistaModelo;
using Capa.services;
using Capa.Util;

namespace Capa.Data.Modelo
{
    public class RolModelo
    {
        //Propiedades
        readonly IUnitOfWork unitOfWork = new UnitOfWork(new DataContext());

        public RolVistaModelo ObtenerRol(int p_id)
        {
            Roles rol;
            RolVistaModelo rvm = new RolVistaModelo();
            try
            {
                rol = unitOfWork.RolesRoute.GetRolesPorId(p_id);
                rvm.Id = rol.Id;
                rvm.Nombre = rol.Nombre;
            }
            catch(Exception e)
            {
                BitacoraEventos.InsertaError("RolModelo", "ObtenerRol", "Buscando Rol", (e.Message == null ? "" : e.Message) + " - " + (e.InnerException == null ? "" : e.InnerException.ToString()) + " - " + (e.StackTrace == null ? "" : e.StackTrace.ToString()), "L03036903");
                rvm.Id = 0;
                rvm.Nombre = "Vacio";
            }
            return rvm;
        }
    }
}
