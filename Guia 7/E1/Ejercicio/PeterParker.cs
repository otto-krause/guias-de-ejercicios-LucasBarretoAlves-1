namespace Ejercicio
{
    public class PeterParker : Spiderman
    {
        public PeterParker(Traje traje, int fuerza)
        {
            this.traje=traje;
            this.fuerza=fuerza;
        }

        public override int Poder()
        {
            return fuerza + traje.Resistencia;
        }
    }
}