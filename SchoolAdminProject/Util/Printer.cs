using System;
using CoreEscuela.Entidades;
using static System.Console;



namespace CoreEscuela.Util
{
    static class Printer
    {
        public static void DibujarLinear(int tam = 10) => WriteLine("".PadLeft(tam,'='));

        public static void WriteTitle(string title)
        {
            var tamano = title.Length + 4;
            DibujarLinear(tamano);
            WriteLine($" | {title} | ");
            DibujarLinear(tamano);
            
        } 

         


        
    }
    
        
    
}

/*




*/