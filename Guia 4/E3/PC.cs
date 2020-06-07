using System.Collections.Generic;
namespace E3
{
    public class PC : Consola
    {
        public PC()
        {
            this.nombre= "PC";
        }
        public override void AgregarJuego (Juego juego)
        {
            this.listaDeJuegos.Add (juego);
        }

        public override void Jugar (int horas)
        {
            this.puntos += 10 * horas;
        }
    }
}