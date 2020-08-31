namespace Ejercicio
{
    public class SpiderGwen : Spiderman
    {
        protected int glamour;

        public SpiderGwen(Traje traje, int fuerza, int glamour)
        {
            this.traje = traje;
            this.fuerza = fuerza;
            this.glamour = glamour;
        }

        public override int Poder()
        {
            return fuerza + glamour;
        }
    }
}