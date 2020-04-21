using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;

namespace CoreEscuela.App
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {

        }

        public void Inicializar()
        {
            Escuela = new Escuela("Huerto", "Rosario", "Argentina", TipoEscuela.Primaria);

            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();

        }

        private void CargarEvaluaciones()
        {
            throw new NotImplementedException();
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                List<Asignatura>listaAsignatura = new List<Asignatura>(){
                                new Asignatura{Nombre = "Matematicas"},
                                new Asignatura{Nombre = "Educacion Fisica"},
                                new Asignatura{Nombre = "Castellano"},
                                new Asignatura{Nombre = "Quimica"}
                };
                curso.Asignaturas = listaAsignatura;
            }
        }

        private List <Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string [] nombre1 = {"Ricardo", "Roberta","Eugenia","Catalina","Franco","Eloin"};
            string [] apellido1 = {"kistender", "Zofobich","Terrans","Contini","Mokachini","Tortita"};
            string [] nombre2 = {"Manuel", "Joel", "Pedro", "James", "David"};

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno {Nombre = $"{n1} {n2} {a1}"};
            
            return listaAlumnos.OrderBy((al) => al.UniqueID.Take(cantidad)).ToList();
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>()
            {
                    new Curso{Nombre = "101", Jornada = TipoJornada.Manana },
                    new Curso{Nombre = "201", Jornada = TipoJornada.Manana },
                    new Curso{Nombre = "301", Jornada = TipoJornada.Manana }
            };
            Escuela.Cursos.Add(new Curso { Nombre = "102", Jornada = TipoJornada.Tarder });
            Escuela.Cursos.Add(new Curso { Nombre = "202", Jornada = TipoJornada.Tarder });
            Escuela.Cursos.Add(new Curso { Nombre = "302", Jornada = TipoJornada.Tarder });



            Random rnd = new Random();
            foreach (var c in Escuela.Cursos)
            {
                int cantidadRandom = rnd.Next(5,25);
                c.Alumnos = GenerarAlumnosAlAzar(cantidadRandom);
            }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}