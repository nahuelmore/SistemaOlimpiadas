using ExcepcionesPropias;
using LogicaNegocio.InterfacesDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesDominio
{
    public class Rol : IValidable
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Rol()
            {
            }

        public void Validar()
            {
            if (Nombre == null) throw new UsuarioInvalidoException("El nombre es obligatorio");
            }

        }
    }
