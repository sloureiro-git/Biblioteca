namespace Entidades
{
    public class Libro
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public DateTime FechaDeLanzamiento { get; set; }
        public int CantidadDePaginas { get; set; }

        public string Display
        {
            get
            { return Id + ", " + Nombre; }
        }

        public Libro(int id, string nombre, string autor, string genero, DateTime fechaDeLanzamiento, int cantidadDePaginas)
        {
            Id = id;
            Nombre = nombre;
            Autor = autor;
            Genero = genero;
            FechaDeLanzamiento = fechaDeLanzamiento;
            CantidadDePaginas = cantidadDePaginas;
        }

        public Libro()
        {
            Id = 0;
            Nombre = "";
            Autor = "";
            Genero = "";
            FechaDeLanzamiento = DateTime.Now;
            CantidadDePaginas = 0;
        }
    }
}


