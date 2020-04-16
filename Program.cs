using System;
using CoreEscuela.Entidades;
using static System.Console;
using System.Collections.Generic;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicializando objeto escuela
            var escuela = new Escuela("Huerto", "Rosario","Argentina",TipoEscuela.Primaria);
            
            //Creando la coleccion lista de los cursos
            escuela.Cursos = new List<Curso>()
            {
                    new Curso{Nombre = "101", Jornada = TipoJornada.Manana },
                    new Curso{Nombre = "201", Jornada = TipoJornada.Manana },
                    new Curso{Nombre = "301", Jornada = TipoJornada.Manana }
            };
            
            //Accediendo a la escuela/cursos/add que es la manera de agregar fuera del constructor
            escuela.Cursos.Add(new Curso{Nombre ="102",Jornada = TipoJornada.Tarder});
            escuela.Cursos.Add(new Curso{Nombre ="202",Jornada = TipoJornada.Tarder});
            escuela.Cursos.Add(new Curso{Nombre ="302",Jornada = TipoJornada.Tarder});


            //creadno otra coleccion para aderirlo otras propiedades dentro de colection
            //desde una coleccion externa fuera de la clase escuela 

            var otraColeccion = new List<Curso>()
            {
                    new Curso{Nombre = "401", Jornada = TipoJornada.Manana },
                    new Curso{Nombre = "501", Jornada = TipoJornada.Manana },
                    new Curso{Nombre = "601", Jornada = TipoJornada.Manana }
            };

            //Adiriendo a la clase escuela la coleccion externa

            escuela.Cursos.AddRange(otraColeccion);


            /*
            //Agregando cursos a escuela
            escuela.Cursos =  new Curso[]{
                    new Curso{Nombre = "101"},
                    new Curso{Nombre = "202"},
                    new Curso{Nombre = "202"}
            };*/

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
