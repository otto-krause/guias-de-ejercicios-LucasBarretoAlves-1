using System;
using System.Collections.Generic;
namespace E4
{
    public class Tragalibros
    {
        private int contador;
        List<Libro> librosleidos = new List<Libro> ();
        public Tragalibros()
        {
            this.contador=0;
        }
        public void Leer (Libro libro)
        {
            if (NoEsRepetido (libro))
                librosleidos.Add (libro);     
        }

        public int CalcularCI()
        {
            foreach (Libro libro in librosleidos)
            {
                contador++;
            }
            return 5*contador;
        }

        private bool NoEsRepetido(Libro libro)
        {
            foreach (Libro leido in librosleidos)
            {
                if (leido.Titulo == libro.Titulo)
                    return false;
            }
            return true;
        }
    }
}