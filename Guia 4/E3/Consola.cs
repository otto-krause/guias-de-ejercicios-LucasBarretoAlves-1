using System.Collections.Generic;
namespace E3
{
    public abstract class Consola
    {
        protected List<Juego> listaDeJuegos;
        protected List<Juego> auxiliar;

        protected int puntos;
        protected string nombre;
        public string Nombre {get => nombre;}

        public Consola ()
        {
            this.listaDeJuegos = new List<Juego> ();
            this.auxiliar = new List<Juego>();  
            this.puntos = 0;  
        }

        public virtual int RevisarPuntaje ()
        {
            return puntos;
        }
        public Juego elMasNuevo ()
        {
            return this.listaDeJuegos[(listaDeJuegos.Count)-1];
        }

        public Juego elMasViejo ()
        {
            return this.listaDeJuegos[0];
        }

        public abstract void AgregarJuego (Juego juego);

        public abstract void Jugar (int horas);
    }
}