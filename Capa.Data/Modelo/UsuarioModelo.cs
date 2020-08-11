using Capa.Core.Entity;
using Capa.Core.VistaModelo;
using Capa.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Capa.Data.Modelo
{
    public class UsuarioModelo
    {
        readonly IUnitOfWork unitOfWork = new UnitOfWork(new DataContext());
        public UsuarioVistaModelo ObtenerUsuarios(int id)
        {
            var usu = unitOfWork.UsuarioRoute.GetUsuarioPorId(id);
            UsuarioVistaModelo vim = new UsuarioVistaModelo();
            vim.Id = usu.Id;
            vim.Nombre = usu.Nombre;
            vim.Password = usu.Password;
            return vim;
        }
        public int agregauser(string nombre, string pwd)
        {
            var result = unitOfWork.UsuarioRoute.AgregaUser(nombre, pwd);
            return result;
        }

    }
}
