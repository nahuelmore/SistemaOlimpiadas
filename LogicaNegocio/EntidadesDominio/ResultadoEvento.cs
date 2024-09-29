using ExcepcionesPropias;
using LogicaNegocio.InterfacesDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesDominio
{
    public class ResultadoEvento : IValidable
    {
        public int Id { get; set; }
        public Evento Evento { get; set; }
        public Atleta Atleta { get; set; }
        public int Puntaje { get; set; }

        protected ResultadoEvento()
            {
            }
        public void Validar()
        {
            if (Evento == null) throw new UsuarioInvalidoException("El evento es obligatorio");
            if (Puntaje !>= 0) throw new UsuarioInvalidoException("La puntaje debe ser mayores o igual a 0");
        }
    }
}
