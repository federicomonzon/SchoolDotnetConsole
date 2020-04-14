using System;
using CoreEscuela.Entidades;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicializando objeto escuela
            var escuela = new Escuela("Huerto", "Rosario","Argentina",TipoEscuela.Primaria);
            //Agregando cursos a escuela
            escuela.Cursos =  new Curso[]{
                    new Curso{Nombre = "101"},
                    new Curso{Nombre = "202"},
                    new Curso{Nombre = "202"}

            };

            ImprimirCursos(escuela);
        }

        private static void ImprimirCursos(Escuela escuela) // Imprimir cursos de una escuela
        {
            WriteLine("==========================");
            WriteLine("Cursos de la Escuelas : ");
            WriteLine("==========================");
            
            // Operador "?" es un "OR" primero va a chequear escuela que no sea null
            //luego si es true (distinto de null va a chequear Cursos)seria lo mismo que poner
            //if(escuela && escuela.Cursos != null)
            
            if (escuela?.Cursos != null) 
            {
                foreach (var cursos in escuela.Cursos)//recorrer e imprimir el curso de un obj escuela
                {
                    WriteLine($" Nombre: {cursos.Nombre}  ID : {cursos.UniqueID} ");
                }

            }

        }

        
        
    }
}
