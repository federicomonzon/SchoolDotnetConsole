using System;

using CoreEscuela.Entidades;
using static System.Console;
using System.Collections.Generic;
using CoreEscuela.Util;


namespace CoreEscuela.Entidades
{
    public class Evaluacion
    {
            
        public string Nombre { get; set; }

        public string  UniqueID { get; private set; }

        public Alumno Alumno { get; set; }

        public Asignatura Asignatura { get; set; }

        public float Nota { get; set; }

        public Evaluacion()=>UniqueID = Guid.NewGuid().ToString(); // Esto genera un codigo unico. 

        
    }
}