using System.Collections.Generic;
namespace E3
{
    public class Ponystation_pro_SaladaEdition : PonyStation4
    {
        public override void AgregarJuego (Juego juego)
        {
            this.listaDeJuegos.RemoveAt(0);
            this.listaDeJuegos.Add (juego);
            this.puntos += 25;
        }

        public override int RevisarPuntaje ()
        {
            return this.puntos / 2;
        }
    }
}