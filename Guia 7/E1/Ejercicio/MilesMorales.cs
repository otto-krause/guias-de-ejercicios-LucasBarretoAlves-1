namespace Ejercicio
{
    public class MilesMorales : Spiderman
    {
        protected int hablidadDeCanto;

        public MilesMorales(Traje traje, int fuerza, int hablidadDeCanto)
        {
            this.traje = traje;
            this.fuerza =fuerza;
            this.hablidadDeCanto = hablidadDeCanto;
        }

        public override int Poder()
        {
            return fuerza + hablidadDeCanto;
        }   
    }
}