using Capa.services;
using Capa.Core.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.Util;

namespace Capa.Data.Modelo
{
   public class RolesUsuariosModelo
    {
        //Propiedades
        readonly IUnitOfWork unitOfWork = new UnitOfWork(new DataContext());

        //Metodos
        public List<ResultadoRolesUsuarioVistaModelo> BuscarRolesPorId(int p_id)
        {
            List<ResultadoRolesUsuarioVistaModelo> lvalor = new List<ResultadoRolesUsuarioVistaModelo>();
            try
            {
                lvalor = unitOfWork.RolesUsuariosRoute.GetRolesUsuariosPorId(p_id);
            }
            catch(Exception e)
            {
                ResultadoRolesUsuarioVistaModelo x = new ResultadoRolesUsuarioVistaModelo();
                x.Nombre = "No hay";
                x.Password = "No hay";
                x.Rol = "No hay";
                lvalor.Add(x);
                BitacoraEventos.InsertaError("RolesUsuarioModelo", "BuscarRolesPorId", "Buscando Rol con uniones", (e.Message == null ? "" : e.Message) + " - " + (e.InnerException == null ? "" : e.InnerException.ToString()) + " - " + (e.StackTrace == null ? "" : e.StackTrace.ToString()), "L03036903");
            }
             
            return lvalor;

        }
    }
}
