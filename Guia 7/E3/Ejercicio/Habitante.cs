namespace Ejercicio
{
    public class Habitante
    {
        protected int dinero;
        public Habitante(int dinero)
        {
            this.dinero = dinero;
        }

        public bool EsRico()
        {
            return dinero>5000000;
        }

        public bool EsClaseMedia()
        {
            return dinero>1000000 && dinero < 5000000;
        }
        public bool EsClaseBaja()
        {
            return dinero<1000000;
        }
    }
}