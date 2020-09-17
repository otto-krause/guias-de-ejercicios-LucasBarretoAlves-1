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
            if (glamour<1 || glamour>10)
            {
                throw new Exception("El glamour ingresado está fuera de rango");
            }
        }

        public override int Poder()
        {
            return fuerza + glamour;
        }
    }
}