using ExcepcionesPropias;
using LogicaNegocio.InterfacesDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesDominio
{
    public class Disciplina : IValidable
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int AñoIncluida { get; set; }




        protected Disciplina() 
            {
            }

        public void Validar()
            {
            if (Nombre == null) throw new UsuarioInvalidoException("El nombre es obligatorio");
            if (AñoIncluida < 1895) throw new UsuarioInvalidoException("El año de incluida en los juegos debe ser mayor a 1895");
            }
        }
    }

