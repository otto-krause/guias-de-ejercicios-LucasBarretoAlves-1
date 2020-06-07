using System.Collections.Generic;
namespace E3
{
    public class CajaX : Consola
    {
        public CajaX()
        {
            this.nombre="CajaX";
        }
        public override void Jugar (int horas)
        {
            this.puntos += 4 * horas;
        }

        public override void AgregarJuego (Juego juego)
        {
            this.listaDeJuegos.Add (juego);
            this.puntos += 25;
        }
    }
}