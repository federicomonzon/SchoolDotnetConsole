using System;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Huerto", "Rosario","Argentina",TipoEscuela.Primaria);
            
            var arregloCurso = new Curso[3];

            arregloCurso[0] = new Curso(){//Opcion uno de asignar un obj a un arreglo
                                Nombre = " 101 "
                            };

            var curso2 = new Curso(){
                Nombre = " 202 "
            };
            arregloCurso[1]= curso2; //Opcion n2

            arregloCurso[2]= new Curso{
                                Nombre = " 303 "
                            };

            ImprimirCursos(arregloCurso);
        }



        public static void ImprimirCursos(Curso[] arregloCurso)
        {
            System.Console.WriteLine( "Lista de cursos : " );
            
            /*
            for (int i = 0; i < arregloCurso.Length; i++)
            {
                System.Console.WriteLine($"Nombre :  {arregloCurso[i].Nombre} \nUnique Id : {arregloCurso[i].UniqueID}");   
            }
            */

            foreach (var curso in arregloCurso)
            {
                System.Console.WriteLine($"Nombre :  {curso.Nombre} \nUnique Id : {curso.UniqueID}");   
            }
        
        }
    }
}
