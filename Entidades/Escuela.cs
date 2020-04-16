using System.Collections.Generic;


namespace CoreEscuela.Entidades
{
    class Escuela
    {   

        // Atributos
        private string nombre;
        public string Nombre
        {
            get { return "Copia: " + nombre; }
            set { nombre = value; }
        }
        
        public string Ciudad { get; set; }

        public string Pais { get; set; }

        public TipoEscuela TipoEscuelas { get; set; }

        public List<Curso> Cursos  { get; set; }

        public TipoJornada Jornada { get; set; }


        //CONSTRUCTORES
        public Escuela (string nombre, TipoEscuela tipo, TipoJornada jornada)
        {
            this.nombre = nombre;
            TipoEscuelas = tipo;
            TipoEscuelas = tipo;
            Jornada = jornada;
        }

        //CONSTRUCTOR CON SOBRECARGA 
                public Escuela (string nombre, string ciudad, string pais, TipoEscuela tipo)
        {
            this.nombre = nombre;
            Ciudad = ciudad;
            Pais = pais;
          
            
        }
        //Metodo para escribir el objeto en string
        public override string ToString()
        {
            return $"Nombre: {nombre} Ciudad : {Ciudad} \n Pais: {Pais} Tipo: {TipoEscuelas}";
        }
    }
}