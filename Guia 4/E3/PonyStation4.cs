using System.Collections.Generic;
namespace E3
{
    public class PonyStation4 : Consola
    {
        public PonyStation4()
        {
            this.nombre= "PonyStation4";
        }
        public override void Jugar (int horas)
        {
            this.puntos += 3 * horas;
        }

        public override void AgregarJuego (Juego juego)
        {
            this.listaDeJuegos.Add (juego);
            this.puntos += 29;
        }
    }
}