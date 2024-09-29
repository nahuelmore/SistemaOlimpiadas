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
    public class Atleta : IValidable
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public Pais Pais { get; set; }
        public List<Disciplina> Disiplinas { get; set; }

        protected Atleta()
            {
            }

        public void Validar()
        {
            if (Nombre == null) throw new UsuarioInvalidoException("El nombre es obligatorio");
            if (Sexo == null) throw new UsuarioInvalidoException("El sexo es obligatorio");
            if (Pais == null) throw new UsuarioInvalidoException("El pais es obligatorio");
        }
    }
}
