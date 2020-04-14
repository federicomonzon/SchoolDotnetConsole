namespace CoreEscuela.Entidades
{
    class Escuela
    {   
        private string nombre;
        public string Nombre
        {
            get { return "Copia: " + nombre; }
            set { nombre = value; }
        }
        
        public string Ciudad { get; set; }

        public string Pais { get; set; }

        public TipoEscuela TipoEscuelas { get; set; }

        public Curso[] Cursos { get; set; }

        public Escuela (string nombre, TipoEscuela tipo)
        {
            this.nombre = nombre;
            TipoEscuelas = tipo;
        }
                public Escuela (string nombre, string ciudad, string pais, TipoEscuela tipo)
        {
            this.nombre = nombre;
            Ciudad = ciudad;
            Pais = pais;
            TipoEscuelas = tipo;
            
        }

        public override string ToString()
        {
            return $"Nombre: {nombre} Ciudad : {Ciudad} \n Pais: {Pais} Tipo: {TipoEscuelas}";
        }
    }
}