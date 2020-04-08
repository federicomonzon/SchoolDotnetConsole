using System;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Huerto", "Rosario","Argentina",TipoEscuela.Primaria);
            System.Console.WriteLine(escuela);
        }
    }
}
