using ExcepcionesPropias;
using LogicaNegocio.InterfacesDominio;
using LogicaNegocio.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesDominio
{
    public class Evento : IValidable
    {
        public int Id { get; set; }
        public Disciplina Disciplina { get; set; }
        public int IdDisciplina { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public List<Atleta> Atletas { get; set; }
        public List<int> IdAtletas { get; set; }


        public Evento(Disciplina disciplina, string nombre, DateTime fechaInicio, DateTime fechaFin, List<Atleta> atletas)
            {
            Disciplina = disciplina;
            Nombre = nombre;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Atletas = atletas;
            }

        public Evento(int idDisciplina, string nombre, DateTime fechaInicio, DateTime fechaFin, List<int> idAtletas)
            {
            IdDisciplina = idDisciplina;
            Nombre = nombre;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            IdAtletas = idAtletas;
            }

        protected Evento()
            {
            }

        public void Validar()
            {
            if (Nombre == null) throw new UsuarioInvalidoException("El nombre es obligatorio");
            if (Disciplina == null) throw new UsuarioInvalidoException("La disciplina es obligatoria");
            }
        }
    }
