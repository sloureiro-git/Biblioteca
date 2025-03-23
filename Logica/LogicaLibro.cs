using System.Collections;
using Entidades;
using Persistencia;

namespace Logica
{
    public static class LogicaLibro
    {
        
        public static void añadirLibros(int id, string nombre, string autor, string genero, DateTime fechaDeLanzamiento, int cantidadDePaginas)
        {
            DateTime TiempoActual = fechaDeLanzamiento;

            Libro AltaLibro = new Libro(id, nombre, autor, genero, TiempoActual, cantidadDePaginas);

            PersistenciaLibro.Libros.Add(AltaLibro);
        }

        public static void eliminarLibros(int id)
        {
            for (int i = 0; i < PersistenciaLibro.Libros.Count; i++)
            {
                if ((PersistenciaLibro.Libros[i] as Libro).Id.Equals(id))
                {
                    PersistenciaLibro.Libros.Remove(PersistenciaLibro.Libros[i]);
                }
            }
        }

        public static void actualizarLibros(int id, string nombre, string autor, string genero, DateTime fechaDeLanzamiento, int cantidadDePaginas)
        {
            for (int i = 0; i < PersistenciaLibro.Libros.Count; i++)
            {
                if ((PersistenciaLibro.Libros[i] as Libro).Id.Equals(id))
                {
                    Libro Libro;
                    Libro = PersistenciaLibro.Libros[i] as Libro;

                    Libro.Nombre = nombre;
                    Libro.Autor = autor;
                    Libro.Genero = genero;
                    Libro.FechaDeLanzamiento = fechaDeLanzamiento;
                    Libro.CantidadDePaginas = cantidadDePaginas;
                }

                
            }
        }



        public static ArrayList listarLibros()
        {
            return PersistenciaLibro.Libros;
            

        }


    }
}

