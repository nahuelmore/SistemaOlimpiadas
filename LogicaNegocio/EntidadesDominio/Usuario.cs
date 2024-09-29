using ExcepcionesPropias;
using LogicaNegocio.InterfacesDominio;
using LogicaNegocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesDominio
{
    public class Usuario : IValidable
    {
        public int Id { get; set; }
        [Required]
        public Email Email { get; set; } //Value Object
        public Contrasenia Contrasenia { get; set; } //Value Object
        public DateTime Creado {  get; set; }
        public Usuario Creador { get; set; }
        public int? IdCreador { get; set; }
        public Rol Rol { get; set; } //Entidad de dominio
        public int? IdRol { get; set; }

        public Usuario(Email email, Contrasenia pass, Rol rol, Usuario creador)
        {
            Email = email;
            Contrasenia = pass;
            Rol = rol;
            Creado = DateTime.Today;
            Creador = creador;
            Validar();
        }

        public Usuario(Email email, Contrasenia pass, int idRol, int idCreador)
        {
            Email = email;
            Contrasenia = pass;
            IdRol = idRol;
            Creado = DateTime.Today;
            IdCreador = idCreador;
            Validar();
        }

        protected Usuario() //LO AGREGAMOS PARA QUE EF PUEDA CREAR OBJETOS USUARIO
        {
        }

        public void Validar()
        {
            if (Email == null) throw new UsuarioInvalidoException("El email es obligatorio");
            if (Contrasenia == null) throw new UsuarioInvalidoException("La contraseña es obligatoria");
        }
    }
}
