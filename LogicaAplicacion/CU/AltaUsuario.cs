using DTO.Mappers;
using DTO.Objetos;
using ExcepcionesPropias;
using LogicaAplicacion.ICU;
using LogicaNegocio.EntidadesDominio;
using LogicaNegocio.InterfacesRepositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAplicacion.CU
{
    public class AltaUsuario : IAltaUsuario
    {

        public IRepositorioUsuarios RepositorioUsuarios { get; set; }
        public IRepositorioRoles RepositorioRoles { get; set; }

        public AltaUsuario(IRepositorioUsuarios repositorioUsuarios, IRepositorioRoles repositorioRoles)
        {
            RepositorioUsuarios = repositorioUsuarios;
            RepositorioRoles = repositorioRoles;
        }
        public void Alta(AltaUsuarioDTO nuevo)
        {
            Usuario usu = UsuariosMapper.ToUsuario(nuevo);
            Rol rol = RepositorioRoles.FindById(usu.IdRol);
            Usuario creador = RepositorioUsuarios.FindById(nuevo.IdCreador);

            if (rol == null)
            {
                throw new UsuarioInvalidoException("El rol seleccionado no existe");
            }
            if (creador == null)
            {
                throw new UsuarioInvalidoException("El creador seleccionado no existe");
            }
            else if (creador.Rol.Nombre != "Administrador") {

                throw new UsuarioInvalidoException("El creador seleccionado no esta autorizado");

            }
            usu.Rol = rol;
            usu.Creador= creador;

            RepositorioUsuarios.Add(usu);
        }
    }
}
