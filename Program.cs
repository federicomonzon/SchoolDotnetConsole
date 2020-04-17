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


            //Esta opcion nos deja eliminar una coleccion dentro que hayamos agregado externa
            //otraColeccion.Clear();
//@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@


            //Otros  metodos para eliminar cursos:

            //Opcion 1:
            //este remueve tan solo un objeto;
            //Primero agregamos un nuevo curso a la clase
            Curso temp = new Curso{Nombre = "999 - Vacaciones", Jornada = TipoJornada.Noche};
            escuela.Cursos.Add(temp);

            //luego accedemos a su hash que es es un uniqueID de la manera que C# borra un elemento con este metodo
 //           WriteLine("Curso Hash code : " + temp.GetHashCode());

            //Borramos el curso
//            escuela.Cursos.Remove(temp);
            
            /*
            //Agregando cursos a escuela con arrays
            escuela.Cursos =  new Curso[]{
                    new Curso{Nombre = "101"},
                    new Curso{Nombre = "202"},
                    new Curso{Nombre = "202"}
            };*/

            ImprimirCursos(escuela);


            //Opcion numero 2 (predicado)
/*
Este tipo de remover un elemento utiliza un metodo privado booleano que analiza cada curso en este caso y 
lo va a comprar con el que nosotros queremos borra , vease predicado metodo
*/


/* %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

Lo que estoy aclarando con esta funcion es que voy a proteger mi algoritmo removeAll para qeu no se le pase
cualquier otro dato que no sea un objeto
seria como ponerle las reglas y en este caso seria:
@ Predicador vas a analizar la Colleccion cursos;
@ Predicador te voy a llamar miAlgoritmo;
@Vas a ser igual a "predicado" que es un parametro dentro del metedo RemoveAll
@RemoveAll es un metodo dentro de tu clase predicador
@El parametro "predicado" es un metodo privado booleano que analiza los objetos de Cursos
@ y es el siguiente         
    private static bool predicado(Curso CursoObj)
        {
            return CursoObj.Nombre == "601";
        }
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%*/

/*
########################################################################


// es opcional ahora            Predicate<Curso> miAlgoritmo = predicado;
            escuela.Cursos.RemoveAll(predicado);

            ImprimirCursos(escuela);
        }

        private static bool predicado(Curso CursoObj)
        {
            return CursoObj.Nombre == "601";
        }

        #########################################################################*/

/*  ESTA ES LA MANERA  CON DELEGADO DE HACER LO MISMO QUE ESTA ARRIBA*

        escuela.Cursos.RemoveAll(delegate(Curso cur)
                                {
                                    return cur.Nombre =="601";
                                });

         
    
################################################################################*/

        /*Opcion lambda de lo mismo que arriba 
        El compilado por detras esta haciendo esto:   
        escuela.Cursos.RemoveAll(delegate(cur)=> cur.Nombre =="601");    
       */
            escuela.Cursos.RemoveAll((cur)=> cur.Nombre == "601" && cur.Jornada == TipoJornada.Tarder);


        }
         private static void ImprimirCursos(Escuela escuela)
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