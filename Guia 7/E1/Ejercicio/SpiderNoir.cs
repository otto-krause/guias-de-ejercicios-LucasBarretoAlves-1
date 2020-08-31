namespace Ejercicio
{
    public class SpiderNoir : Spiderman
    {
        public SpiderNoir(Traje traje, int fuerza)
        {
            this.traje=traje;
            this.fuerza=fuerza;
        }

        public override int Poder()
        {
            return fuerza + traje.Resistencia + traje.CantidadDeArmas();
        }
    }
}