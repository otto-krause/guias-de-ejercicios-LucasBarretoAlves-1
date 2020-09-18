namespace Ejercicio
{
    public class Red : Pajaro
    {
        protected int cantidadDeEnojos;
        public Red(int ira, int cantidadDeEnojos)
        {
            this.ira = ira;
            this.cantidadDeEnojos = cantidadDeEnojos;
        }

        public abstract void SeEnoja()
        {
            ira *= 2;
            cantidadDeEnojos += 1;
        }

        public abstract int Fuerza()
        {
            ira * 10 * cantidadDeEnojos;
        }
    }

}