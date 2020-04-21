using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;
using CoreEscuela.App;



namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello world");
        }
         private static void ImprimirCursos(Escuela escuela)
        {
            
            Printer.WriteTitle("Cursos de escuela :");

             if (escuela?.Cursos != null)
            {
                foreach (var cursos in escuela.Cursos)
                {
                    WriteLine($" Nombre: {cursos.Nombre}  ID : {cursos.UniqueID} ");
                }

            }
        }
    }
}
