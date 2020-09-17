namespace Ejercicio
{
    public abstract class Ladron : Villano
    {
        protected int maldadesHechas;
        protected bool estaProfugo;
        protected Ladron(int maldadesHechas)
        {
            this.maldadesHechas = maldadesHechas;
            this.estaProfugo=true;
        }

        public override int Fuerza()
        {
            return maldadesHechas;
        }
    }
}