using ExcepcionesPropias;
using LogicaNegocio.InterfacesDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesDominio
{
    public class Pais : IValidable
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int hab { get; set; }
        public string tel { get; set; }


        protected Pais()
            {
            }
        public void Validar()
        {
            if (Nombre == null) throw new UsuarioInvalidoException("El nombre es obligatorio");
            if (hab !> 0) throw new UsuarioInvalidoException("La cantidad de habitantes debe ser mayores a 0");
            if (tel == null) throw new UsuarioInvalidoException("El telefono es obligatorio");
        }
    }
}
