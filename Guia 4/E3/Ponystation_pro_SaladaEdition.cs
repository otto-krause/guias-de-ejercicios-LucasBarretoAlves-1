namespace E3
{
    public class Ponystation_pro_SaladaEdition : Ponystation
    {
        public override void AgregarJuego (Juego juego)
        {
            this.listaDeJuegos.Remove ();
            this.listaDeJuegos.Add (juego);
            this.puntos += 25;
        }

        public override int RevisarPuntaje ()
        {
            return this.puntos / 2;
        }
    }
}