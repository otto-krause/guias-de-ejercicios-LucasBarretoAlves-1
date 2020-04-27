using System;
using System.Collections.Generic;
namespace E4
{
    public class Peliteca
    {
        List <Pelicula> peliteca= new List <Pelicula>();
        List <Pelicula> busqueda= new List <Pelicula>();
        public List<Pelicula> Busqueda {get => busqueda;}
        public Peliteca()
        {
            Pelicula lavenganza = new Pelicula("La venganza", "Accion", 2000, "Pepe Liculas");
            Pelicula lamaldicion= new Pelicula("La maldicion", "Terror",  1994, "Lupe Liculas");
            Pelicula labroma = new Pelicula("La broma", "Comedia",  1996, "Carlos");
            Pelicula elfuturo = new Pelicula("El futuro", "Ciencia Ficcion",  3140, "Si");
            Pelicula lavenganza2 = new Pelicula("La venganza 2", "Accion", 2004, "Pepe Liculas");
            Pelicula lamaldicion2= new Pelicula("La maldicion 2", "Terror",  1997, "Lupe Liculas");
            Pelicula labroma2 = new Pelicula("La broma 2", "Comedia",  2000, "Carlos");
            Pelicula elfuturo2 = new Pelicula("El futuro 2", "Ciencia Ficcion",  3300, "Quizas");
            peliteca.Add(lavenganza);
            peliteca.Add(lamaldicion);
            peliteca.Add(labroma);
            peliteca.Add(elfuturo);
            peliteca.Add(lavenganza2);
            peliteca.Add(lamaldicion2);
            peliteca.Add(labroma2);
            peliteca.Add(elfuturo2);
      
        }
        public void PorGenero(string genero)
        {
            foreach (Pelicula peli in peliteca)
            {
                if (peli.Genero==genero)
                    busqueda.Add(peli);
            }
        }
        public void PorNombre(string nombre)
        {
            foreach (Pelicula peli in peliteca)
            {
                if (peli.Nombre==nombre)
                    busqueda.Add(peli);
            }
        }
        public void PorAnio(int anio)
        {
            foreach (Pelicula peli in peliteca)
            {
                if (peli.Anio==anio)
                    busqueda.Add(peli);
            }
        }
        public void PorDirector(string director)
        {
            foreach (Pelicula peli in peliteca)
            {
                if (peli.Director==director)
                    busqueda.Add(peli);
            }
        }
        public int CantidadPeliculas()
        {
            return peliteca.Count;
        }
        public int CantidadGenero(string genero)
        {
            int cont=0;
            foreach (Pelicula peli in peliteca)
            {
                if (peli.Genero==genero)
                    cont++;
            }
            return cont;
        }
    }
}