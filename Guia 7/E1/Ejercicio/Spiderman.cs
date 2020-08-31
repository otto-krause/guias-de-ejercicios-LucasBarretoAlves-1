namespace Ejercicio
{
    public abstract class Spiderman
    {
        protected Traje traje;
        protected int fuerza;


        public abstract int Poder();

        public void Atacar(Kingpin kpin)
        {
            kpin.EsAtacado(this.Poder());
        }
    }
}