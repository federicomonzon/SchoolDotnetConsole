using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;

namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public string Nombre { get; set; }

        public string  UniqueID { get; private set; }

        public TipoJornada Jornada { get; set; }

        public List<Asignatura> Asignaturas {get; set;}

        public List<Alumno> Alumnos {get; set;}
        

        public Curso()=>UniqueID = Guid.NewGuid().ToString(); // Esto genera un codigo unico. 
    }
}